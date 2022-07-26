using System;
using System.Collections.Generic;
using FLATOUT.Main;
using FLATOUT.Main.Utility;
using Gluon;
using UnityEngine;

namespace Cutt;

public class CuttCommandDirection : MonoBehaviour
{
	public enum CommandType
	{
		SingleTap,
		MultipleTap,
		Hold,
		Slide,
		EnumMax
	}

	public enum FlashAnimeType
	{
		Appear,
		Success,
		Timeout,
		EnumMax
	}

	[Serializable]
	public class CommandData
	{
		public enum State
		{
			None,
			Playing,
			Finished
		}

		public State state;

		public CommandType type;

		public int commandOption;

		public int lastJumpFrameId;
	}

	private CommandData currentCommandData;

	private int currentCommandFrame;

	private const string flashPrefabPath = "Prefabs/Cutt/Flash/Common/";

	[SerializeField]
	private string[] flashPrefabNameArray;

	private static readonly string[] flashAnimeLabelArray;

	private FlRoot[] flRootArray;

	private const string nodePathCountdown = "OBJ_QTE_Button/MOT_MultipleCircleSet/OBJ_imgNum_00_00";

	private FlImageNumberComponent flCountdown;

	private bool isInputSuccessFlag;

	[SerializeField]
	private float waitSecForSuccessMax;

	private float waitSecForSuccessNow;

	public const string soundLabelFlashStart = "SE_QTE_APP_0000000_021";

	public const string soundLabelFlashSuccess = "SE_QTE_APP_0000000_022";

	private int multipleTapCounter;

	private List<float> swipeAngles;

	private InGameCuttCommandCircleGauge multipleTapCircleGauge;

	private bool forceSkipFlag;

	public static CuttCommandDirection instance;

	public CommandData GetCurrentCommandData()
	{
		return null;
	}

	public void ResetCommand()
	{
	}

	public bool IsPlayingCommand()
	{
		return default(bool);
	}

	public void SkipCommand()
	{
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void Initialize(GameObject canvasObject)
	{
	}

	public void StartCommand(int frame, CommandData data)
	{
	}

	private void Update()
	{
	}

	public void PlayFlashMotion(CommandType commandType, int optionId, FlashAnimeType animeType)
	{
	}

	private void InitializeCommand()
	{
	}

	private void CloseCommand()
	{
	}

	private void FinishInput()
	{
	}

	private void FinalizeCommand()
	{
	}

	private bool UpdateCommand()
	{
		return default(bool);
	}
}
