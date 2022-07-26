namespace Gluon.Http;

public class ToolGetServiceStatusResponse : ResponseCommon
{
	public class CommonResponse
	{
		public int service_status;
	}

	public CommonResponse data;
}
