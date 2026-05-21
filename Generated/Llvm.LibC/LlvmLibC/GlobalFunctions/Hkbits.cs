using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Hkbits
{
	[MangledName("hkbits")]
	[DemangledName("hkbits")]
	public unsafe static short Invoke([MangledName("x")] short X)
	{
		short num = X;
		return Cpp_bit_cast_short_Accum_short.Invoke(&num);
	}
}
