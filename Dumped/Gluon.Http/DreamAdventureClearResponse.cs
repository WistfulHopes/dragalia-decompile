namespace Gluon.Http;

public class DreamAdventureClearResponse : ResponseCommon
{
	public class CommonResponse
	{
		public UpdateDataList update_data_list;

		public EntityResult entity_result;

		public int result;
	}

	public CommonResponse data;
}
