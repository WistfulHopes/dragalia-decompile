using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Gluon;

[DisallowMultipleComponent]
public class AutoLocalizeTextBinderBase : MonoBehaviour
{
	private class StringFuzzyInfo
	{
		public string text;

		public int score;

		public int enumNum;

		public StringFuzzyInfo(string text, int score, int enumNum)
		{
		}
	}

	[SerializeField]
	public string localizeTextIdStr;

	public const int defaultFindFuzzyMax = 10;

	protected virtual string prefixType
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static int CalculateStringFuzzy(string leftString, string rightString)
	{
		return default(int);
	}

	public static string FindLocalizeTextIdByText(string checkingText, string prefix, int findFuzzyMax, out List<string> fuzzyList, out List<int> matchingIds)
	{
		return null;
	}

	public static List<string> GetFuzzyList(string checkingText, string prefixType, int findFuzzyMax, [Optional] string[] texts)
	{
		return null;
	}

	public void Reset()
	{
	}

	private void Awake()
	{
	}

	public void ApplyTextBySavedLocalizeTextId()
	{
	}
}
