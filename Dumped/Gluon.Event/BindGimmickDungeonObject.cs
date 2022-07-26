namespace Gluon.Event;

public class BindGimmickDungeonObject : DungeonObjectParameterBase
{
	public enum BindGimmickEventType : byte
	{
		StartAction,
		Fire,
		CtrlBind
	}

	public BindGimmickEventType type;

	public long bindEventId;

	public BindEvent ctrlBindData;
}
