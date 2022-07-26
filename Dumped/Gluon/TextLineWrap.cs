using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class TextLineWrap : MonoBehaviour
{
	public bool changeOnlyOnce;

	public bool shrinkOnChange;

	private TextGenerator generator;

	private int changeCount;

	private const string targetBeginChars = "､、｡。\\)）\\]」』\\}】,〕〉》〟\\’\\”\\.・";

	private void Start()
	{
	}

	public IEnumerator SetupText()
	{
		return null;
	}

	public static float GetProperWidthRecursively(TextGenerator generator, Text text, float width, float height, int maxRetryTime, int currentRetryTime, bool shrinkOnChange)
	{
		return default(float);
	}
}
