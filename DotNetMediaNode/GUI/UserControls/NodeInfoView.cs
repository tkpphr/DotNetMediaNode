using DotNetMediaNode.Core;
using System.Windows.Forms;

namespace DotNetMediaNode.GUI.UserControls
{
	public partial class NodeInfoView : UserControl
	{
		private IMediaNode MediaNode { get; set; }

		public NodeInfoView()
		{
			InitializeComponent();
		}

		public void SetMediaNode(IMediaNode mediaNode)
		{
			MediaNode = mediaNode;
			NodeInfoLabel.Text = mediaNode?.NodeInfo;
		}
	}
}
