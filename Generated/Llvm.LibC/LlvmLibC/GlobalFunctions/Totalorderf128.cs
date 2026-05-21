using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Totalorderf128
{
	[MangledName("totalorderf128")]
	[DemangledName("totalorderf128")]
	public unsafe static int Invoke([MangledName("x")] void* X, [MangledName("y")] void* Y)
	{
		return unchecked(Fputil_totalorder_float128.Invoke(*(double*)X, *(double*)Y)) ? 1 : 0;
	}
}
