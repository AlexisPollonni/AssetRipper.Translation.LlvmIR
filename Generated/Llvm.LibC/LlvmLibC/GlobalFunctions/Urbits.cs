using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Urbits
{
	[MangledName("urbits")]
	[DemangledName("urbits")]
	public unsafe static short Invoke([MangledName("x")] short X)
	{
		short num = X;
		return Cpp_bit_cast_unsigned_Fract_unsigned_short.Invoke(&num);
	}
}
