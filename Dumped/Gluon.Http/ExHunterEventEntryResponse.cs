namespace Gluon.Http;

public class ExHunterEventEntryResponse : ResponseCommon
{
	public class CommonResponse
	{
		public ExHunterEventUserList ex_hunter_event_user_data;

		public UpdateDataList update_data_list;

		public EntityResult entity_result;
	}

	public CommonResponse data;
}
