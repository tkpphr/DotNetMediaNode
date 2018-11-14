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
