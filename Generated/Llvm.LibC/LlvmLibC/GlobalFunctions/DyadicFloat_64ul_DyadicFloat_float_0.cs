using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class DyadicFloat_64ul_DyadicFloat_float_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11DyadicFloatILm64EEC2IfTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES6_")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat<64ul>::DyadicFloat<float, 0>(float)")]
	public unsafe static void Invoke([MangledName("this")] Fputil_DyadicFloat_syracv* This, [MangledName("x")][NativeType("float")] float X)
	{
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs = default(Fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		BigInt_555ggs bigInt_555ggs = default(BigInt_555ggs);
		Llvm_memcpy_p0_p0_i64.Invoke(&This->Sign, Sign_POS.Pointer, 1L, isVolatile: false);
		This->Exponent = 0;
		BigInt_64ul_false_unsigned_long_BigInt_int_void.Invoke(&This->Mantissa, 0);
		Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs);
		*unchecked((int*)(&fputil_FPBits_5nkvcs)) = -1431655766;
		FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs, X);
		Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb);
		anon_izyfb.Val = FPStorage_fputil_FPType_1_sign.Invoke(&fputil_FPBits_5nkvcs);
		Llvm_memcpy_p0_p0_i64.Invoke(&This->Sign, &anon_izyfb, 1L, isVolatile: false);
		Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb);
		This->Exponent = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_explicit_exponent.Invoke(unchecked((Fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs))) - 23;
		Llvm_lifetime_start_p0.Invoke(8L, &bigInt_555ggs);
		BigInt_64ul_false_unsigned_long_BigInt_unsigned_int_void.Invoke(&bigInt_555ggs, FPRepSem_fputil_FPType_1_fputil_FPBits_float_get_explicit_mantissa.Invoke(&fputil_FPBits_5nkvcs));
		Llvm_memcpy_p0_p0_i64.Invoke(&This->Mantissa, &bigInt_555ggs, 8L, isVolatile: false);
		Llvm_lifetime_end_p0.Invoke(8L, &bigInt_555ggs);
		DyadicFloat_64ul_normalize.Invoke(This);
		Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs);
	}
}
