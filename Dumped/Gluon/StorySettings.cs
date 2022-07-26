using System;
using UnityEngine;

namespace Gluon;

public class StorySettings : MonoBehaviour
{
	public enum SettingPattern
	{
		None = -1,
		DoubleByteCharacter,
		SingleByteCharacter,
		Max
	}

	[Serializable]
	public class Setting
	{
		[SerializeField]
		public float messageAdjustBaseHeight;

		[SerializeField]
		public int messageLineMax;

		[SerializeField]
		public float messageLineHeightDiff;

		[SerializeField]
		public float monologueAdjustBaseHeight;

		[SerializeField]
		public int monologueLineMax;

		[SerializeField]
		public float monologueLineHeightDiff;

		[SerializeField]
		public float outlineAdjustBaseHeight;

		[SerializeField]
		public int outlineLineMax;

		[SerializeField]
		public float outlineLineHeightDiff;

		[SerializeField]
		public float bookTextAdjustBaseHeight;

		[SerializeField]
		public int bookTextLineMax;

		[SerializeField]
		public float bookTextLineHeightDiff;

		[SerializeField]
		public int nameLineLetterMax;

		[SerializeField]
		public int messageLineLetterMax;

		[SerializeField]
		public int monologueLineLetterMax;

		[SerializeField]
		public Vector2[] chapterIntroductionTextsParentsBasePos;

		public void ReflectionSetting()
		{
		}
	}

	public Setting[] settings;

	[SerializeField]
	public float showOneLetterInterval;

	[SerializeField]
	public float showMonologueOneLineInterval;

	[SerializeField]
	public float hideMonologueSeconds;

	[SerializeField]
	public float rubyUpCoefficient;

	[SerializeField]
	public float rubySizeCoefficient;

	[SerializeField]
	public float outlineRubyUpCoefficient;

	[SerializeField]
	public float outlineRubySizeCoefficient;

	[SerializeField]
	public float autoWaitTime;

	[SerializeField]
	public float autoWaitTimeForVoice;

	[SerializeField]
	public float autoWaitTimeForNextPage;

	[SerializeField]
	public float[] addAutoWaitTimeByLineCount;

	[SerializeField]
	public float windowFadeinTimeForPrintCommand;

	[SerializeField]
	public float windowFadeTimeWithAnimation;

	public static SettingPattern GetSettingPattern()
	{
		return default(SettingPattern);
	}

	public void ReflectionSetting()
	{
	}
}
