using DotNetMediaNode.Core;
using DotNetMediaNode.GUI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetMediaNode.Demo
{
	public partial class MainForm : Form
	{
		private DemoMediaNode SampleMediaNode { get; set; }
		private IMediaNodeSound Sound { get; set; }

		public MainForm()
		{
			InitializeComponent();
			MediaNodeTreeView.AfterNodeSelect += MediaNodeTreeView_AfterNodeSelect;
			SampleMediaNode = CreateTree();
			MediaNodeTreeView.Reset(SampleMediaNode);
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			Reset();
		}

		private DemoMediaNode CreateTree()
		{
			string assetsPath = "..\\..\\.\\Assets\\";
			DemoMediaNode root = new DemoMediaNode(null, "root", assetsPath + "parent_root.png", assetsPath + "sound_1.wav");
			root.AddChild(new DemoMediaNode(root, root.FullPath + "\\\\child1", assetsPath + "child_1.png", assetsPath + "sound_2.wav"));
			root.AddChild(new DemoMediaNode(root, root.FullPath + "\\\\child2", assetsPath + "child_2.png", assetsPath + "sound_1.wav"));
			root.AddChild(new DemoMediaNode(root, root.FullPath + "\\\\child3", assetsPath + "child_3.png", assetsPath + "sound_3.wav"));
			root.AddChild(new DemoMediaNode(root, root.FullPath + "\\\\child4", assetsPath + "child_4.png", assetsPath + "sound_1.wav"));
			DemoMediaNode child1 = root.GetChild(0);
			child1.AddChild(new DemoMediaNode(child1, child1.FullPath + "\\\\grandchild1", assetsPath + "grand_child_1.png", assetsPath + "sound_1.wav"));
			child1.AddChild(new DemoMediaNode(child1, child1.FullPath + "\\\\grandchild2", assetsPath + "grand_child_2.png", assetsPath + "sound_3.wav"));
			DemoMediaNode child2 = root.GetChild(1);
			child2.AddChild(new DemoMediaNode(child2, child2.FullPath + "\\\\grandchild3", assetsPath + "grand_child_3.png", assetsPath + "sound_2.wav"));
			return root;
		}

		private void Reset()
		{
			if (SampleMediaNode != null)
			{
				label1.Text = SampleMediaNode.NodeInfo;
				pictureBox1.Image = SampleMediaNode.GetImage();
				Sound?.Stop();
				Sound?.Dispose();
				Sound = SampleMediaNode.GetSound();
				PlaySoundButton.Enabled = Sound != null;
				StopSoundButton.Enabled = Sound != null;
			}
		}

		private void SelectImageButton_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog dialog = new OpenFileDialog())
			{
				dialog.InitialDirectory = @"";
				dialog.Title = "Open Image";
				dialog.Filter = "Image File (*.jpg,*.jpeg,*.png,*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|All Files(*.*)|*.*";
				dialog.FilterIndex = 1;
				dialog.RestoreDirectory = true;
				string imagePath = dialog.ShowDialog() == DialogResult.OK ? dialog.FileName : "";
				if (!string.IsNullOrEmpty(imagePath))
				{
					SampleMediaNode.ImagePath = imagePath;
					Reset();
				}
			}
			
		}

		private void SelectSoundButton_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog dialog = new OpenFileDialog())
			{
				dialog.InitialDirectory = @"";
				dialog.Title = "Open Sound";
				dialog.Filter = "Sound File (*.wav)|*.wav;|All Files(*.*)|*.*";
				dialog.FilterIndex = 1;
				dialog.RestoreDirectory = true;
				string soundPath = dialog.ShowDialog() == DialogResult.OK ? dialog.FileName : "";
				if (!string.IsNullOrEmpty(soundPath))
				{
					SampleMediaNode.SoundPath = soundPath;
					Reset();
				}
			}
		}

		private void PlaySoundButton_Click(object sender, EventArgs e)
		{
			Sound?.Play();
		}

		private void StopSoundButton_Click(object sender, EventArgs e)
		{
			Sound?.Stop();
		}

		private void MediaNodeTreeView_AfterNodeSelect(IMediaNode obj)
		{
			SampleMediaNode = obj as DemoMediaNode;
			Reset();
		}

		private void SelectNodeButton_Click(object sender, EventArgs e)
		{
			var selectedNode = SelectMediaNodeDialog.Show("Select Node", MediaNodeTreeView.SelectedMediaNode);
			if (selectedNode != null)
			{
				MediaNodeTreeView.SelectTreeNode(selectedNode.FullPath);
			}
		}
	}
}
