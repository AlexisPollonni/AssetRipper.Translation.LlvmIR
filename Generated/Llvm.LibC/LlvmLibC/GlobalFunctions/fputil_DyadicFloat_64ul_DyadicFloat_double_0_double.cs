using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11DyadicFloatILm64EEC2IdTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES6_")]
[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat<64ul>::DyadicFloat<double, 0>(double)")]
internal static partial class fputil_DyadicFloat_64ul_DyadicFloat_double_0_double
{
	public unsafe static void Invoke(void* @this, double x)
	{
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		BigInt_nx6qdt bigInt_nx6qdt = default(BigInt_nx6qdt);
		unchecked
		{
			llvm_memcpy_p0_p0_i64.Invoke(&((fputil_DyadicFloat_374hpp*)@this)->sign, Sign_POS.Pointer, 1L, isVolatile: false);
			((fputil_DyadicFloat_374hpp*)@this)->exponent = 0;
			BigInt_64ul_false_unsigned_long_BigInt_int_void_int.Invoke(&((fputil_DyadicFloat_374hpp*)@this)->mantissa, 0);
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			*(long*)(&fputil_FPBits_wjhbrm2) = -6148914691236517206L;
			fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm2, x);
			llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb8);
			anon_izyfb8.val = fputil_internal_FPStorage_fputil_FPType_2_sign_const.Invoke(&fputil_FPBits_wjhbrm2);
			llvm_memcpy_p0_p0_i64.Invoke(&((fputil_DyadicFloat_374hpp*)@this)->sign, &anon_izyfb8, 1L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
			((fputil_DyadicFloat_374hpp*)@this)->exponent = checked(fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_explicit_exponent_const.Invoke(&fputil_FPBits_wjhbrm2) - 52);
			llvm_lifetime_start_p0.Invoke(8L, &bigInt_nx6qdt);
			BigInt_64ul_false_unsigned_long_BigInt_unsigned_long_void_unsigned_long.Invoke(&bigInt_nx6qdt, fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_get_explicit_mantissa_const.Invoke(&fputil_FPBits_wjhbrm2));
			llvm_memcpy_p0_p0_i64.Invoke(&((fputil_DyadicFloat_374hpp*)@this)->mantissa, &bigInt_nx6qdt, 8L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(8L, &bigInt_nx6qdt);
			fputil_DyadicFloat_64ul_normalize.Invoke(@this);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		}
	}
}
