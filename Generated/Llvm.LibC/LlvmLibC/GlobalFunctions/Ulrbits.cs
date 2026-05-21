using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Ulrbits
{
	[MangledName("ulrbits")]
	[DemangledName("ulrbits")]
	public unsafe static int Invoke([MangledName("x")] int X)
	{
		int num = X;
		return Cpp_bit_cast_unsigned_long_Fract_unsigned_int.Invoke(&num);
	}
}
