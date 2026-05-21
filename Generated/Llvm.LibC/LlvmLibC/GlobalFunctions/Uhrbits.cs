using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Uhrbits
{
	[MangledName("uhrbits")]
	[DemangledName("uhrbits")]
	public unsafe static sbyte Invoke([MangledName("x")] sbyte X)
	{
		sbyte b = X;
		return Cpp_bit_cast_unsigned_short_Fract_unsigned_char.Invoke(&b);
	}
}
