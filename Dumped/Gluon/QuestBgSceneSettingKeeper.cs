using System.Runtime.InteropServices;
using UnityEngine;

namespace Gluon;

public class QuestBgSceneSettingKeeper : MonoBehaviour
{
	public bool fog;

	public FogMode fogMode;

	public Color fogColor;

	public float fogStartDistance;

	public float fogEndDistance;

	public float dofFocalSize;

	public float dofFocalLength;

	public float dofSmoothness;

	public float dofQpFocalSize;

	public float dofQpFocalLength;

	public float dofQpSmoothness;

	public Cubemap reflectionCubeMap;

	public float intensityMultiplier;

	private void SaveCurrentFogSetting()
	{
	}

	public void ReflectSavedSetting([Optional] PostEffect pe, bool isUseQuestPrepareSetting = false)
	{
	}
}
