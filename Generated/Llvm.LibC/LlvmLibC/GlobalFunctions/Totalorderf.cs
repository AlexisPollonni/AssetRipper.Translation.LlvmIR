using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Totalorderf
{
	[MangledName("totalorderf")]
	[DemangledName("totalorderf")]
	public unsafe static int Invoke([MangledName("x")] void* X, [MangledName("y")] void* Y)
	{
		return unchecked(Fputil_totalorder_float.Invoke(*(float*)X, *(float*)Y)) ? 1 : 0;
	}
}
