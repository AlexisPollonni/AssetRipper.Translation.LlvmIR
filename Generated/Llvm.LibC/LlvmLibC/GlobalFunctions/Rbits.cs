using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Rbits
{
	[MangledName("rbits")]
	[DemangledName("rbits")]
	public unsafe static short Invoke([MangledName("x")] short X)
	{
		short num = X;
		return Cpp_bit_cast_Fract_short.Invoke(&num);
	}
}
