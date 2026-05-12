using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11DyadicFloatILm32EEC2IfTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES6_")]
[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat<32ul>::DyadicFloat<float, 0>(float)")]
internal static partial class fputil_DyadicFloat_32ul_DyadicFloat_float_0_float
{
	public unsafe static void Invoke(void* @this, float x)
	{
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		BigInt_fzjdu3 bigInt_fzjdu = default(BigInt_fzjdu3);
		unchecked
		{
			llvm_memcpy_p0_p0_i64.Invoke(&((fputil_DyadicFloat_c8qpxg*)@this)->sign, Sign_POS.Pointer, 1L, isVolatile: false);
			((fputil_DyadicFloat_c8qpxg*)@this)->exponent = 0;
			BigInt_32ul_false_unsigned_int_BigInt_int_void_int.Invoke(&((fputil_DyadicFloat_c8qpxg*)@this)->mantissa, 0);
			llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
			fputil_FPBits_float_FPBits_float_float.Invoke(&fputil_FPBits_5nkvcs2, x);
			llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb8);
			anon_izyfb8.val = fputil_internal_FPStorage_fputil_FPType_1_sign_const.Invoke(&fputil_FPBits_5nkvcs2);
			llvm_memcpy_p0_p0_i64.Invoke(&((fputil_DyadicFloat_c8qpxg*)@this)->sign, &anon_izyfb8, 1L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
			((fputil_DyadicFloat_c8qpxg*)@this)->exponent = checked(fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_explicit_exponent_const.Invoke(unchecked((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2))) - 23);
			llvm_lifetime_start_p0.Invoke(4L, &bigInt_fzjdu);
			BigInt_32ul_false_unsigned_int_BigInt_unsigned_int_void_unsigned_int.Invoke(&bigInt_fzjdu, fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_get_explicit_mantissa_const.Invoke(&fputil_FPBits_5nkvcs2));
			llvm_memcpy_p0_p0_i64.Invoke(&((fputil_DyadicFloat_c8qpxg*)@this)->mantissa, &bigInt_fzjdu, 4L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(4L, &bigInt_fzjdu);
			fputil_DyadicFloat_32ul_normalize.Invoke(@this);
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		}
	}
}
