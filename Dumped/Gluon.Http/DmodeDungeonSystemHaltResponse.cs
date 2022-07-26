namespace Gluon.Http;

public class DmodeDungeonSystemHaltResponse : ResponseCommon
{
	public class CommonResponse
	{
		public int dmode_dungeon_state;

		public UpdateDataList update_data_list;

		public EntityResult entity_result;
	}

	public CommonResponse data;
}