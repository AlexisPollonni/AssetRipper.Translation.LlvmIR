using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Imaxabs
{
	[MangledName("imaxabs")]
	[DemangledName("imaxabs")]
	public static long Invoke([MangledName("j")] long J)
	{
		return Llvm_libc_20_1_2_integer_abs_long_ewbna6.Invoke(J);
	}
}
