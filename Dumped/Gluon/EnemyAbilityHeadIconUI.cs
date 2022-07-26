using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

namespace Gluon;

public class EnemyAbilityHeadIconUI : FastUpdateMonoBehaviour
{
	[SerializeField]
	private RectTransform offsetRt;

	[SerializeField]
	private SpriteRenderer iconImage;

	private RectTransform rootRt;

	private CharacterBase owner;

	private CharacterMarkUI markUI;

	private string iconName;

	private Vector3 initOffset;

	public bool isVisible
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

	public static EnemyAbilityHeadIconUI Create(GameObject parent, CharacterBase owner, CharacterMarkUI markUI, int siblingIndex = -1)
	{
		return null;
	}

	private void Initialize(CharacterBase owner, CharacterMarkUI markUI)
	{
	}

	public override void FastUpdate()
	{
	}

	public void Visible(bool b)
	{
	}

	public void SetIcon(string iconName, bool isForce = false)
	{
	}

	public void SetOffsetY(float offsetY)
	{
	}

	protected bool IsShow()
	{
		return default(bool);
	}

	protected bool IsParentVisible()
	{
		return default(bool);
	}
}
