﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Gluon.Http;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthManaCircleScene : SceneBase
	{
		// Fields
		public Camera mainCamera;
		public Camera uiCamera;
		public GrowthManaCircleCameraController cameraController;
		public GrowthManaCircleEffectController effectController;
		public GrowthManaCircleObjectsController objectsController;
		public GrowthManaCircleObjectSettings objectSettings;
		public GrowthManaCircleEffectSettings effectSettings;
		public GrowthManaCircleCameraSettings cameraSettings;
		public GrowthManaCircleSoundController soundController;
		public GrowthManaCircleUICanvas mainCanvas;
		public GrowthManaCircleModel model;
		public float idleTime;
		public bool isMenuOpened;
		private List<GrowthManaCircleManaPieceObject> selectedTouchPointList;
		protected GrowthManaCircleStatusCanvas statusCanvas;
		protected GrowthManaCircleManaPieceDescriptionCanvas pointDescCanvas;
		private int lastTouchPointIndex;
		private GrowthAwakeResultPop.BeforeData beforeUsePlatinumCrystalData;
		private bool isGoingSecondCircle;
		public const string prefabDir = "Prefabs/OutGame/Growth/GrowthManaCircle/";
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action __9__20_0;
			public static Func<GrowthManaCircleManaPieceData, bool> __9__43_0;
			public static Func<GrowthManaCircleManaPieceData, int> __9__43_1;
			public static Func<GrowthManaCircleManaPieceData, int> __9__43_2;
			public static Action __9__49_0;
			public static Action __9__51_2;
			public static Action __9__53_3;
			public static Action __9__55_0;
			public static Action __9__60_0;
			public static Action __9__61_0;
			public static Action __9__70_1;
			public static TweenCallback __9__70_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _Start_b__20_0();
			internal bool _UsePlatinumCrystalResultAction_b__43_0(GrowthManaCircleManaPieceData p);
			internal int _UsePlatinumCrystalResultAction_b__43_1(GrowthManaCircleManaPieceData p);
			internal int _UsePlatinumCrystalResultAction_b__43_2(GrowthManaCircleManaPieceData p);
			internal void _GoManaCircleBlankScene_b__49_0();
			internal void _CreateCharaStoryPopup_b__51_2();
			internal void _CreateAllReleasedRewardPopup_b__53_3();
			internal void _OnBackButtonPressed_b__55_0();
			internal void _OnGrowthButtonPressed_b__60_0();
			internal void _OnAwakeningButtonPressed_b__61_0();
			internal void _ShowTutorialPointer_b__70_0();
			internal void _ShowTutorialPointer_b__70_1();
		}
	
		[CompilerGenerated]
		private sealed class _Start_d__20 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthManaCircleScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__20(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _WaitPrevSceneExit_d__21 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthManaCircleScene __4__this;
			private int _i_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitPrevSceneExit_d__21(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass30_0
		{
			// Fields
			public CommonPopup popup;
			public GrowthManaCircleScene __4__this;
			public GrowthManaCircleManaPieceObject touchedPoint;
			public bool isGrowRelease;
	
			// Constructors
			public __c__DisplayClass30_0();
	
			// Methods
			internal void _OnTouchPointClicked_b__0();
			internal void _OnTouchPointClicked_b__1();
			internal void _OnTouchPointClicked_b__2();
			internal void _OnTouchPointClicked_b__3();
			internal void _OnTouchPointClicked_b__4();
			internal void _OnTouchPointClicked_b__5();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass30_1
		{
			// Fields
			public GrowthManaCircleReleaseDonePopup releaseDonePopup;
	
			// Constructors
			public __c__DisplayClass30_1();
	
			// Methods
			internal void _OnTouchPointClicked_b__6();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass33_0
		{
			// Fields
			public CommonPopup maxPopup;
	
			// Constructors
			public __c__DisplayClass33_0();
	
			// Methods
			internal void _OnAutotButtonPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass33_1
		{
			// Fields
			public CommonPopup needReleasePopup;
	
			// Constructors
			public __c__DisplayClass33_1();
	
			// Methods
			internal void _OnAutotButtonPressed_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass37_0
		{
			// Fields
			public GrowthManaCircleAutoReleasePopup popup;
			public AutoReleasableAllCirclePointData autoReleasableData;
			public GrowthManaCircleScene __4__this;
			public bool isGrowMaterial;
			public Action<AutoReleasableAllCirclePointData> __9__5;
	
			// Constructors
			public __c__DisplayClass37_0();
	
			// Methods
			internal void _AutoReleaseCommonAction_b__0();
			internal void _AutoReleaseCommonAction_b__1();
			internal void _AutoReleaseCommonAction_b__5(AutoReleasableAllCirclePointData data);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass37_1
		{
			// Fields
			public CommonPopup noReleasePopup;
	
			// Constructors
			public __c__DisplayClass37_1();
	
			// Methods
			internal void _AutoReleaseCommonAction_b__2();
			internal void _AutoReleaseCommonAction_b__3();
			internal void _AutoReleaseCommonAction_b__4();
		}
	
		[CompilerGenerated]
		private struct _SendAutoReleaseBuildupAndLimitBreakData_d__41 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public GrowthManaCircleScene __4__this;
			public AutoReleasableAllCirclePointData autoReleasableData;
			public bool isGrowMaterial;
			public Action<AutoReleasableAllCirclePointData> sendCompleteCallBack;
			private TaskAwaiter<CharaLimitBreakAndBuildupManaResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass46_0
		{
			// Fields
			public GrowthManaCircleScene __4__this;
			public int circleIndex;
	
			// Constructors
			public __c__DisplayClass46_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass46_1
		{
			// Fields
			public CommonPopup popup;
			public __c__DisplayClass46_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass46_1();
	
			// Methods
			internal void _OnReleaseMotifClicked_b__0();
			internal void _OnReleaseMotifClicked_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass46_2
		{
			// Fields
			public GrowthManaCircleLimitReleasePopup popup;
			public __c__DisplayClass46_0 CS___8__locals2;
	
			// Nested types
			private struct __OnReleaseMotifClicked_b__3_d : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncVoidMethodBuilder __t__builder;
				public __c__DisplayClass46_2 __4__this;
				private TaskAwaiter<CharaLimitBreakResponse> __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public __c__DisplayClass46_2();
	
			// Methods
			internal void _OnReleaseMotifClicked_b__2();
			internal async void _OnReleaseMotifClicked_b__3();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass46_3
		{
			// Fields
			public GrowthManaCircleLimitReleasePopup popup;
	
			// Constructors
			public __c__DisplayClass46_3();
	
			// Methods
			internal void _OnReleaseMotifClicked_b__4();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass46_4
		{
			// Fields
			public GrowthManaCircleCannotLimitReleasePopup popup;
			public __c__DisplayClass46_0 CS___8__locals3;
	
			// Constructors
			public __c__DisplayClass46_4();
	
			// Methods
			internal void _OnReleaseMotifClicked_b__5();
			internal void _OnReleaseMotifClicked_b__6();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass46_5
		{
			// Fields
			public GrowthManaCircleLimitReleasePopup popup;
			public __c__DisplayClass46_0 CS___8__locals4;
	
			// Constructors
			public __c__DisplayClass46_5();
	
			// Methods
			internal void _OnReleaseMotifClicked_b__7();
			internal void _OnReleaseMotifClicked_b__8();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass51_0
		{
			// Fields
			public Action onCompleted;
			public GrowthManaCircleKnightsStoryPopup popup;
			public GrowthManaCircleScene __4__this;
	
			// Constructors
			public __c__DisplayClass51_0();
	
			// Methods
			internal void _CreateCharaStoryPopup_b__0();
			internal void _CreateCharaStoryPopup_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass52_0
		{
			// Fields
			public CommonPopup errorPopup;
	
			// Constructors
			public __c__DisplayClass52_0();
	
			// Methods
			internal void _CreateReleaseAutoCannotDueToLimitPopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass53_0
		{
			// Fields
			public GrowthManaCircleAllReleaseRewardPopup popup;
			public GrowthManaCircleScene __4__this;
			public Action callBack;
	
			// Constructors
			public __c__DisplayClass53_0();
	
			// Methods
			internal void _CreateAllReleasedRewardPopup_b__0();
			internal void _CreateAllReleasedRewardPopup_b__1();
			internal void _CreateAllReleasedRewardPopup_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass54_0
		{
			// Fields
			public GrowthAwakeResultPop resultPop;
			public Action callBack;
	
			// Constructors
			public __c__DisplayClass54_0();
	
			// Methods
			internal void _CreateUsePlatinumCrystalResultPopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass58_0
		{
			// Fields
			public GrowthManaCircleAbilityListPopup popup;
	
			// Constructors
			public __c__DisplayClass58_0();
	
			// Methods
			internal void _OnAbilityListButtonPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _StartTutorialCoroutine_d__69 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthManaCircleScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _StartTutorialCoroutine_d__69(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public GrowthManaCircleScene();
	
		// Methods
		[IteratorStateMachine]
		protected virtual IEnumerator Start();
		[IteratorStateMachine]
		protected virtual new IEnumerator WaitPrevSceneExit();
		public override void OnBeforeLeaving();
		private void OnDestroy();
		protected virtual void Update();
		protected override void LateUpdate();
		protected virtual void LateUpdateTask();
		public void OnEndDrag();
		protected virtual void UpdatePointDesc(int targetCircleIndex, int centerTouchPointIndex);
		public void UpdateStatusCanvas();
		public void OnTouchPointClicked(GrowthManaCircleManaPieceObject touchedPoint);
		public void OnReleasePointSuccess(CharaBuildupManaResponse res);
		private void DoReleasePoint();
		public virtual void OnAutotButtonPressed();
		protected void ShowAutoReleasePopup(bool isReleaseSecondCircle = false);
		protected void AutoReleasePieceByPieceData(GrowthManaCircleManaPieceData pieceData, bool isReleaseSecondCircle = false);
		public void AutoReleasePieceByCircleIndex(int circleIndex);
		private void AutoReleaseCommonAction(AutoReleasableAllCirclePointData autoReleasableData, bool isGrowMaterial);
		protected virtual void SendAutoReleaseData(List<GrowthManaCircleManaPieceData> pieceDataList, bool isGrowMaterial);
		public void OnAutoReleasePointSuccess(CharaBuildupManaResponse res);
		protected virtual void DoAutoReleasePoint();
		private async void SendAutoReleaseBuildupAndLimitBreakData(AutoReleasableAllCirclePointData autoReleasableData, bool isGrowMaterial, Action<AutoReleasableAllCirclePointData> sendCompleteCallBack);
		private void AutoReleaseResultAction(AutoReleasableAllCirclePointData autoReleasableData);
		protected virtual void UsePlatinumCrystalResultAction(GrowthAwakeResultPop.BeforeData beforeData);
		private void MultiPieceReleaseResultAction(GrowthManaCircleManaPieceData[] manaPieceDatas, int limitBreakCount, bool isUsePlatinumCrystal);
		public void OnMotifClicked(GrowthManaCircleMotifObject.MotifType type, GrowthManaCircleMotifObject touchedMotif);
		private void OnReleaseMotifClicked(GrowthManaCircleMotifObject touchedMotif);
		public void OnLimitBreakSuccess(CharaLimitBreakResponse res);
		private void DoLimitBreak();
		public void GoManaCircleBlankScene(bool isShowTips = true);
		public GrowthManaCircleKnightsStoryPopup CreateCharaStoryPopup(Action onCompleted = null);
		public GrowthManaCircleKnightsStoryPopup CreateCharaStoryPopup(GrowthManaCircleModel model, int storyIndex, Action onCompleted = null);
		public static void CreateReleaseAutoCannotDueToLimitPopup();
		public GrowthManaCircleAllReleaseRewardPopup CreateAllReleasedRewardPopup(Action callBack = null);
		public void CreateUsePlatinumCrystalResultPopup(Action callBack = null);
		public void OnBackButtonPressed();
		public void SetEnablePointDescCanvas(bool arg);
		public void ForceMoveUpToMaxCircle(float duration);
		public void OnAbilityListButtonPressed();
		public void OnManaCircleMenuButtonPressed();
		public void OnGrowthButtonPressed();
		public void OnAwakeningButtonPressed();
		public void OnListButtonPressed();
		public void StartScreenSaver();
		public void FinishScreenSaver();
		public void AllReleaseForDevelop();
		public void UsePlatinumCrystalPressed();
		public virtual void Reset();
		public void StartTutorial();
		[IteratorStateMachine]
		private IEnumerator StartTutorialCoroutine();
		private void ShowTutorialPointer();
		public void ShowTutorialFinishWindow();
		[CompilerGenerated]
		private bool _Start_b__20_1();
		[CompilerGenerated]
		private bool _Start_b__20_2();
		[CompilerGenerated]
		private bool _WaitPrevSceneExit_b__21_0();
		[CompilerGenerated]
		private void _DoReleasePoint_b__32_0();
		[CompilerGenerated]
		private void _UsePlatinumCrystalPressed_b__66_0();
		[CompilerGenerated]
		private void _UsePlatinumCrystalPressed_b__66_1();
		[CompilerGenerated]
		private void _ShowTutorialFinishWindow_b__71_0();
		[CompilerGenerated]
		private void _ShowTutorialFinishWindow_b__71_1();
	}
}
