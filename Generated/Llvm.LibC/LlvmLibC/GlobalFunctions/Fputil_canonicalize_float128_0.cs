using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_canonicalize_float128_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil12canonicalizeIgTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEEiRS4_RKS4_")]
	[DemangledName("int __llvm_libc_20_1_2_::fputil::canonicalize<__float128, 0>(__float128&, __float128 const&)")]
	[return: NativeType("int")]
	public unsafe static int Invoke([MangledName("cx")][NativeType("__float128&")] void* Cx, [MangledName("x")][NativeType("__float128 const&")] void* X)
	{
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi2 = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Int128 @int = default(Int128);
		Int128 int2 = default(Int128);
		Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi);
		unchecked
		{
			*(Int128*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi) = -6148914691236517206L;
			FPBits_float128_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi, *(double*)X);
			int result;
			if (Details_expects_bool_condition_bool.Invoke(FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_signaling_nan.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi)), Expected: false))
			{
				Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
				anon_izyfb.Val = FPStorage_fputil_FPType_3_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
				Struct_fiz2nb struct_fiz2nb = FPRepSem_fputil_FPType_3_fputil_FPBits_float128_get_explicit_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi));
				Int128* num = &@int;
				Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
				*(long*)num = struct_fiz2nb2.field_0;
				byte* num2 = (byte*)(&@int) + 8u;
				Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
				*(long*)num2 = struct_fiz2nb3.field_1;
				Int128 int3 = @int;
				sbyte val = anon_izyfb.Val;
				int2 = int3;
				Struct_fiz2nb struct_fiz2nb4 = FPRepSem_fputil_FPType_3_fputil_FPBits_float128_quiet_nan.Invoke(val, *(long*)(&int2), ((long*)(&int2))[1]);
				Int128* ptr = &llvm_libc_20_1_2_fputil_FPBits_ubgsi2.Val.Data.FPStorage.field_0;
				Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
				((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb5.field_0;
				Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
				((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb6.field_1;
				*(double*)Cx = FPBits_float128_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
				Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
				Fputil_raise_except_if_required.Invoke(1);
				result = 1;
			}
			else
			{
				*(double*)Cx = *(double*)X;
				result = 0;
			}
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi);
			return result;
		}
	}
}
