using System;
using System.Collections.Generic;
using UnityEngine;

namespace Gluon;

public class FortCharacterPlaceSetting : MonoBehaviour
{
	[Serializable]
	private class IgnorePlaceCharacterSetting
	{
		public IgnorePlaceType placeType;

		public List<int> characterIdList;
	}

	public enum IgnorePlaceType
	{
		None,
		ShortDistanceTrainingArea,
		LongDistanceTrainingArea,
		CookingArea
	}

	[SerializeField]
	private List<IgnorePlaceCharacterSetting> ignorePlaceCharacterTable;

	public List<int> GetIgnorePlaceCharacterList(FortCharaArrangeController.PlaceType placeType)
	{
		return null;
	}
}
