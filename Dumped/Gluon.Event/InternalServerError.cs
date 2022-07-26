namespace Gluon.Event;

public class InternalServerError : EventBase<InternalServerError>
{
	public bool isAppError;

	public int resultCode;

	public string debugMessage;
}
