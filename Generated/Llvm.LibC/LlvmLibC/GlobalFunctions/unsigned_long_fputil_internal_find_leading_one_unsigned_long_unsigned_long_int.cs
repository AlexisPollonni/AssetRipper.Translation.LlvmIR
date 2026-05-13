using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal16find_leading_oneImEET_S3_Ri")]
[DemangledName("unsigned long __llvm_libc_20_1_2_::fputil::internal::find_leading_one<unsigned long>(unsigned long, int&)")]
internal static partial class unsigned_long_fputil_internal_find_leading_one_unsigned_long_unsigned_long_int
{
	public unsafe static long Invoke(long mant, void* shift_length)
	{
		unchecked
		{
			*(int*)shift_length = 0;
			if ((ulong)mant > 0uL)
			{
				*(int*)shift_length = (int)(63L - cpp_enable_if_cpp_is_unsigned_v_unsigned_long_int_type_cpp_countl_zero_unsigned_long_unsigned_long.Invoke(mant));
			}
			return 1L << (int)(uint)(*(int*)shift_length);
		}
	}
}
