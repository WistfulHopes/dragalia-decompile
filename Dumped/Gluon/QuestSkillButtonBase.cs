using System;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

namespace Gluon;

public class QuestSkillButtonBase : FastUpdateMonoBehaviour
{
	[Serializable]
	public class CreateIconParam
	{
		[SerializeField]
		public InGameUIConst.QuestSkillType type;

		[SerializeField]
		public string[] iconNames;

		[SerializeField]
		public bool unlimited;

		[SerializeField]
		public int count;

		[SerializeField]
		public ReadyAnimType readyAnimType;

		[SerializeField]
		public bool changeAnim;
	}

	[Serializable]
	public class CreateButtonParam
	{
		[SerializeField]
		public InGameUIConst.QuestSkillType type;

		[SerializeField]
		public CreateIconParam[] iconParams;
	}

	public class ManagementIconData
	{
		public string Name
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

		public Material Material
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

		public Sprite Sprite
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

		public Material ChangeAnimMaterial
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

		public Sprite ChangeAnimSprite
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

		public bool IsTimer
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

		public bool IsValue
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

		~ManagementIconData()
		{
		}

		public void Setup(Material mtrl, string name, bool isLeft)
		{
		}

		public void Destroy()
		{
		}

		public void SetIconLayout(bool isLeft)
		{
		}
	}

	public class ManagementMultipleIconData
	{
		public int enableCount;

		public bool isUnlimited;

		public bool isDisplay;

		public bool isValidate;

		public int lastIconIndex;

		public float lastIconRate;

		public float targetIconRateManual;

		public bool isIconRateManual;

		public ReadyAnimType readyAnimType;

		public bool isChangeAnim;

		public ManagementIconData[] iconDatas;

		public Action onClick;

		~ManagementMultipleIconData()
		{
		}

		public void Reset()
		{
		}

		public void CopyTo(ManagementMultipleIconData data)
		{
		}

		public void DestroyIcon()
		{
		}

		public void SetIconLayout(bool isLeft)
		{
		}
	}

	public class ManagementMultipleButtonData
	{
		public int buttonType;

		public bool isDisplay;

		public ManagementMultipleIconData[] buttonDatas;
	}

	public enum ReadyAnimType
	{
		None,
		Normal,
		FrameOnly,
		BlinkOnly
	}

	public virtual void Show(bool isForce = false, bool isImmediate = false)
	{
	}

	public virtual void Hide(bool isForce = false, bool isImmediate = false)
	{
	}

	public virtual bool ApplyIcon(InGameUIConst.QuestSkillType type)
	{
		return default(bool);
	}

	public virtual bool ApplyIcon(InGameEventExtendAtlasManager eeAtlasManager)
	{
		return default(bool);
	}

	public virtual bool ChangeIcon(int iconIndex, bool isForce, bool isFlashAnim = true)
	{
		return default(bool);
	}

	public virtual bool ChangeIcon(int buttonIndex, int iconIndex, bool isForce, bool isFlashAnim = true)
	{
		return default(bool);
	}

	public virtual int GetIconNum()
	{
		return default(int);
	}

	public virtual int GetIconNum(int buttonIndex)
	{
		return default(int);
	}

	public virtual int GetIconIndex()
	{
		return default(int);
	}

	public virtual int GetIconIndex(int buttonIndex)
	{
		return default(int);
	}

	public virtual void SetIconRateManual(float rate, bool isForce = false)
	{
	}

	public virtual void SetIconRateManual(int buttonIndex, float rate, bool isForce = false)
	{
	}

	public virtual float GetIconRate()
	{
		return default(float);
	}

	public virtual float GetIconRate(int buttonIndex)
	{
		return default(float);
	}

	public virtual void Visible(bool b)
	{
	}

	public virtual bool IsVisible()
	{
		return default(bool);
	}

	public virtual void Validate(bool b, bool force = false)
	{
	}

	public virtual int GetCount()
	{
		return default(int);
	}

	public virtual int GetMaxCount()
	{
		return default(int);
	}

	public virtual void SetCount(int n)
	{
	}

	public virtual void SetCount(int buttonType, int n)
	{
	}

	public virtual void SetUnlimited()
	{
	}

	public virtual bool IsUnlimited()
	{
		return default(bool);
	}

	public virtual void ChangeButton(int buttonType, bool isImmediate = false)
	{
	}

	public virtual int GetButtonType()
	{
		return default(int);
	}

	public virtual void SetReadyAnim(ReadyAnimType type)
	{
	}

	public virtual bool IsReadyAnim()
	{
		return default(bool);
	}

	public virtual void SetupReadyAnim(Material frameMat)
	{
	}

	public virtual void SetVisibleReadyAnim(bool b)
	{
	}

	public virtual bool IsActiveReadyAnim()
	{
		return default(bool);
	}

	public virtual void OnUpdateReadyAnimFlash(float value)
	{
	}

	public virtual void SetChangeAnim()
	{
	}

	public virtual bool IsChangeAnim()
	{
		return default(bool);
	}

	public virtual void SetOnClick(Action onClick)
	{
	}

	public virtual void SetOnClick(int buttonType, Action onClick)
	{
	}

	public virtual void CopyData(ManagementMultipleIconData data)
	{
	}

	public virtual void CopyDara(ManagementMultipleButtonData data)
	{
	}

	public virtual void ApplyData(ManagementMultipleIconData data)
	{
	}

	public virtual void ApplyData(ManagementMultipleButtonData data)
	{
	}
}
