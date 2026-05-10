using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9normalizeIdEEvRiRNS0_6FPBitsIT_E11StorageTypeE")]
[DemangledName("void __llvm_libc_20_1_2_::fputil::internal::normalize<double>(int&, __llvm_libc_20_1_2_::fputil::FPBits<double>::StorageType&)")]
internal static partial class void_fputil_internal_normalize_double_int_fputil_FPBits_double_StorageType
{
	public unsafe static void Invoke(void* exponent, void* mantissa)
	{
		int num = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = cpp_enable_if_cpp_is_unsigned_v_unsigned_long_int_type_cpp_countl_zero_unsigned_long_unsigned_long.Invoke(*unchecked((long*)mantissa)) - 11;
		*unchecked((int*)exponent) -= num;
		unchecked
		{
			*(long*)mantissa <<= (int)(uint)num;
			llvm_lifetime_end_p0.Invoke(4L, &num);
		}
	}
}
