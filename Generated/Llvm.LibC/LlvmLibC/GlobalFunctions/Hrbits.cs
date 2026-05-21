using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Hrbits
{
	[MangledName("hrbits")]
	[DemangledName("hrbits")]
	public unsafe static sbyte Invoke([MangledName("x")] sbyte X)
	{
		sbyte b = X;
		return Cpp_bit_cast_short_Fract_signed_char.Invoke(&b);
	}
}
