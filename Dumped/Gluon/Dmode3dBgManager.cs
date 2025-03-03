using System.Collections;
using Gluon.Dungeon;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Gluon;

public class Dmode3dBgManager : SingletonMonoBehaviour<Dmode3dBgManager>
{
	public PartyBgContent currentBgContent;

	public PartyBgContent nextBgContent;

	private string lastLightMapSceneName;

	private QuestBgSceneSettingKeeper bgSettingKeeper;

	public bool isSceneLoadCompleted;

	public bool dontDestroyOnDestroy;

	private static Scene createdScene;

	private static DungeonManager.OutDesignerAreaDataCache designerAreaDataCache;

	private EnvironmentMap environment;

	private SceneShaderSettings sceneShaderSettings;

	public static string bgFileName;

	public void LoadBgScene()
	{
	}

	public void LoadBgScene(string resourcePath, string filename, int selectQuestId)
	{
	}

	private IEnumerator LoadBgSceneCoroutine(string resourcePath, string filename)
	{
		return null;
	}

	public void ApplyBgSceneShader()
	{
	}

	public bool ReloadBgFileNameFromCreatedScene()
	{
		return default(bool);
	}

	public void ReflectBgSettings(PostEffect pe)
	{
	}

	private Scene GetLatestSceneByName(string filename)
	{
		return default(Scene);
	}

	public void ShowBg()
	{
	}

	private IEnumerator ShowBgCoroutine()
	{
		return null;
	}

	public void Destroy()
	{
	}

	public void SetCharaLightProbeParam(GameObject character)
	{
	}

	public IEnumerator SetCharaLightProbeParamCoroutine(GameObject character)
	{
		return null;
	}
}
