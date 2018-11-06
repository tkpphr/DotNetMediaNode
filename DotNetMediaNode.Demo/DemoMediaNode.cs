using DotNetMediaNode.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Media;

namespace DotNetMediaNode.Demo
{
	public class DemoMediaNode : MediaNode<DemoMediaNode>
	{
		public DemoMediaNode(DemoMediaNode parent,string nodeName)
			:base(parent,nodeName)
		{
			ImagePath = parent.ImagePath;
		}

		public DemoMediaNode(DemoMediaNode parent, string fullPath, string imagePath, string soundPath) : base(fullPath,parent)
		{
			ImagePath = imagePath;
			SoundPath = soundPath;
		}

		public override Image GetImage()
		{
			string imagePath = ImagePath;
			if (string.IsNullOrEmpty(imagePath))
			{
				return null;
			}

			if (File.Exists(imagePath))
			{
				return Image.FromFile(imagePath);
			}
			else
			{
				return null;
			}
		}

		public override IMediaNodeSound GetSound()
		{
			string soundPath = SoundPath;
			if (string.IsNullOrEmpty(soundPath))
			{
				return null;
			}

			if (File.Exists(soundPath))
			{
				return new MediaNodeSound(soundPath);
			}
			else
			{
				return null;
			}
		}

	}
}
