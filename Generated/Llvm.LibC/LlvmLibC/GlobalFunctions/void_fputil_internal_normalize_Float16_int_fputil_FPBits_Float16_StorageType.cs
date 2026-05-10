using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9normalizeIDF16_EEvRiRNS0_6FPBitsIT_E11StorageTypeE")]
[DemangledName("void __llvm_libc_20_1_2_::fputil::internal::normalize<_Float16>(int&, __llvm_libc_20_1_2_::fputil::FPBits<_Float16>::StorageType&)")]
internal static partial class void_fputil_internal_normalize_Float16_int_fputil_FPBits_Float16_StorageType
{
	public unsafe static void Invoke(void* exponent, void* mantissa)
	{
		int num = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = cpp_enable_if_cpp_is_unsigned_v_unsigned_short_int_type_cpp_countl_zero_unsigned_short_unsigned_short.Invoke(*unchecked((short*)mantissa)) - 5;
		*unchecked((int*)exponent) -= num;
		int num2 = num;
		unchecked
		{
			*(short*)mantissa = (short)((ushort)(*(short*)mantissa) << num2);
			llvm_lifetime_end_p0.Invoke(4L, &num);
		}
	}
}
