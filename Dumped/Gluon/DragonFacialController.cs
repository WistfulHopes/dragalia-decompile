using System;
using System.Collections;
using UnityEngine;

namespace Gluon;

public class DragonFacialController : MonoBehaviour
{
	public enum ChangingPart
	{
		Mouth,
		Eye
	}

	public enum PartDefine
	{
		Normal,
		Close,
		Half,
		Damaged,
		Smiling
	}

	[Serializable]
	public class StateDependentFacialData
	{
		[SerializeField]
		public string stateName;

		[SerializeField]
		public ChangingPart part;

		[SerializeField]
		public PartDefine type;

		[HideInInspector]
		public int prevType;
	}

	private const int maxFacialCount = 5;

	private GameObject[] eyeList;

	private GameObject[] mouthList;

	private Coroutine autoBlinkCoroutine;

	private Coroutine autoTalkCoroutine;

	public PartDefine lastMouth;

	public PartDefine lastEye;

	public StateDependentFacialData[] stateDependentFacialData;

	[SerializeField]
	private bool enableAlwaysAutoBlink;

	private Animator animator;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void ProcessCommand(ChangingPart changingPart, int index, float rawValue)
	{
	}

	public void ChangeFacial(ChangingPart changingPart, int index)
	{
	}

	public void ResetToNormalFace(bool stopAllAutoAnimations = true)
	{
	}

	public void StartAutoBlink()
	{
	}

	private int GetCurrentAnimationNameHash(Animator anim)
	{
		return default(int);
	}

	private bool CheckAnimationMatch(Animator anim, int startAnimationHash, RuntimeAnimatorController startAnimation)
	{
		return default(bool);
	}

	public bool StopAutoBlink()
	{
		return default(bool);
	}

	private IEnumerator AutoBlinkCoroutine(Animator anim, int startAnimationHash, RuntimeAnimatorController startAnimation)
	{
		return null;
	}

	public void StartAutoTalk()
	{
	}

	public void StopAutoTalk()
	{
	}

	private IEnumerator AutoTalkCoroutine(Animator anim, int startAnimationHash, RuntimeAnimatorController startAnimation)
	{
		return null;
	}

	public void FBXImport_mMouth_01(float val)
	{
	}

	public void FBXImport_mMouth_02(float val)
	{
	}

	public void FBXImport_mMouth_03(float val)
	{
	}

	public void FBXImport_mMouth_04(float val)
	{
	}

	public void FBXImport_mMouth_05(float val)
	{
	}

	public void FBXImport_mEye_01(float val)
	{
	}

	public void FBXImport_mEye_02(float val)
	{
	}

	public void FBXImport_mEye_03(float val)
	{
	}

	public void FBXImport_mEye_04(float val)
	{
	}

	public void FBXImport_mEye_05(float val)
	{
	}

	public void FBXImport_DirectControl(string command)
	{
	}
}
