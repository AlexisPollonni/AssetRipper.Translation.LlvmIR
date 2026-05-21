using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Div
{
	[MangledName("div")]
	[DemangledName("div")]
	public unsafe static long Invoke([MangledName("x")] int X, [MangledName("y")] int Y)
	{
		Llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up = default(Llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up);
		unchecked
		{
			*(int*)(&llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up) = -1431655766;
			((int*)(&llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up))[1] = -1431655766;
			Llvm_libc_20_1_2_integer_rem_quo_int.Invoke(X, Y, &llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up.Mantissa, &llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up.Exponent);
			return *(long*)(&llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up);
		}
	}
}
