using System.Runtime.InteropServices;

namespace FLATOUT.Main
{
	[StructLayout(3, Size = 4)]
	public enum FlCommonStateTypes
	{
		None,
		Start,
		Loop,
		End
	}
}