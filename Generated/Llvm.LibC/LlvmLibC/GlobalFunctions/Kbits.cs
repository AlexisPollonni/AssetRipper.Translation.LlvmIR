using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Kbits
{
	[MangledName("kbits")]
	[DemangledName("kbits")]
	public unsafe static int Invoke([MangledName("x")] int X)
	{
		int num = X;
		return Cpp_bit_cast_Accum_int.Invoke(&num);
	}
}
