using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_fminimum_num_float128_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil12fminimum_numIgTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_S4_")]
	[DemangledName("__float128 __llvm_libc_20_1_2_::fputil::fminimum_num<__float128, 0>(__float128, __float128)")]
	[return: NativeType("__float128")]
	public unsafe static double Invoke([MangledName("x")][NativeType("__float128")] double X, [MangledName("y")][NativeType("__float128")] double Y)
	{
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi2 = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi3 = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Int128 @int = default(Int128);
		Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi);
		double result;
		unchecked
		{
			*(Int128*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi) = -6148914691236517206L;
			FPBits_float128_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi, X);
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
			*(Int128*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi2) = -6148914691236517206L;
			FPBits_float128_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi2, Y);
			if (FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_signaling_nan.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi)) || FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_signaling_nan.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi2)))
			{
				Fputil_raise_except_if_required.Invoke(1);
				if (FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_nan.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi)) && FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_nan.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi2)))
				{
					Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi3);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
					sbyte val = anon_izyfb.Val;
					@int = 0L;
					Struct_fiz2nb struct_fiz2nb = FPRepSem_fputil_FPType_3_fputil_FPBits_float128_quiet_nan.Invoke(val, *(long*)(&@int), ((long*)(&@int))[1]);
					Int128* ptr = &llvm_libc_20_1_2_fputil_FPBits_ubgsi3.Val.Data.FPStorage.field_0;
					Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
					((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb2.field_0;
					Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
					((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb3.field_1;
					result = FPBits_float128_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi3);
					Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi3);
					goto IL_01ad;
				}
			}
			result = ((!FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_nan.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi))) ? ((!FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_nan.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi2))) ? Internal_min_float128.Invoke(X, Y) : X) : Y);
			goto IL_01ad;
		}
		IL_01ad:
		Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi);
		return result;
	}
}
