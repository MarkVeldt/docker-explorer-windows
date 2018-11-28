﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DockerExplorer.WinForms;

namespace DockerExplorer
{
   public partial class MainForm : Form
   {
      public MainForm()
      {
         InitializeComponent();

         this.AutoScaleMode = AutoScaleMode.Dpi;
      }

      private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
      {
         new AboutForm().ShowDialog(this);
      }
   }
}
