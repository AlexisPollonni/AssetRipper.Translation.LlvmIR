using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11DyadicFloatILm64EEC2IfTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES6_")]
[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat<64ul>::DyadicFloat<float, 0>(float)")]
internal static partial class fputil_DyadicFloat_64ul_DyadicFloat_float_0_float
{
	public unsafe static void Invoke(void* @this, float x)
	{
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		BigInt_nx6qdt bigInt_nx6qdt = default(BigInt_nx6qdt);
		unchecked
		{
			llvm_memcpy_p0_p0_i64.Invoke(&((fputil_DyadicFloat_374hpp*)@this)->sign, Sign_POS.Pointer, 1L, isVolatile: false);
			((fputil_DyadicFloat_374hpp*)@this)->exponent = 0;
			BigInt_64ul_false_unsigned_long_BigInt_int_void_int.Invoke(&((fputil_DyadicFloat_374hpp*)@this)->mantissa, 0);
			llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
			fputil_FPBits_float_FPBits_float_float.Invoke(&fputil_FPBits_5nkvcs2, x);
			llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb8);
			anon_izyfb8.val = fputil_internal_FPStorage_fputil_FPType_1_sign_const.Invoke(&fputil_FPBits_5nkvcs2);
			llvm_memcpy_p0_p0_i64.Invoke(&((fputil_DyadicFloat_374hpp*)@this)->sign, &anon_izyfb8, 1L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
			((fputil_DyadicFloat_374hpp*)@this)->exponent = checked(fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_explicit_exponent_const.Invoke(&fputil_FPBits_5nkvcs2) - 23);
			llvm_lifetime_start_p0.Invoke(8L, &bigInt_nx6qdt);
			BigInt_64ul_false_unsigned_long_BigInt_unsigned_int_void_unsigned_int.Invoke(&bigInt_nx6qdt, fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_get_explicit_mantissa_const.Invoke(&fputil_FPBits_5nkvcs2));
			llvm_memcpy_p0_p0_i64.Invoke(&((fputil_DyadicFloat_374hpp*)@this)->mantissa, &bigInt_nx6qdt, 8L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(8L, &bigInt_nx6qdt);
			fputil_DyadicFloat_64ul_normalize.Invoke(@this);
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		}
	}
}
