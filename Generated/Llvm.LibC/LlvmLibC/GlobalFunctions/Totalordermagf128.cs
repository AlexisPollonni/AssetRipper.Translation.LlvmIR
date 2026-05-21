using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Totalordermagf128
{
	[MangledName("totalordermagf128")]
	[DemangledName("totalordermagf128")]
	public unsafe static int Invoke([MangledName("x")] void* X, [MangledName("y")] void* Y)
	{
		return unchecked(Fputil_totalordermag_float128.Invoke(*(double*)X, *(double*)Y)) ? 1 : 0;
	}
}
