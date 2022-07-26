using System;
using Cute.Core;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class ShareSkillSelectButton : FastUpdateMonoBehaviour
{
	[SerializeField]
	private Button _button;

	[SerializeField]
	private SpriteRenderer _iconSprite;

	[SerializeField]
	private SkillIconCtrl _iconCtrl;

	public static ShareSkillSelectButton Create(GameObject parent, int index, Action<ShareSkillSelectButton> onClick, bool isLeft)
	{
		return null;
	}

	public void Initialize(Action<ShareSkillSelectButton> onClick, bool isLeft)
	{
	}

	public override void FastUpdate()
	{
	}

	public void SetEnableButton(bool b, bool isForce = false)
	{
	}

	private void SetIcon(Material material, Sprite sprite)
	{
	}
}
