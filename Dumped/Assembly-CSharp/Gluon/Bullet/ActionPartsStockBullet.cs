﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.ActionData;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Bullet
{
	public class ActionPartsStockBullet : ActionPartsBullet
	{
		// Fields
		private readonly StockBulletData _partsData;
	
		// Constructors
		public ActionPartsStockBullet(Gluon.ActionData.ActionParts resource);
	
		// Methods
		protected override void OnStart();
		public override void Initialize(CharacterBase chara);
		protected override void Fire();
		public override int[] GetActionIdsForLoad();
	}
}