using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Totalordermag
{
	[MangledName("totalordermag")]
	[DemangledName("totalordermag")]
	public unsafe static int Invoke([MangledName("x")] void* X, [MangledName("y")] void* Y)
	{
		return unchecked(Fputil_totalordermag_double.Invoke(*(double*)X, *(double*)Y)) ? 1 : 0;
	}
}
