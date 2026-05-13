using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal16set_implicit_bitIeEEvRNS_6fputil6FPBitsIT_EE")]
[DemangledName("void __llvm_libc_20_1_2_::internal::set_implicit_bit<long double>(__llvm_libc_20_1_2_::fputil::FPBits<long double>&)")]
internal static partial class void_internal_set_implicit_bit_long_double_fputil_FPBits_long_double
{
	public unsafe static void Invoke(void* result)
	{
		fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_set_implicit_bit_bool.Invoke(result, unchecked((ushort)fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_biased_exponent_const.Invoke(result)) != 0);
	}
}
