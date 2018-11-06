using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;

namespace DotNetMediaNode.Core
{

	public interface IMediaNode<T> where T:IMediaNode<T>
    {
		T Parent { get; }
		T Root { get; }
		T FirstChild { get; }
		T LastChild { get; }
		IEnumerable<T> Children { get; }

		T GetChild(int index);
		void AddChild(T node);
		T Find(string path);
		List<T> FindAll(Predicate<T> filter);
		int IndexOf(T node);
		void InsertChild(int index, T node);
		void RemoveChild(T node);
		void RemoveChild(int index);
	}

	public interface IMediaNode
	{
		string ImagePath { get; set; }
		string SoundPath { get; set; }
		string NodeInfo { get; }
		Image GetImage();
		IMediaNodeSound GetSound();

		string NodeName { get; set; }
		string FullPath { get; }
		IMediaNode Root { get; }
		IMediaNode Parent { get; }
		int ChildCount { get; }
		IMediaNode FirstChild { get; }
		IMediaNode LastChild { get; }
		IEnumerable<IMediaNode> Children { get; }

		IMediaNode Find(string path);
		List<IMediaNode> FindAll(Predicate<IMediaNode> filter);
		IMediaNode GetChild(int index);
		void AddChild(IMediaNode node);
		void ClearChildren();
		void InsertChild(int index, IMediaNode node);
		void RemoveChild(int index);
		void RemoveChild(IMediaNode node);
		int IndexOf(IMediaNode node);

	}

}
