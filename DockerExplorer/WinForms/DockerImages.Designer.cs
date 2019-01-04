﻿namespace DockerExplorer.WinForms
{
   partial class DockerImages
   {
      /// <summary> 
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary> 
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Component Designer generated code

      /// <summary> 
      /// Required method for Designer support - do not modify 
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Splitter splitter2;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.GroupBox groupBox1;
            System.Windows.Forms.ColumnHeader ID;
            System.Windows.Forms.ColumnHeader Created;
            System.Windows.Forms.ColumnHeader By;
            System.Windows.Forms.ColumnHeader Size;
            System.Windows.Forms.ColumnHeader Comment;
            System.Windows.Forms.ColumnHeader Tags;
            System.Windows.Forms.ColumnHeader columnHeader1;
            this.listContainerHistory = new System.Windows.Forms.ListView();
            this.treeDockerImages = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkParentId = new System.Windows.Forms.LinkLabel();
            this.txtTag = new System.Windows.Forms.TextBox();
            this.txtRepository = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listDockerImages = new System.Windows.Forms.ListView();
            this.checkHideNoRepos = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            splitter2 = new System.Windows.Forms.Splitter();
            label5 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Created = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            By = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Comment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Tags = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(17, 136);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(110, 25);
            label4.TabIndex = 6;
            label4.Text = "Repository:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(70, 94);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(57, 25);
            label3.TabIndex = 4;
            label3.Text = "Size:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(28, 52);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(99, 25);
            label2.TabIndex = 1;
            label2.Text = "Parent ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(90, 12);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(37, 25);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // splitter2
            // 
            splitter2.Location = new System.Drawing.Point(416, 0);
            splitter2.Name = "splitter2";
            splitter2.Size = new System.Drawing.Size(7, 1068);
            splitter2.TabIndex = 4;
            splitter2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(70, 180);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(53, 25);
            label5.TabIndex = 10;
            label5.Text = "Tag:";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            groupBox1.Controls.Add(this.listContainerHistory);
            groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            groupBox1.Location = new System.Drawing.Point(22, 235);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(943, 819);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "History";
            // 
            // listContainerHistory
            // 
            this.listContainerHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listContainerHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            ID,
            Created,
            By,
            Size,
            Comment,
            Tags});
            this.listContainerHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listContainerHistory.FullRowSelect = true;
            this.listContainerHistory.GridLines = true;
            this.listContainerHistory.Location = new System.Drawing.Point(3, 25);
            this.listContainerHistory.Name = "listContainerHistory";
            this.listContainerHistory.Size = new System.Drawing.Size(937, 791);
            this.listContainerHistory.TabIndex = 0;
            this.listContainerHistory.UseCompatibleStateImageBehavior = false;
            this.listContainerHistory.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            ID.Text = "ID";
            // 
            // Created
            // 
            Created.Text = "Created";
            // 
            // By
            // 
            By.Text = "By";
            // 
            // Size
            // 
            Size.Text = "Size";
            // 
            // Comment
            // 
            Comment.Text = "Comment";
            // 
            // Tags
            // 
            Tags.Text = "Tags";
            // 
            // treeDockerImages
            // 
            this.treeDockerImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeDockerImages.HideSelection = false;
            this.treeDockerImages.Location = new System.Drawing.Point(3, 3);
            this.treeDockerImages.Name = "treeDockerImages";
            this.treeDockerImages.Size = new System.Drawing.Size(374, 1054);
            this.treeDockerImages.TabIndex = 1;
            this.treeDockerImages.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeDockerImages_AfterSelect);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkParentId);
            this.panel1.Controls.Add(groupBox1);
            this.panel1.Controls.Add(this.txtTag);
            this.panel1.Controls.Add(label5);
            this.panel1.Controls.Add(this.txtRepository);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(label4);
            this.panel1.Controls.Add(this.txtSize);
            this.panel1.Controls.Add(label3);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(label2);
            this.panel1.Controls.Add(label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(423, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 1068);
            this.panel1.TabIndex = 3;
            // 
            // linkParentId
            // 
            this.linkParentId.AutoSize = true;
            this.linkParentId.Location = new System.Drawing.Point(133, 52);
            this.linkParentId.Name = "linkParentId";
            this.linkParentId.Size = new System.Drawing.Size(82, 25);
            this.linkParentId.TabIndex = 13;
            this.linkParentId.TabStop = true;
            this.linkParentId.Text = "parent...";
            this.linkParentId.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkParentId_LinkClicked);
            // 
            // txtTag
            // 
            this.txtTag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTag.Location = new System.Drawing.Point(134, 179);
            this.txtTag.Name = "txtTag";
            this.txtTag.ReadOnly = true;
            this.txtTag.Size = new System.Drawing.Size(832, 22);
            this.txtTag.TabIndex = 11;
            // 
            // txtRepository
            // 
            this.txtRepository.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRepository.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRepository.Location = new System.Drawing.Point(133, 136);
            this.txtRepository.Name = "txtRepository";
            this.txtRepository.ReadOnly = true;
            this.txtRepository.Size = new System.Drawing.Size(832, 22);
            this.txtRepository.TabIndex = 9;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 1068);
            this.splitter1.TabIndex = 8;
            this.splitter1.TabStop = false;
            // 
            // txtSize
            // 
            this.txtSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSize.Location = new System.Drawing.Point(134, 94);
            this.txtSize.Name = "txtSize";
            this.txtSize.ReadOnly = true;
            this.txtSize.Size = new System.Drawing.Size(832, 22);
            this.txtSize.TabIndex = 5;
            // 
            // txtId
            // 
            this.txtId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.Location = new System.Drawing.Point(134, 12);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(832, 22);
            this.txtId.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(416, 1068);
            this.panel2.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(416, 1021);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.treeDockerImages);
            this.tabPage1.Location = new System.Drawing.Point(32, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(380, 1060);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tree";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listDockerImages);
            this.tabPage2.Location = new System.Drawing.Point(32, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(380, 1013);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Flat";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listDockerImages
            // 
            this.listDockerImages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listDockerImages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader1});
            this.listDockerImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listDockerImages.FullRowSelect = true;
            this.listDockerImages.GridLines = true;
            this.listDockerImages.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listDockerImages.HideSelection = false;
            this.listDockerImages.Location = new System.Drawing.Point(3, 3);
            this.listDockerImages.MultiSelect = false;
            this.listDockerImages.Name = "listDockerImages";
            this.listDockerImages.Size = new System.Drawing.Size(374, 1007);
            this.listDockerImages.TabIndex = 0;
            this.listDockerImages.UseCompatibleStateImageBehavior = false;
            this.listDockerImages.View = System.Windows.Forms.View.Details;
            this.listDockerImages.SelectedIndexChanged += new System.EventHandler(this.listDockerImages_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            columnHeader1.Width = 132;
            // 
            // checkHideNoRepos
            // 
            this.checkHideNoRepos.AutoSize = true;
            this.checkHideNoRepos.Checked = true;
            this.checkHideNoRepos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkHideNoRepos.Location = new System.Drawing.Point(3, 6);
            this.checkHideNoRepos.Name = "checkHideNoRepos";
            this.checkHideNoRepos.Size = new System.Drawing.Size(253, 29);
            this.checkHideNoRepos.TabIndex = 1;
            this.checkHideNoRepos.Text = "hide images with no repo";
            this.checkHideNoRepos.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.checkHideNoRepos);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 1021);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(416, 47);
            this.panel3.TabIndex = 1;
            // 
            // DockerImages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(splitter2);
            this.Controls.Add(this.panel2);
            this.Name = "DockerImages";
            this.Size = new System.Drawing.Size(1407, 1068);
            groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.TreeView treeDockerImages;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.TextBox txtSize;
      private System.Windows.Forms.TextBox txtId;
      private System.Windows.Forms.Splitter splitter1;
      private System.Windows.Forms.TextBox txtTag;
      private System.Windows.Forms.TextBox txtRepository;
      private System.Windows.Forms.ListView listContainerHistory;
      private System.Windows.Forms.LinkLabel linkParentId;
      private System.Windows.Forms.Panel panel2;
      private System.Windows.Forms.TabControl tabControl1;
      private System.Windows.Forms.TabPage tabPage1;
      private System.Windows.Forms.TabPage tabPage2;
      private System.Windows.Forms.ListView listDockerImages;
      private System.Windows.Forms.Panel panel3;
      private System.Windows.Forms.CheckBox checkHideNoRepos;
   }
}
