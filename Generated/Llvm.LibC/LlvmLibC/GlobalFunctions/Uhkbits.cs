using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Uhkbits
{
	[MangledName("uhkbits")]
	[DemangledName("uhkbits")]
	public unsafe static short Invoke([MangledName("x")] short X)
	{
		short num = X;
		return Cpp_bit_cast_unsigned_short_Accum_unsigned_short.Invoke(&num);
	}
}
