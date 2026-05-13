using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11NormalFloatIdE28evaluate_normalization_shiftEm")]
[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat<double>::evaluate_normalization_shift(unsigned long)")]
internal static partial class fputil_NormalFloat_double_evaluate_normalization_shift_unsigned_long
{
	public unsafe static int Invoke(fputil_NormalFloat_n2h9ta* @this, long m)
	{
		int num = 0;
		long num2 = m;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 0;
		unchecked
		{
			while ((0x10000000000000L & num2) == 0L && (uint)num < 52u)
			{
				num2 <<= 1;
				num++;
			}
			int result = num;
			llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
