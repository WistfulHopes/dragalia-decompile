using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class CommonSliderSelection : MonoBehaviour
{
	[SerializeField]
	public Slider slider;

	private CommonSlider _commonSlider;

	public Text currentValueText;

	public Text maxValueText;

	public Button minusButton;

	public Button plusButton;

	public Button maxButton;

	private List<string> displayValueTexts;

	private bool playPopSENextFrame;

	private int lastValue;

	private int invalidMinValue;

	private int invalidMaxValue;

	private int wholeNumberScale;

	[SerializeField]
	public bool isShowTapEffect;

	public Action<float> onValueChanged;

	public CommonSlider commonSlider => null;

	public bool isModifyingThroughSliderBar
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public void SetIsModifyingThroughSliderBar(bool value)
	{
	}

	private void DoPlayPoppingSE()
	{
	}

	public void PlayPoppingSE()
	{
	}

	private void LateUpdate()
	{
	}

	public void SetDisplayValueTexts(List<string> texts)
	{
	}

	public void SetInvalidValues(int invalidMax, int invalidMin = -1)
	{
	}

	public void SetWholeNumberScale(int scale)
	{
	}

	public void SetValues(long maxValue, long minValue = 1L, long currentValue = 1L)
	{
	}

	public int GetCurrentValue()
	{
		return default(int);
	}

	private float AdjustByWholeNumberScale(float value)
	{
		return default(float);
	}

	private bool AutoMatchWholeNumberScale()
	{
		return default(bool);
	}

	private void GetSeletableMinMaxValue(out float selectableMinValue, out float selectableMaxValue)
	{
	}

	public void OnSliderValueChanged(float val)
	{
	}

	public void OnPlusButton()
	{
	}

	public void OnMinusButton()
	{
	}

	public void OnMaxButton()
	{
	}

	public void SetDisableState(bool toEnabled, [Optional] string disabledText)
	{
	}
}
