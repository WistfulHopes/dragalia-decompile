namespace Gluon.Event;

public class DispBuffCaptionEvent : EventBase<DispBuffCaptionEvent>
{
	[Required]
	public CharacterId sender;

	public int type;

	public string iconName;

	public float rate;

	public string text;

	public int iconType;

	public bool isDisplayCheck;

	public int conditionId;
}
