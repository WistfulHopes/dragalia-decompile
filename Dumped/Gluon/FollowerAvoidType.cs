using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum FollowerAvoidType
	{
		NONE,
		FRONT,
		BACK,
		OPPOSITE_COLLISION,
		OPPOSITE_CHARA,
		RESERVE_01,
		RESERVE_02,
		RESERVE_03,
		RESERVE_04,
		RESERVE_05
	}
}