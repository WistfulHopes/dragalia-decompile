namespace Gluon.Http;

public class ToolAuthResponse : ResponseCommon
{
	public class CommonResponse
	{
		public ulong viewer_id;

		public string session_id;

		public string nonce;
	}

	public CommonResponse data;
}
