using DotNetMediaNode.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace DotNetMediaNode.Demo
{
	public class MediaNodeSound : IMediaNodeSound
	{ 
		private SoundPlayer SoundPlayer { get; set; }

		public MediaNodeSound(string soundLocation)
		{
			SoundPlayer = new SoundPlayer(soundLocation);
		}

		public void Dispose()
		{
			SoundPlayer.Dispose();
		}

		public void Play()
		{
			SoundPlayer.Play();
		}

		public void Stop()
		{
			SoundPlayer.Stop();
		}

	}
}
