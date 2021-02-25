﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.ActionData;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ActionPartsSendSignal : ActionParts
	{
		// Fields
		private readonly SendSignalData _partsData;
		private bool _isStarted;
		private bool _isForceEnd;
	
		// Constructors
		public ActionPartsSendSignal(ActionParts resource);
	
		// Methods
		public override void Clear();
		public override int[] GetActionIdsForLoad();
		protected override void OnStart();
		protected override bool OnUpdate(float delta);
		private void SendSignal(bool on, bool isActionEnd = false);
		public bool IsOnlyGuardCounter();
	}
}
