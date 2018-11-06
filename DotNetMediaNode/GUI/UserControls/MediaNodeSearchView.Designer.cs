namespace DotNetMediaNode.GUI.UserControls
{
	partial class MediaNodeSearchView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaNodeSearchView));
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.NodeNameTextBox = new System.Windows.Forms.TextBox();
			this.NodeNameLabel = new System.Windows.Forms.Label();
			this.SearchButton = new System.Windows.Forms.Button();
			this.FoundListView = new System.Windows.Forms.ListView();
			this.NameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.PathColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.FoundListView, 0, 1);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			// 
			// tableLayoutPanel2
			// 
			resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
			this.tableLayoutPanel2.Controls.Add(this.NodeNameTextBox, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.NodeNameLabel, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.SearchButton, 2, 0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			// 
			// NodeNameTextBox
			// 
			resources.ApplyResources(this.NodeNameTextBox, "NodeNameTextBox");
			this.NodeNameTextBox.Name = "NodeNameTextBox";
			this.NodeNameTextBox.TextChanged += new System.EventHandler(this.NodeNameTextBox_TextChanged);
			this.NodeNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NodeNameTextBox_KeyDown);
			// 
			// NodeNameLabel
			// 
			resources.ApplyResources(this.NodeNameLabel, "NodeNameLabel");
			this.NodeNameLabel.Name = "NodeNameLabel";
			// 
			// SearchButton
			// 
			resources.ApplyResources(this.SearchButton, "SearchButton");
			this.SearchButton.Name = "SearchButton";
			this.SearchButton.UseVisualStyleBackColor = true;
			this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
			// 
			// FoundListView
			// 
			resources.ApplyResources(this.FoundListView, "FoundListView");
			this.FoundListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameColumnHeader,
            this.PathColumnHeader});
			this.FoundListView.FullRowSelect = true;
			this.FoundListView.MultiSelect = false;
			this.FoundListView.Name = "FoundListView";
			this.FoundListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.FoundListView.UseCompatibleStateImageBehavior = false;
			this.FoundListView.View = System.Windows.Forms.View.Details;
			this.FoundListView.SelectedIndexChanged += new System.EventHandler(this.FoundListView_SelectedIndexChanged);
			// 
			// NameColumnHeader
			// 
			resources.ApplyResources(this.NameColumnHeader, "NameColumnHeader");
			// 
			// PathColumnHeader
			// 
			resources.ApplyResources(this.PathColumnHeader, "PathColumnHeader");
			// 
			// MediaNodeSearchView
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "MediaNodeSearchView";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.TextBox NodeNameTextBox;
		private System.Windows.Forms.Label NodeNameLabel;
		private System.Windows.Forms.Button SearchButton;
		private System.Windows.Forms.ListView FoundListView;
		private System.Windows.Forms.ColumnHeader NameColumnHeader;
		private System.Windows.Forms.ColumnHeader PathColumnHeader;
	}
}
