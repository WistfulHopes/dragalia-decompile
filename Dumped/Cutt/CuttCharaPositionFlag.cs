using System;

namespace Cutt;

[Flags]
public enum CuttCharaPositionFlag
{
	Chara1 = 1,
	Chara2 = 2,
	Chara3 = 4,
	Chara4 = 8,
	Chara5 = 0x10,
	Chara6 = 0x20,
	Chara7 = 0x40,
	Chara8 = 0x80,
	Chara9 = 0x100,
	Chara10 = 0x200
}
