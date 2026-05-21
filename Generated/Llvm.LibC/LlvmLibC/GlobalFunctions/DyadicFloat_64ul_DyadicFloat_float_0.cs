using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class DyadicFloat_64ul_DyadicFloat_float_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11DyadicFloatILm64EEC2IfTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES6_")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat<64ul>::DyadicFloat<float, 0>(float)")]
	public unsafe static void Invoke(fputil_DyadicFloat_syracv* @this, [NativeType("float")] float x)
	{
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		BigInt_555ggs bigInt_555ggs = default(BigInt_555ggs);
		llvm_memcpy_p0_p0_i64.Invoke(&@this->sign, Sign_POS.Pointer, 1L, isVolatile: false);
		@this->exponent = 0;
		BigInt_64ul_false_unsigned_long_BigInt_int_void.Invoke(&@this->mantissa, 0);
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		*unchecked((int*)(&fputil_FPBits_5nkvcs2)) = -1431655766;
		FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs2, x);
		llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb8);
		anon_izyfb8.val = FPStorage_fputil_FPType_1_sign.Invoke(&fputil_FPBits_5nkvcs2);
		llvm_memcpy_p0_p0_i64.Invoke(&@this->sign, &anon_izyfb8, 1L, isVolatile: false);
		llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
		@this->exponent = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_explicit_exponent.Invoke(unchecked((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2))) - 23;
		llvm_lifetime_start_p0.Invoke(8L, &bigInt_555ggs);
		BigInt_64ul_false_unsigned_long_BigInt_unsigned_int_void.Invoke(&bigInt_555ggs, FPRepSem_fputil_FPType_1_fputil_FPBits_float_get_explicit_mantissa.Invoke(&fputil_FPBits_5nkvcs2));
		llvm_memcpy_p0_p0_i64.Invoke(&@this->mantissa, &bigInt_555ggs, 8L, isVolatile: false);
		llvm_lifetime_end_p0.Invoke(8L, &bigInt_555ggs);
		DyadicFloat_64ul_normalize.Invoke(@this);
		llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
	}
}
