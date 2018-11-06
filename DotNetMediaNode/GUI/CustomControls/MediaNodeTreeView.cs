using DotNetMediaNode.Core;
using System;
using System.Windows.Forms;

namespace DotNetMediaNode.GUI.CustomControls
{
	public class MediaNodeTreeView : TreeView
	{
		private IMediaNode RootNode { get; set; }
		public IMediaNode SelectedMediaNode => SelectedNode==null ? null : RootNode.Find(SelectedNode.FullPath);
		public event Action<IMediaNode> BeforeNodeSelect;
		public event Action<IMediaNode> AfterNodeSelect;

        public MediaNodeTreeView()
            : base()
        {
            HideSelection = false;
			BeforeSelect += MediaNodeTreeView_BeforeSelect;
            AfterSelect += MediaNodeTreeView_AfterSelect;
        }

		public void SelectTreeNode(string path)
        {
            TreeNode treeNode=FindTreeNodeRecursive(Nodes,path);
            if(treeNode==null)
            {
                SelectedNode = Nodes[0];
            }
            else
            {
                SelectedNode = treeNode;
            }
            
        }

        public void Reset(IMediaNode rootNode)
        {
            RootNode = rootNode;
            Nodes.Clear();
            Nodes.Add(CreateTreeViewNode(rootNode));
            SelectedNode = Nodes[0];
            SelectedNode.ExpandAll();
        }

		public void RefreshNodes()
		{
			BeforeSelect -= MediaNodeTreeView_BeforeSelect;
			AfterSelect -= MediaNodeTreeView_AfterSelect;
			var selectedNode = SelectedMediaNode;
			Reset(RootNode);
			ExpandAll();
			AfterSelect += MediaNodeTreeView_AfterSelect;
			BeforeSelect += MediaNodeTreeView_BeforeSelect;
		}

		public TreeNode FindTreeNode(string path)
        {
            if (Nodes.Count == 0)
            {
                return null;
            }
            return FindTreeNodeRecursive(Nodes, path);
        }

        private TreeNode FindTreeNodeRecursive(TreeNodeCollection parent, string path)
        {
            if (parent.Count > 0)
            {
                foreach (TreeNode node in parent)
                {
                    if (path.StartsWith(node.FullPath))
                    {
                        if (path == node.FullPath)
                        {
                            return node;
                        }
                        else
                        {
                            TreeNode result = FindTreeNodeRecursive(node.Nodes, path);
                            if (result != null)
                            {
                                return result;
                            }
                        }
                    }
                }
                return null;
            }
            else
            {
                return null;
            }
        }

        private TreeNode CreateTreeViewNode(IMediaNode newNode)
        {
            TreeNode treeNode = new TreeNode(newNode.NodeName);
            treeNode.Name = newNode.NodeName;
            if (newNode.ChildCount > 0)
            {
                foreach (IMediaNode node in newNode.Children)
                {
                    treeNode.Nodes.Add(CreateTreeViewNode(node));
                }
            }
            return treeNode;
        }

		private void MediaNodeTreeView_BeforeSelect(object sender, TreeViewCancelEventArgs e)
		{
			BeforeNodeSelect?.Invoke(SelectedMediaNode);
		}

		private void MediaNodeTreeView_AfterSelect(object sender,TreeViewEventArgs e)
        {
			AfterNodeSelect?.Invoke(SelectedMediaNode);
        }
    }
}
