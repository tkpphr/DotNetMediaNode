namespace DotNetMediaNode.GUI.Forms
{
	partial class SelectMediaNodeDialog
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectMediaNodeDialog));
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.MediaNodeTreeView = new DotNetMediaNode.GUI.CustomControls.MediaNodeTreeView();
			this.MediaNodeSearchView = new DotNetMediaNode.GUI.UserControls.MediaNodeSearchView();
			this.StopSoundButton = new System.Windows.Forms.Button();
			this.ImagePictureBox = new System.Windows.Forms.PictureBox();
			this.PlaySoundButton = new System.Windows.Forms.Button();
			this.SelectCancelButton = new System.Windows.Forms.Button();
			this.SelectOKButton = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.NodeInfoView = new DotNetMediaNode.GUI.UserControls.NodeInfoView();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			resources.ApplyResources(this.splitContainer1, "splitContainer1");
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.MediaNodeTreeView);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.MediaNodeSearchView);
			// 
			// MediaNodeTreeView
			// 
			this.MediaNodeTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			resources.ApplyResources(this.MediaNodeTreeView, "MediaNodeTreeView");
			this.MediaNodeTreeView.HideSelection = false;
			this.MediaNodeTreeView.Name = "MediaNodeTreeView";
			this.MediaNodeTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.MediaNodeTreeView_AfterSelect);
			// 
			// MediaNodeSearchView
			// 
			resources.ApplyResources(this.MediaNodeSearchView, "MediaNodeSearchView");
			this.MediaNodeSearchView.Name = "MediaNodeSearchView";
			// 
			// StopSoundButton
			// 
			resources.ApplyResources(this.StopSoundButton, "StopSoundButton");
			this.StopSoundButton.Cursor = System.Windows.Forms.Cursors.Default;
			this.StopSoundButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.StopSoundButton.FlatAppearance.BorderSize = 0;
			this.StopSoundButton.Name = "StopSoundButton";
			this.StopSoundButton.UseVisualStyleBackColor = true;
			this.StopSoundButton.Click += new System.EventHandler(this.StopSoundButton_Click);
			// 
			// ImagePictureBox
			// 
			resources.ApplyResources(this.ImagePictureBox, "ImagePictureBox");
			this.ImagePictureBox.BackColor = System.Drawing.SystemColors.Window;
			this.ImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ImagePictureBox.Name = "ImagePictureBox";
			this.ImagePictureBox.TabStop = false;
			// 
			// PlaySoundButton
			// 
			resources.ApplyResources(this.PlaySoundButton, "PlaySoundButton");
			this.PlaySoundButton.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.PlaySoundButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.PlaySoundButton.FlatAppearance.BorderSize = 0;
			this.PlaySoundButton.Name = "PlaySoundButton";
			this.PlaySoundButton.UseVisualStyleBackColor = true;
			this.PlaySoundButton.Click += new System.EventHandler(this.PlaySoundButton_Click);
			// 
			// SelectCancelButton
			// 
			resources.ApplyResources(this.SelectCancelButton, "SelectCancelButton");
			this.SelectCancelButton.Name = "SelectCancelButton";
			this.SelectCancelButton.UseVisualStyleBackColor = true;
			this.SelectCancelButton.Click += new System.EventHandler(this.SelectCancelButton_Click);
			// 
			// SelectOKButton
			// 
			resources.ApplyResources(this.SelectOKButton, "SelectOKButton");
			this.SelectOKButton.Name = "SelectOKButton";
			this.SelectOKButton.UseVisualStyleBackColor = true;
			this.SelectOKButton.Click += new System.EventHandler(this.SelectOKButton_Click);
			// 
			// tableLayoutPanel1
			// 
			resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
			this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.SelectOKButton, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.SelectCancelButton, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			// 
			// tableLayoutPanel2
			// 
			resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.NodeInfoView, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.ImagePictureBox, 0, 1);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			// 
			// tableLayoutPanel3
			// 
			resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
			this.tableLayoutPanel3.Controls.Add(this.PlaySoundButton, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.StopSoundButton, 1, 0);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			// 
			// NodeInfoView
			// 
			resources.ApplyResources(this.NodeInfoView, "NodeInfoView");
			this.NodeInfoView.Name = "NodeInfoView";
			// 
			// SelectMediaNodeDialog
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ControlBox = false;
			this.Controls.Add(this.tableLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "SelectMediaNodeDialog";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private DotNetMediaNode.GUI.CustomControls.MediaNodeTreeView MediaNodeTreeView;
        private System.Windows.Forms.Button StopSoundButton;
        private System.Windows.Forms.PictureBox ImagePictureBox;
        private System.Windows.Forms.Button PlaySoundButton;
        private System.Windows.Forms.Button SelectCancelButton;
		private UserControls.NodeInfoView NodeInfoView;
		private System.Windows.Forms.Button SelectOKButton;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private UserControls.MediaNodeSearchView MediaNodeSearchView;
	}
}