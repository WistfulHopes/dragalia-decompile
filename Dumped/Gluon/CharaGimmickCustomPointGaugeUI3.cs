using UnityEngine;

namespace Gluon;

public class CharaGimmickCustomPointGaugeUI3 : CharaGimmickCustomPointGaugeUI2
{
	protected enum StateType
	{
		Normal,
		Negative,
		Num
	}

	protected class IconData
	{
		protected Sprite _sprite;

		protected Material _material;

		public Sprite Sprite => null;

		public Material Material => null;

		private IconData()
		{
		}

		public IconData(string iconName)
		{
		}

		~IconData()
		{
		}

		public void LoadIcon(string iconName)
		{
		}
	}

	[SerializeField]
	protected RectTransform _stepGaugeRootRt;

	[SerializeField]
	protected Color _gaugeNegativeColor;

	[SerializeField]
	protected int[] _negativeConditionId;

	protected HumanCharacter _owner;

	protected IconData[] _iconDataList;

	protected StateType _state;

	public new static CharaGimmickCustomPointGaugeUI3 Create(CharacterBase chara, GameObject parent, int siblingIndex = -1)
	{
		return null;
	}

	protected override void Initialize(CharacterBase chara)
	{
	}

	private void SetState(StateType type, bool isForce = false)
	{
	}

	public override void SetGaugeValue(int idx, int value, int consumeValue, int maxValue, bool isImmediateGaugeAnim = false, bool isPlayAnim = false, bool isSkipGaugePrevWaitTime = false, bool isForce = false)
	{
	}

	protected override void UpdateGaugeValue()
	{
	}

	protected bool GetBuffCountForConditionId(out int conditionId, out int count)
	{
		return default(bool);
	}

	public override int GetGaugeType()
	{
		return default(int);
	}
}
