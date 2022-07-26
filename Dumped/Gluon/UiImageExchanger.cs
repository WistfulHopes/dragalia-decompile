using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon;

public class UiImageExchanger : MonoBehaviour
{
	public class IndexReceiver
	{
		public int index;
	}

	[Serializable]
	public class IndexReceiveEvent : UnityEvent<IndexReceiver>
	{
	}

	[SerializeField]
	protected Image targetImage;

	[SerializeField]
	protected Sprite[] exchangeSprites;

	[SerializeField]
	protected Material[] exchangeMaterials;

	[SerializeField]
	public IndexReceiveEvent indexGetter;

	[SerializeField]
	private bool isUseFooterMenuTabIndex;

	private IndexReceiver myIndexReceiver;

	private void Start()
	{
	}

	public virtual void SetImage(int index, bool isOverrideSprite = false)
	{
	}
}
