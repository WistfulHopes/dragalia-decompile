﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.ActionData
{
	[Serializable]
	public class EALinkedEnemyBuffData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private bool _onoff;
		[HideInInspector]
		[SerializeField]
		private int[] _linkedId;
		[HideInInspector]
		[SerializeField]
		private bool _guarantee;
	
		// Properties
		public bool onoff { get; }
		public int[] linkedId { get; }
		public bool guarantee { get; }
	
		// Constructors
		public EALinkedEnemyBuffData();
	}
}
