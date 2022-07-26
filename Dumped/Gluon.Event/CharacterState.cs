using UnityEngine;

namespace Gluon.Event;

public class CharacterState : EventBase<CharacterState>
{
	[Required]
	public CharacterId characterId;

	public Vector3 position;

	public float rotation;

	public CharacterId targetId;

	public short index;

	public byte state;

	[Required]
	public int[] param;

	[Required]
	public float[] paramf;

	public bool isAwake;

	public byte[] aiScriptContext;

	public RunActionEvent runActionEvent;

	public byte flags;
}
