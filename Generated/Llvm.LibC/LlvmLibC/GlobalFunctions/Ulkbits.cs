using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Ulkbits
{
	[MangledName("ulkbits")]
	[DemangledName("ulkbits")]
	public unsafe static long Invoke([MangledName("x")] long X)
	{
		long num = X;
		return Cpp_bit_cast_unsigned_long_Accum_unsigned_long_long.Invoke(&num);
	}
}
