using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum ActionFocusPos
	{
		NONE,
		SELF,
		TARGET,
		CENTER,
		MULTITARGET,
		RESERVE_02,
		RESERVE_03,
		RESERVE_04,
		RESERVE_05
	}
}