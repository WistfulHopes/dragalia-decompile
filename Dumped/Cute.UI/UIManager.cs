using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Cute.UI;

public class UIManager : MonoBehaviour
{
	public const string PrefsPrefix = "UILayer_";

	public const string ToolTip = "UI用レイヤー名設\ufffd";

	public const string Group = "[UI]";

	public const int MaxLayer = 10;

	private Dictionary<string, Transform> layers;

	private List<Window> windowBuffer;

	public static UIManager Instance
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	private void Awake()
	{
	}

	public void AddControl(RectTransform control, string layer)
	{
	}

	private void Update()
	{
	}

	private void OnDestroy()
	{
	}
}
