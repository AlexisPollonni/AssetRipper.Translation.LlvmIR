using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Lkbits
{
	[MangledName("lkbits")]
	[DemangledName("lkbits")]
	public unsafe static long Invoke([MangledName("x")] long X)
	{
		long num = X;
		return Cpp_bit_cast_long_Accum_long_long.Invoke(&num);
	}
}
