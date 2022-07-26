using System;
using System.Collections.Generic;
using UnityEngine;

namespace Gluon;

public class CharacterFaceTypeSettings : MonoBehaviour
{
	[Serializable]
	public class Data
	{
		[SerializeField]
		public RenderObjectBase.FaceType faceType;

		[SerializeField]
		public CharaFaceEyeMotion eyeMotion;

		[SerializeField]
		public CharaFaceMouthMotion mouthMotion;
	}

	public Data[] dataSet;

	public void Override(Dictionary<int, CharaFaceEyeMotion> eyeFaceTypeDict, Dictionary<int, CharaFaceMouthMotion> mouthFaceTypeDict)
	{
	}
}
