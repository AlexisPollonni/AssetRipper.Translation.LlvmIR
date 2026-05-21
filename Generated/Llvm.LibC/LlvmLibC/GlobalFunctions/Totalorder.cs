using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Totalorder
{
	[MangledName("totalorder")]
	[DemangledName("totalorder")]
	public unsafe static int Invoke([MangledName("x")] void* X, [MangledName("y")] void* Y)
	{
		return unchecked(Fputil_totalorder_double.Invoke(*(double*)X, *(double*)Y)) ? 1 : 0;
	}
}
