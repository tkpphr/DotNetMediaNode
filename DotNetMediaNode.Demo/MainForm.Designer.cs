namespace DotNetMediaNode.Demo
{
	partial class MainForm
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.SelectImageButton = new System.Windows.Forms.Button();
			this.SelectSoundButton = new System.Windows.Forms.Button();
			this.MediaNodeTreeView = new DotNetMediaNode.GUI.CustomControls.MediaNodeTreeView();
			this.StopSoundButton = new System.Windows.Forms.Button();
			this.PlaySoundButton = new System.Windows.Forms.Button();
			this.SelectNodeButton = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// SelectImageButton
			// 
			this.SelectImageButton.Location = new System.Drawing.Point(478, 103);
			this.SelectImageButton.Name = "SelectImageButton";
			this.SelectImageButton.Size = new System.Drawing.Size(129, 23);
			this.SelectImageButton.TabIndex = 17;
			this.SelectImageButton.Text = "Select Image";
			this.SelectImageButton.UseVisualStyleBackColor = true;
			this.SelectImageButton.Click += new System.EventHandler(this.SelectImageButton_Click);
			// 
			// SelectSoundButton
			// 
			this.SelectSoundButton.Location = new System.Drawing.Point(384, 356);
			this.SelectSoundButton.Name = "SelectSoundButton";
			this.SelectSoundButton.Size = new System.Drawing.Size(129, 23);
			this.SelectSoundButton.TabIndex = 16;
			this.SelectSoundButton.Text = "Select Sound";
			this.SelectSoundButton.UseVisualStyleBackColor = true;
			this.SelectSoundButton.Click += new System.EventHandler(this.SelectSoundButton_Click);
			// 
			// MediaNodeTreeView
			// 
			this.MediaNodeTreeView.HideSelection = false;
			this.MediaNodeTreeView.Location = new System.Drawing.Point(26, 12);
			this.MediaNodeTreeView.Name = "MediaNodeTreeView";
			this.MediaNodeTreeView.Size = new System.Drawing.Size(338, 367);
			this.MediaNodeTreeView.TabIndex = 15;
			// 
			// StopSoundButton
			// 
			this.StopSoundButton.Location = new System.Drawing.Point(613, 356);
			this.StopSoundButton.Name = "StopSoundButton";
			this.StopSoundButton.Size = new System.Drawing.Size(75, 23);
			this.StopSoundButton.TabIndex = 14;
			this.StopSoundButton.Text = "Stop";
			this.StopSoundButton.UseVisualStyleBackColor = true;
			this.StopSoundButton.Click += new System.EventHandler(this.StopSoundButton_Click);
			// 
			// PlaySoundButton
			// 
			this.PlaySoundButton.Location = new System.Drawing.Point(532, 356);
			this.PlaySoundButton.Name = "PlaySoundButton";
			this.PlaySoundButton.Size = new System.Drawing.Size(75, 23);
			this.PlaySoundButton.TabIndex = 13;
			this.PlaySoundButton.Text = "Play";
			this.PlaySoundButton.UseVisualStyleBackColor = true;
			this.PlaySoundButton.Click += new System.EventHandler(this.PlaySoundButton_Click);
			// 
			// SelectNodeButton
			// 
			this.SelectNodeButton.Location = new System.Drawing.Point(492, 12);
			this.SelectNodeButton.Name = "SelectNodeButton";
			this.SelectNodeButton.Size = new System.Drawing.Size(80, 23);
			this.SelectNodeButton.TabIndex = 12;
			this.SelectNodeButton.Text = "Select Node";
			this.SelectNodeButton.UseVisualStyleBackColor = true;
			this.SelectNodeButton.Click += new System.EventHandler(this.SelectNodeButton_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox1.Location = new System.Drawing.Point(429, 133);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(225, 198);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 11;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(403, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(285, 55);
			this.label1.TabIndex = 10;
			this.label1.Text = "label1";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(714, 391);
			this.Controls.Add(this.SelectImageButton);
			this.Controls.Add(this.SelectSoundButton);
			this.Controls.Add(this.MediaNodeTreeView);
			this.Controls.Add(this.StopSoundButton);
			this.Controls.Add(this.PlaySoundButton);
			this.Controls.Add(this.SelectNodeButton);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "MediaNodeDemo";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button SelectImageButton;
		private System.Windows.Forms.Button SelectSoundButton;
		private GUI.CustomControls.MediaNodeTreeView MediaNodeTreeView;
		private System.Windows.Forms.Button StopSoundButton;
		private System.Windows.Forms.Button PlaySoundButton;
		private System.Windows.Forms.Button SelectNodeButton;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
	}
}

