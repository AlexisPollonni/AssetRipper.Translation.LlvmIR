using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Totalorderl
{
	[MangledName("totalorderl")]
	[DemangledName("totalorderl")]
	public unsafe static int Invoke([MangledName("x")] void* X, [MangledName("y")] void* Y)
	{
		return unchecked(Fputil_totalorder_long_double.Invoke(*(double*)X, *(double*)Y)) ? 1 : 0;
	}
}
