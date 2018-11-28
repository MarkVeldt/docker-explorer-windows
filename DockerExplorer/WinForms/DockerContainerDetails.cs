﻿using System.Collections.Generic;
using System.Windows.Forms;
using DockerExplorer.Model;
using Docker.DotNet.Models;
using System.Diagnostics;
using DockerExplorer.Presenters;
using System;

namespace DockerExplorer.WinForms
{
   public partial class DockerContainerDetails : UserControl, IProgress<ContainerStatsResponse>, IProgress<string>
   {
      public DockerContainerDetails()
      {
         InitializeComponent();
      }

      internal DockerPresenter Presenter { get; set; }

      public DockerContainer DockerContainer
      {
         set
         {
            // set labels
            containerLabels.Items.Clear();
            foreach (KeyValuePair<string, string> label in value.Labels)
            {
               containerLabels.Items.Add(
                  new ListViewItem(new[] { label.Key, label.Value }, 0));
            }
            containerLabels.AutoAlign();

            //set mounts
            containerMounts.Items.Clear();
            foreach(MountPoint mount in value.Mounts)
            {
               containerMounts.Items.Add(
                  new ListViewItem(new[]
                  {
                     mount.Type,
                     mount.Name,
                     mount.Source,
                     mount.Destination,
                     mount.Driver,
                     mount.Mode,
                     mount.RW.ToString(),
                     mount.Propagation
                  }, 0)
                  { Tag = mount });
            }
            containerMounts.AutoAlign();

            //listen for updates
            //Presenter.GetContainerDetailsAsync(value.Id, this);
            Presenter.GetContainerLogs(value.Id, this);
         }
      }

      private void containerMounts_MouseDoubleClick(object sender, MouseEventArgs e)
      {
         if (containerMounts.SelectedItems.Count == 0)
            return;

         MountPoint mountPoint = containerMounts.Items[containerMounts.SelectedIndices[0]].Tag as MountPoint;

         string path = mountPoint.Source;

         Process.Start(path);
      }

      double _prevCpu = 0;
      double _prevSystem = 0;
      int _pointIdx = 0;

      public void Report(ContainerStatsResponse value)
      {
         //see https://stackoverflow.com/questions/30271942/get-docker-container-cpu-usage-as-percentage

         double cpu = 0;
         double cpuDelta = value.CPUStats.CPUUsage.TotalUsage - _prevCpu;
         double systemDelta = value.CPUStats.SystemUsage - _prevSystem;

         if(cpuDelta > 0 && systemDelta > 0)
         {
            cpu = (cpuDelta / systemDelta) * value.CPUStats.CPUUsage.PercpuUsage.Count * 100;
         }

         _prevCpu = value.CPUStats.CPUUsage.TotalUsage;
         _prevSystem = value.CPUStats.SystemUsage;
      }

      public void Report(string value)
      {
         richLogs.AppendText(value);
      }
   }
}
