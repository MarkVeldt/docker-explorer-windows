﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DockerExplorer.Presenters;
using DockerExplorer.Model;
using NetBox.Extensions;
using DockerExplorer.WinForms;

namespace DockerExplorer
{
   public partial class DockerServerControl : UserControl
   {
      private static readonly Dictionary<string, TimeSpan> _updateTextToValue = new Dictionary<string, TimeSpan>
      {
         ["no refresh"] = TimeSpan.MaxValue,
         ["1 second"] = TimeSpan.FromSeconds(1),
         ["1 minute"] = TimeSpan.FromMinutes(1)
      };

      private IMainToolbarClient[] _toolbarClients;

      public DockerServerControl()
      {
         InitializeComponent();

         comboUpdateInterval.ComboBox.DataSource =
            _updateTextToValue.Select(i => new TaggedString<TimeSpan>(i.Key, i.Value)).ToArray();
         comboUpdateInterval.ComboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
         UpdateInterval = Settings.Instance.AutoRefreshContainersInterval;

         _toolbarClients = new IMainToolbarClient[] { dockerImages1, dockerContainers1 };
      }

      private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
      {
         TaggedString<TimeSpan> selected = (TaggedString<TimeSpan>)comboUpdateInterval.ComboBox.SelectedValue;

         Settings.Instance.AutoRefreshContainersInterval = selected.Value;
      }

      private TimeSpan UpdateInterval
      {
         get
         {
            try
            {
               var selected = (TaggedString<TimeSpan>)comboUpdateInterval.ComboBox.SelectedValue;

               return selected.Value;
            }
            catch (Exception)
            {
               return TimeSpan.MaxValue;
            }
         }
         set
         {
            int selected = -1;

            //find item
            int i = 0;
            foreach (TaggedString<TimeSpan> item in comboUpdateInterval.ComboBox.Items)
            {
               if (item.Value == value)
               {
                  selected = i;
                  break;
               }
               i++;
            }

            if (selected == -1)
            {
               selected = 0;
            }

            comboUpdateInterval.ComboBox.SelectedIndex = selected;
         }
      }

      private void refreshToolButton_Click(object sender, EventArgs e)
      {
         _toolbarClients.ForEach(tc => tc.RefreshAll()).ToList();
      }
   }
}
