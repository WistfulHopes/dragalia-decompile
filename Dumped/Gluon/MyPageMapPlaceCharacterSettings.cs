using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Gluon;

public class MyPageMapPlaceCharacterSettings : MonoBehaviour
{
	[Serializable]
	private class IgnorePlaceCharacterSetting
	{
		public IgnorePlaceMapModeFlags mapMode;

		public List<int> characterIdList;
	}

	[Flags]
	public enum IgnorePlaceMapModeFlags
	{
		Sit = 1,
		Drink = 2
	}

	[SerializeField]
	private List<IgnorePlaceCharacterSetting> ignorePlaceCharacterTable;

	public bool IsIgnorePlaceCharacter(int characterId, [In] ref MyPageSkitMapCharaInfo currentSkitMapCharacterInfo)
	{
		return default(bool);
	}

	private IgnorePlaceMapModeFlags CreateIgnorePlaceMapModeFlag([In] ref MyPageSkitMapCharaInfo urrentSkitMapCharacterInfo)
	{
		return default(IgnorePlaceMapModeFlags);
	}

	private bool IsDrinkMotion(MyPageMapAnimations.Motion motion)
	{
		return default(bool);
	}

	private bool IsSitMotion(MyPageMapAnimations.Motion motion)
	{
		return default(bool);
	}
}
