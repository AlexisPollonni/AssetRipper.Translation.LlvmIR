using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Totalorderf16
{
	[MangledName("totalorderf16")]
	[DemangledName("totalorderf16")]
	public unsafe static int Invoke([MangledName("x")] void* X, [MangledName("y")] void* Y)
	{
		return unchecked(Fputil_totalorder_Float16.Invoke(*(Half*)X, *(Half*)Y)) ? 1 : 0;
	}
}
