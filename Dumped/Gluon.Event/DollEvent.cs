namespace Gluon.Event;

public class DollEvent : EventBase<DollEvent>
{
	public CharacterId target;

	public CharacterId from;

	public int value;

	public float duration;

	public bool isTimeUp;

	public bool canTransform;
}
