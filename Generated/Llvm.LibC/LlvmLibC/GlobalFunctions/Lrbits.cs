using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Lrbits
{
	[MangledName("lrbits")]
	[DemangledName("lrbits")]
	public unsafe static int Invoke([MangledName("x")] int X)
	{
		int num = X;
		return Cpp_bit_cast_long_Fract_int.Invoke(&num);
	}
}
