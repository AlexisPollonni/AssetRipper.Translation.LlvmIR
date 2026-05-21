using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Ukbits
{
	[MangledName("ukbits")]
	[DemangledName("ukbits")]
	public unsafe static int Invoke([MangledName("x")] int X)
	{
		int num = X;
		return Cpp_bit_cast_unsigned_Accum_unsigned_int.Invoke(&num);
	}
}
