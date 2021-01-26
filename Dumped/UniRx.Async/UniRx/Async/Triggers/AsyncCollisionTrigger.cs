﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UniRx.Async;
using UnityEngine;

// Image 50: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent]
	public class AsyncCollisionTrigger : AsyncTriggerBase
	{
		// Fields
		private AsyncTriggerPromise<Collision> onCollisionEnter;
		private AsyncTriggerPromiseDictionary<Collision> onCollisionEnters;
		private AsyncTriggerPromise<Collision> onCollisionExit;
		private AsyncTriggerPromiseDictionary<Collision> onCollisionExits;
		private AsyncTriggerPromise<Collision> onCollisionStay;
		private AsyncTriggerPromiseDictionary<Collision> onCollisionStays;
	
		// Constructors
		public AsyncCollisionTrigger();
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises();
		private void OnCollisionEnter(Collision collision);
		public UniTask<Collision> OnCollisionEnterAsync(CancellationToken cancellationToken = default);
		private void OnCollisionExit(Collision collisionInfo);
		public UniTask<Collision> OnCollisionExitAsync(CancellationToken cancellationToken = default);
		private void OnCollisionStay(Collision collisionInfo);
		public UniTask<Collision> OnCollisionStayAsync(CancellationToken cancellationToken = default);
	}
}