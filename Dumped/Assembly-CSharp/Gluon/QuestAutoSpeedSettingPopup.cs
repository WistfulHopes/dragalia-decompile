﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestAutoSpeedSettingPopup : CommonPopup
	{
		// Fields
		[SerializeField]
		private TabBase repeautoPlayToggle;
		[SerializeField]
		private CommonSliderSelection gameSpeedSlider;
		[SerializeField]
		private UnityEngine.UI.Text disableRepeatText;
		private UnityAction onOkButtonPressed;
		private const string popupPath = "Prefabs/OutGame/QuestPrepare/QuestAutoSpeedSettingPopup";
		private float speedSliderValue;
	
		// Constructors
		public QuestAutoSpeedSettingPopup();
	
		// Methods
		protected override void Start();
		private void SetAutoPlayToggle();
		private void SaveAutoPlayToggle();
		private void SetSliderValue();
		private void SetSliderText(float value);
		public void SliderValueChanged(float value);
		private void SaveGameSpeedt();
		public static QuestAutoSpeedSettingPopup Create(UnityAction onOkButtonPressed, bool isEnableRepeatQuest);
		public override void OnOkButtonPressed();
		[CompilerGenerated]
		private void _Start_b__6_0();
	}
}