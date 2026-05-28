using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_getpayload_float128
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil10getpayloadIgEENS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EES4_E4typeES4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<__float128>, __float128>::type __llvm_libc_20_1_2_::fputil::getpayload<__float128>(__float128)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<__float128>, __float128>::type")]
	public unsafe static double Invoke([MangledName("x")][NativeType("__float128")] double X)
	{
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi = default(Fputil_FPBits_ubgsi2);
		Int128 @int = default(Int128);
		Int128 x = default(Int128);
		Llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi);
		unchecked
		{
			*(Int128*)(&fputil_FPBits_ubgsi) = -6148914691236517206L;
			FPBits_float128_Constructor.Invoke(&fputil_FPBits_ubgsi, X);
			double result;
			if (!FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_nan.Invoke((Fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi)))
			{
				result = -1.0;
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(16L, &@int);
				Struct_fiz2nb struct_fiz2nb = FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_uintval.Invoke(&fputil_FPBits_ubgsi);
				Int128* num = &x;
				Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
				*(long*)num = struct_fiz2nb2.field_0;
				byte* num2 = (byte*)(&x) + 8u;
				Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
				*(long*)num2 = struct_fiz2nb3.field_1;
				@int = NumericHelper.BitwiseAnd(x, -1L);
				result = (double)@int;
				Llvm_lifetime_end_p0.Invoke(16L, &@int);
			}
			Llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi);
			return result;
		}
	}
}
