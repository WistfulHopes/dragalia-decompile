namespace Gluon.Http
{
	public class WeaponLimitBreakResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public UpdateDataList update_data_list;

			public EntityResult entity_result;

			public DeleteDataList delete_data_list;
		}

		public CommonResponse data;
	}
}