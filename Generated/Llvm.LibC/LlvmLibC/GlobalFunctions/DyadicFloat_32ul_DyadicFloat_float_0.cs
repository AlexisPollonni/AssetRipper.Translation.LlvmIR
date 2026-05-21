using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class DyadicFloat_32ul_DyadicFloat_float_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11DyadicFloatILm32EEC2IfTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES6_")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat<32ul>::DyadicFloat<float, 0>(float)")]
	public unsafe static void Invoke(void* @this, [NativeType("float")] float x)
	{
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		BigInt_vtm4cw bigInt_vtm4cw = default(BigInt_vtm4cw);
		unchecked
		{
			llvm_memcpy_p0_p0_i64.Invoke(&((fputil_DyadicFloat_cs3nhs*)@this)->sign, Sign_POS.Pointer, 1L, isVolatile: false);
			((fputil_DyadicFloat_cs3nhs*)@this)->exponent = 0;
			BigInt_32ul_false_unsigned_int_BigInt_int_void.Invoke(&((fputil_DyadicFloat_cs3nhs*)@this)->mantissa, 0);
			llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
			FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs2, x);
			llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb8);
			anon_izyfb8.val = FPStorage_fputil_FPType_1_sign.Invoke(&fputil_FPBits_5nkvcs2);
			llvm_memcpy_p0_p0_i64.Invoke(&((fputil_DyadicFloat_cs3nhs*)@this)->sign, &anon_izyfb8, 1L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
			((fputil_DyadicFloat_cs3nhs*)@this)->exponent = checked(FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_explicit_exponent.Invoke(unchecked((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2))) - 23);
			llvm_lifetime_start_p0.Invoke(4L, &bigInt_vtm4cw);
			BigInt_32ul_false_unsigned_int_BigInt_unsigned_int_void.Invoke(&bigInt_vtm4cw, FPRepSem_fputil_FPType_1_fputil_FPBits_float_get_explicit_mantissa.Invoke(&fputil_FPBits_5nkvcs2));
			llvm_memcpy_p0_p0_i64.Invoke(&((fputil_DyadicFloat_cs3nhs*)@this)->mantissa, &bigInt_vtm4cw, 4L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(4L, &bigInt_vtm4cw);
			DyadicFloat_32ul_normalize.Invoke(@this);
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		}
	}
}
