using System;

namespace Coneshell;

internal static class Plugin
{
	internal delegate IntPtr Delegate_EntryPoint();

	internal delegate int Delegate_InitializeContext(byte[] secret, byte[] entropy);

	internal delegate void Delegate_ResetContext();

	internal delegate int Delegate_PackOutSizeBound(int inSize, int enableCompress);

	internal delegate int Delegate_Pack(IntPtr pOut, byte[] inBytes, int inSize, byte[] nonce, int enableCompress);

	internal delegate int Delegate_UnpackOutSizeBound(int inSize);

	internal delegate int Delegate_Unpack(IntPtr pOut, byte[] inBytes, int inSize);

	internal delegate int Delegate_Decompress(IntPtr pOut, int outSize, IntPtr inBytes, int inSize);

	internal delegate IntPtr Delegate_CreateCustomVfs(byte[] bin, long size, byte[] name);

	internal delegate void Delegate_DestroyCustomVfs(IntPtr pVfs);

	private static bool initialized;

	private const string library_name = "il2cpp";

	internal static Delegate_EntryPoint _a;

	internal static Delegate_InitializeContext _b;

	internal static Delegate_ResetContext _c;

	internal static Delegate_PackOutSizeBound _d;

	internal static Delegate_Pack _e;

	internal static Delegate_UnpackOutSizeBound _f;

	internal static Delegate_Unpack _g;

	internal static Delegate_Decompress _h;

	internal static Delegate_CreateCustomVfs _i;

	internal static Delegate_DestroyCustomVfs _j;

	internal static extern IntPtr _fx00();

	internal static void LoadLibrary()
	{
	}

	private static T GetProc<T>(IntPtr addr) where T : class
	{
		return null;
	}

	internal static void UnloadLibrary()
	{
	}
}
