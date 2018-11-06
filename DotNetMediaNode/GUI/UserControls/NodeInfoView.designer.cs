namespace DotNetMediaNode.GUI.UserControls
{
	partial class NodeInfoView
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

		#region コンポーネント デザイナーで生成されたコード

		/// <summary> 
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.Panel = new System.Windows.Forms.Panel();
			this.NodeInfoLabel = new System.Windows.Forms.Label();
			this.Panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// Panel
			// 
			this.Panel.AutoScroll = true;
			this.Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel.Controls.Add(this.NodeInfoLabel);
			this.Panel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Panel.Location = new System.Drawing.Point(0, 0);
			this.Panel.Name = "Panel";
			this.Panel.Size = new System.Drawing.Size(520, 91);
			this.Panel.TabIndex = 0;
			// 
			// NodeInfoLabel
			// 
			this.NodeInfoLabel.AutoSize = true;
			this.NodeInfoLabel.Location = new System.Drawing.Point(3, 0);
			this.NodeInfoLabel.Name = "NodeInfoLabel";
			this.NodeInfoLabel.Size = new System.Drawing.Size(32, 12);
			this.NodeInfoLabel.TabIndex = 0;
			this.NodeInfoLabel.Text = "Label";
			// 
			// NodeInfoView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.Panel);
			this.Name = "NodeInfoView";
			this.Size = new System.Drawing.Size(520, 91);
			this.Panel.ResumeLayout(false);
			this.Panel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel Panel;
		private System.Windows.Forms.Label NodeInfoLabel;
	}
}
