using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Totalordermagf16
{
	[MangledName("totalordermagf16")]
	[DemangledName("totalordermagf16")]
	public unsafe static int Invoke([MangledName("x")] void* X, [MangledName("y")] void* Y)
	{
		return unchecked(Fputil_totalordermag_Float16.Invoke(*(Half*)X, *(Half*)Y)) ? 1 : 0;
	}
}
