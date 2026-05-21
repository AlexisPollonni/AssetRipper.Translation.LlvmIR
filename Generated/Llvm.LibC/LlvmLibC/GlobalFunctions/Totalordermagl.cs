using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Totalordermagl
{
	[MangledName("totalordermagl")]
	[DemangledName("totalordermagl")]
	public unsafe static int Invoke([MangledName("x")] void* X, [MangledName("y")] void* Y)
	{
		return unchecked(Fputil_totalordermag_long_double.Invoke(*(double*)X, *(double*)Y)) ? 1 : 0;
	}
}
