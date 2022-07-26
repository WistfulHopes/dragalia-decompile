using System;
using System.Collections;
using SPFX;
using UnityEngine;

namespace Gluon.Dungeon;

public class DungeonEffectObject : MonoBehaviour
{
	public string effectName;

	public int effectTrigger;

	[NonSerialized]
	public EffectObject effectInstanceObject;

	public bool playEffectOnStart;

	public GameObject linkedGameObject;

	public float effectSpeed;

	public Color effectColor;

	public float effectOpacity;

	private bool readyPlayEffect;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void PlayEffect()
	{
	}

	private IEnumerator PlayEffectCoroutine()
	{
		return null;
	}

	public SPFXInstance PlayEffectIfReady()
	{
		return null;
	}

	public void StopEffect()
	{
	}

	private SPFXInstance PlayEffectInstance()
	{
		return null;
	}
}
