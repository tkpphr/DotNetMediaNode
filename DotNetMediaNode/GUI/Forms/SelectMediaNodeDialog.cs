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
using DotNetMediaNode.Core;
using System;
using System.Windows.Forms;

namespace DotNetMediaNode.GUI.Forms
{
	public partial class SelectMediaNodeDialog : Form
	{
		private IMediaNodeSound Sound { get; set; }
		private IMediaNode RootNode { get; set; }
		private Predicate<IMediaNode> Filter { get; set; }
		public IMediaNode SelectedMediaNode => MediaNodeTreeView.SelectedMediaNode;
		
		public SelectMediaNodeDialog()
		{
			InitializeComponent();
		}

		public SelectMediaNodeDialog(string title, IMediaNode selectedNode,Predicate<IMediaNode> filter)
		{
			InitializeComponent();
			RootNode = selectedNode.Root;
			MediaNodeTreeView.Reset(RootNode);
			Text = title;
			DialogResult = DialogResult.Cancel;
			Filter = filter;
			MediaNodeTreeView.SelectTreeNode(selectedNode.FullPath);
			MediaNodeSearchView.SetMediaNode(selectedNode);
			MediaNodeSearchView.NodeSelected += MediaNodeSearchView_NodeSelected;
		}

		private void SelectMediaNode(IMediaNode mediaNode)
		{
			NodeInfoView.SetMediaNode(mediaNode);
			ImagePictureBox.Image?.Dispose();
			ImagePictureBox.Image = mediaNode?.GetImage();
			Sound?.Stop();
			Sound?.Dispose();
			Sound = mediaNode?.GetSound();
			PlaySoundButton.Enabled = Sound != null;
			StopSoundButton.Enabled = Sound != null;
			SelectOKButton.Enabled = Filter(mediaNode);
		}

		private void MediaNodeTreeView_AfterSelect(object sender, TreeViewEventArgs e)
		{
			SelectMediaNode(MediaNodeTreeView.SelectedMediaNode);
		}

		private void MediaNodeSearchView_NodeSelected(IMediaNode mediaNode)
		{
			MediaNodeTreeView.SelectTreeNode(mediaNode.FullPath);
		}

		private void PlaySoundButton_Click(object sender, EventArgs e)
		{
			Sound?.Play();	
		}

		private void StopSoundButton_Click(object sender, EventArgs e)
		{
			Sound?.Stop();
		}

		private void SelectOKButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			Sound?.Stop();
			Close();
		}

		private void SelectCancelButton_Click(object sender, EventArgs e)
		{
			Sound?.Stop();
			Close();
		}

		private void SelectMediaNodeDialog_FormClosing(object sender, FormClosingEventArgs e)
		{
			ImagePictureBox.Image?.Dispose();
			Sound?.Dispose();
		}

		public static IMediaNode Show(string title, IMediaNode selectedNode, Predicate<IMediaNode> filter)
		{
			using (var dialog=new SelectMediaNodeDialog(title,selectedNode,filter))
			{
				if(dialog.ShowDialog()==DialogResult.OK)
				{
					return dialog.SelectedMediaNode;
				}
				else
				{
					return null;
				}
			}
		}

		public static IMediaNode Show(string title, IMediaNode selectedNode)
		{
			return Show(title, selectedNode, node => true);
		}
	}
}
