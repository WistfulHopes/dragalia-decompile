using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon;

public class GuildScene : SceneBase
{
	[SerializeField]
	private Transform mainPageNode;

	[SerializeField]
	private GameObject httpGreenLight;

	public Camera mainUICamera;

	[HideInInspector]
	public Canvas canvas;

	private TouchGuardObject awakeTouchGuard;

	public GuildTopPage topPage
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

	private void Awake()
	{
	}

	private IEnumerator Start()
	{
		return null;
	}

	private void OnPrevSceneExitDone()
	{
	}

	private void OnInitReady()
	{
	}

	private void LoadTopPage()
	{
	}

	private void OnEnterScene()
	{
	}

	public override void OnPresentReceived()
	{
	}

	public override void OnItemUsed()
	{
	}

	public override void OnBeforeLeaving()
	{
	}
}
