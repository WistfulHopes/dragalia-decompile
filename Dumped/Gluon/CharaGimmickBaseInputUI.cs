using Cute.Core;
using UnityEngine;

namespace Gluon;

public class CharaGimmickBaseInputUI : FastUpdateMonoBehaviour
{
	[SerializeField]
	protected RectTransform _adjustRt;

	[SerializeField]
	protected float _humanAdjustPosY;

	[SerializeField]
	protected float _dragonAdjustPosY;

	public const float FRAME_2_SECOND = 1f / 30f;

	public virtual void Show(int num)
	{
	}

	public virtual void Hide(bool anim = true)
	{
	}

	public virtual bool IsVisible()
	{
		return default(bool);
	}

	public virtual void ReserveItem(int actionId)
	{
	}

	public virtual void SetCount(int num, bool force = false, bool immediate = false)
	{
	}

	public virtual int GetInputType()
	{
		return default(int);
	}

	public virtual int GetStepNum()
	{
		return default(int);
	}
}
