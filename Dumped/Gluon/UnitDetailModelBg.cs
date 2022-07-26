using System;
using UnityEngine;

namespace Gluon;

public class UnitDetailModelBg : MonoBehaviour
{
	[Serializable]
	public class DimToGraySetting
	{
		public ThemeColor themeColor;

		public float contrast;

		public float saturation;

		public float brightness;
	}

	[SerializeField]
	private GameObject[] bgObjects;

	[SerializeField]
	private DimToGraySetting[] dimToGraySettings;

	private ThemeColor currentThemeColor;

	private int currentThemeColorForBGIndex => default(int);

	private void Start()
	{
	}

	public void SetActiveBg(ThemeColor themeColor)
	{
	}

	public void HideAllBg()
	{
	}

	public void SetGrayoutBg(bool isGrayout, float duration = 0.3f)
	{
	}

	private void ValueShaderPropertyTo(Material mat, string propertyName, float toValue, float duration)
	{
	}
}
