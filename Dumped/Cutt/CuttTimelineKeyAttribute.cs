using System;

namespace Cutt;

[Flags]
public enum CuttTimelineKeyAttribute
{
	Disable = 1,
	CameraDelayEnable = 2,
	CameraDelayInherit = 4,
	KeyCommonBitMask = 0xFFFF
}
