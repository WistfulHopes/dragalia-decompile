using Cute.Core;
using UnityEngine;

namespace Gluon;

public class InGameGradationManager : FastUpdateMonoBehaviour
{
	public enum GradationType
	{
		ChainSkillButton
	}

	[SerializeField]
	private Gradient _chainSkillButtonGradient;

	private Material[] _materialList;

	private Texture2D[] _textureList;

	public static readonly int enumGradationTypeCount;

	public void Setup(GradationType type)
	{
	}

	private void OnDestroy()
	{
	}

	public void UpdateMaterialParam(GradationType type, float value)
	{
	}

	public Material GetMaterial(GradationType type)
	{
		return null;
	}

	public Texture2D GetTexture(GradationType type)
	{
		return null;
	}
}
