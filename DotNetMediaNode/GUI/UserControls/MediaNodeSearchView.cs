/*
Copyright 2018 tkpphr

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotNetMediaNode.Core;

namespace DotNetMediaNode.GUI.UserControls
{
	public partial class MediaNodeSearchView : UserControl
	{
		public event Action<IMediaNode> NodeSelected;
		private IMediaNode MediaNode { get; set; }

		public MediaNodeSearchView()
		{
			InitializeComponent();
		}

		public void SetMediaNode(IMediaNode mediaNode)
		{
			MediaNode = mediaNode.Root;
		}


		private void NodeNameTextBox_TextChanged(object sender, EventArgs e)
		{
			SearchButton.Enabled = !string.IsNullOrEmpty(NodeNameTextBox.Text);
		}

		private void NodeNameTextBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (SearchButton.Enabled && e.KeyCode == Keys.Enter)
			{
				SearchButton.PerformClick();
			}
		}

		private void SearchButton_Click(object sender, EventArgs e)
		{
			if (MediaNode==null)
			{
				return;
			}

			FoundListView.Items.Clear();
			var foundList = MediaNode.Root.FindAll(node=>node.NodeName.Contains(NodeNameTextBox.Text));
			foreach (IMediaNode foundNode in foundList)
			{
				var item = new ListViewItem(new string[] { foundNode.NodeName,foundNode.FullPath});
				FoundListView.Items.Add(item);
			}
		}

		private void FoundListView_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (FoundListView.SelectedItems.Count<=0)
			{
				return;
			}
			string path = FoundListView.SelectedItems[0].SubItems[1].Text;
			NodeSelected?.Invoke(MediaNode.Root.Find(path));
		}

		
	}
}
