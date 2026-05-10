using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11NormalFloatIfE28evaluate_normalization_shiftEj")]
[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat<float>::evaluate_normalization_shift(unsigned int)")]
internal static partial class fputil_NormalFloat_float_evaluate_normalization_shift_unsigned_int
{
	public unsafe static int Invoke(void* @this, int m)
	{
		int num = 0;
		int num2 = m;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 0;
		unchecked
		{
			while ((0x800000 & num2) == 0 && (uint)num < 23u)
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
