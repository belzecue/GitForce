﻿namespace GitForce
{
    partial class FormSettings
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("User");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Commits");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Gitignore");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Status");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("GitForce Objects", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("View / Edit");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Diff");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Merge");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Double Click");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Files", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Aliases");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Specifications");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("SSL");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Options", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12,
            treeNode13});
            this.panel = new System.Windows.Forms.Panel();
            this.btOK = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btApply = new System.Windows.Forms.Button();
            this.treeSections = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.Location = new System.Drawing.Point(176, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(321, 249);
            this.panel.TabIndex = 9;
            // 
            // btOK
            // 
            this.btOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOK.Location = new System.Drawing.Point(341, 267);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 7;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.BtOkClick);
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(422, 267);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 8;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btApply
            // 
            this.btApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btApply.Location = new System.Drawing.Point(260, 267);
            this.btApply.Name = "btApply";
            this.btApply.Size = new System.Drawing.Size(75, 23);
            this.btApply.TabIndex = 6;
            this.btApply.Text = "Apply";
            this.btApply.UseVisualStyleBackColor = true;
            this.btApply.Click += new System.EventHandler(this.BtApplyClick);
            // 
            // treeSections
            // 
            this.treeSections.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.treeSections.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeSections.HideSelection = false;
            this.treeSections.Location = new System.Drawing.Point(12, 12);
            this.treeSections.Name = "treeSections";
            treeNode1.Name = "Node3";
            treeNode1.Tag = "User";
            treeNode1.Text = "User";
            treeNode2.Name = "Node0";
            treeNode2.Tag = "Commits";
            treeNode2.Text = "Commits";
            treeNode3.Name = "Node0";
            treeNode3.Tag = "Gitignore";
            treeNode3.Text = "Gitignore";
            treeNode4.Name = "Node0";
            treeNode4.Tag = "Status";
            treeNode4.Text = "Status";
            treeNode5.Name = "Node0";
            treeNode5.Text = "GitForce Objects";
            treeNode6.Name = "Node4";
            treeNode6.Tag = "ViewEdit";
            treeNode6.Text = "View / Edit";
            treeNode7.Name = "Node5";
            treeNode7.Tag = "Diff";
            treeNode7.Text = "Diff";
            treeNode8.Name = "Node6";
            treeNode8.Tag = "Merge";
            treeNode8.Text = "Merge";
            treeNode9.Name = "Node0";
            treeNode9.Tag = "DoubleClick";
            treeNode9.Text = "Double Click";
            treeNode10.Name = "Node1";
            treeNode10.Tag = "Files";
            treeNode10.Text = "Files";
            treeNode11.Name = "Node7";
            treeNode11.Tag = "Aliases";
            treeNode11.Text = "Aliases";
            treeNode12.Name = "Node0";
            treeNode12.Tag = "Specifications";
            treeNode12.Text = "Specifications";
            treeNode13.Name = "Node0";
            treeNode13.Tag = "Ssl";
            treeNode13.Text = "SSL";
            treeNode14.Name = "Node2";
            treeNode14.Text = "Options";
            this.treeSections.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode10,
            treeNode14});
            this.treeSections.Size = new System.Drawing.Size(158, 278);
            this.treeSections.TabIndex = 5;
            this.treeSections.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeSectionsAfterSelect);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 302);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btApply);
            this.Controls.Add(this.treeSections);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(525, 271);
            this.Name = "FormSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "GitForce Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSettingsFormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btApply;
        private System.Windows.Forms.TreeView treeSections;
    }
}