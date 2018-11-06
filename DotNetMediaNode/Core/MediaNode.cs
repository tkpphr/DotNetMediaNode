using DotNetMediaNode.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace DotNetMediaNode.Core
{
	public abstract class MediaNode<T> : IMediaNode<T>,IMediaNode where T : MediaNode<T>
	{
		private string _NodeName;
		private T _Parent;
		private List<T> _Children;
		
		public string FullPath => CreateFullPath(Parent, NodeName);
		public T Parent => _Parent;
		public int ChildCount => _Children.Count;
		public T Root => _Parent == null ? this as T : _Parent.Root;
		public T FirstChild => _Children[0];
		public T LastChild => _Children[ChildCount - 1];
		public IEnumerable<T> Children => _Children.AsEnumerable();
		public virtual string NodeName { get => _NodeName; set => _NodeName = value; }
		public virtual string ImagePath { get; set; }
		public virtual string SoundPath { get; set; }
		public virtual string NodeInfo => FullPathInfo + "\n" + ImagePathInfo + "\n" + SoundPathInfo;
		protected virtual string FullPathInfo => Resources.Path + " : " + FullPath;
		protected virtual string ImagePathInfo
		{
			get {
				string imagePath = ImagePath;
				if (string.IsNullOrEmpty(imagePath) || FullPath == imagePath)
				{
					imagePath = Resources.None;
				}
				return Resources.Image + " : " + imagePath;
			}
		}
		protected virtual string SoundPathInfo
		{
			get {
				string soundPath = SoundPath;
				if (string.IsNullOrEmpty(soundPath) || FullPath==soundPath)
				{
					soundPath = Resources.None;
				}
				return Resources.Sound + " : " + soundPath;
			}
		}
		string IMediaNode.ImagePath { get => ImagePath; set => ImagePath = value; }
		string IMediaNode.SoundPath { get => SoundPath; set => SoundPath = value; }
		string IMediaNode.NodeInfo => NodeInfo;
		IMediaNode IMediaNode.Parent => Parent;
		IMediaNode IMediaNode.Root => Root;
		IMediaNode IMediaNode.FirstChild => FirstChild;
		IMediaNode IMediaNode.LastChild => LastChild;
		IEnumerable<IMediaNode> IMediaNode.Children => Children;
		string IMediaNode.NodeName { get => NodeName; set => NodeName = value; }
		string IMediaNode.FullPath => FullPath;
		int IMediaNode.ChildCount => ChildCount;

		public MediaNode(string nodeName)
		{
			_NodeName = nodeName;
			_Parent = null;
			_Children = new List<T>();
		}

		public MediaNode(IMediaNode parent, string nodeName)
		{
			_NodeName = nodeName;
			_Parent = parent as T;
			_Children = new List<T>();
		}

		public MediaNode(string fullPath, IMediaNode parent)
		{
			string[] nodeName = fullPath.Split('\\');
			_NodeName = nodeName[nodeName.Length - 1];
			_Parent = parent as T;
			_Children = new List<T>();
		}

		public abstract Image GetImage();
		public abstract IMediaNodeSound GetSound();

		public T Find(string path)
		{
			if (FullPath == path)
			{
				return this as T;
			}
			else
			{
				foreach (T node in _Children)
				{
					if (path.StartsWith(node.FullPath))
					{
						if (path == node.FullPath)
						{
							return node;
						}
						else
						{
							T result = null;
							result = node.Find(path);
							if (result != null)
							{
								return result;
							}
						}
					}
				}
				return null;
			}
		}

		public List<T> FindAll(Predicate<T> filter)
		{
			var foundList = new List<T>();
			FindAllRecursive(this as T, foundList, filter);
			return foundList;
		}

		public T GetChild(int index)
		{
			return _Children[index];
		}

		public virtual void AddChild(T node)
		{
			_Children.Add(node);
		}

		public virtual void InsertChild(int index, T node)
		{
			_Children.Insert(index, node);
		}

		public virtual void RemoveChild(T node)
		{
			_Children.Remove(node);
		}

		public virtual void RemoveChild(int index)
		{
			_Children.RemoveAt(index);
		}

		public virtual void ClearChildren()
		{
			_Children.Clear();
		}

		public int IndexOf(T node)
		{
			return _Children.IndexOf(node);
		}

		private string CreateFullPath(T parent, string path)
		{
			if (parent == null)
			{
				return path;
			}
			else
			{
				return CreateFullPath(parent.Parent, parent.NodeName + "\\" + path);
			}
		}

		private void FindAllRecursive(T parent, List<T> foundList, Predicate<T> filter)
		{
			if (filter(parent as T))
			{
				foundList.Add(parent as T);
			}
			foreach (T child in parent.Children)
			{
				child.FindAllRecursive(child, foundList, filter);
			}
		}

		IMediaNode IMediaNode.Find(string path)
		{
			return Find(path);
		}

		List<IMediaNode> IMediaNode.FindAll(Predicate<IMediaNode> filter)
		{
			return FindAll(filter).Cast<IMediaNode>().ToList();
		}

		IMediaNode IMediaNode.GetChild(int index)
		{
			return GetChild(index);
		}

		void IMediaNode.AddChild(IMediaNode node)
		{
			AddChild(node as T);
		}

		void IMediaNode.ClearChildren()
		{
			ClearChildren();
		}

		void IMediaNode.InsertChild(int index, IMediaNode node)
		{
			InsertChild(index,node as T);
		}

		void IMediaNode.RemoveChild(int index)
		{
			RemoveChild(index);
		}

		void IMediaNode.RemoveChild(IMediaNode node)
		{
			RemoveChild(node as T);
		}

		int IMediaNode.IndexOf(IMediaNode node)
		{
			return IndexOf(node as T);
		}
	}
}
