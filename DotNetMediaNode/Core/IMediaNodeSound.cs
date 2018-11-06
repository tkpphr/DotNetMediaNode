using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetMediaNode.Core
{
	public interface IMediaNodeSound : IDisposable
	{
		void Play();
		void Stop();
	}
}
