using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum FortEnums
	{
		CARPENTER_INIT,
		CARPENTER_ADD_MAX,
		STORAGE_INIT,
		STORAGE_ADD_MAX,
		CAMERA_PINCH_ZOOM_RATE,
		CAMERA_MOVE_ATTENUATION_RATE
	}
}