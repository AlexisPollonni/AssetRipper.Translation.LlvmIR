using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_nextupdown_false_float128_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil10nextupdownILb0EgTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT0_EEiE4typeELi0EEES4_S4_")]
	[DemangledName("__float128 __llvm_libc_20_1_2_::fputil::nextupdown<false, __float128, 0>(__float128)")]
	[return: NativeType("__float128")]
	public unsafe static double Invoke([MangledName("x")][NativeType("__float128")] double X)
	{
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud9 llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud = default(Llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud9);
		Llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud9 llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud2 = default(Llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud9);
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi2 = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud9 llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud3 = default(Llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud9);
		Llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud9 llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud4 = default(Llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud9);
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi3 = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb4 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb5 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi4 = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Int128 x = default(Int128);
		Int128 @int = default(Int128);
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi5 = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Int128 x2 = default(Int128);
		Int128 int2 = default(Int128);
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi6 = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Anon_izyfb7 anon_izyfb6 = default(Anon_izyfb7);
		Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb);
		Llvm_memset_p0_i64.Invoke(&anon_izyfb, 0, 1L, isVolatile: false);
		Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi);
		unchecked
		{
			*(Int128*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi) = -6148914691236517206L;
			FPBits_float128_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi, X);
			bool num = FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_nan.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi));
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi3);
			int num2;
			if (num)
			{
				num2 = -1;
			}
			else
			{
				Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud, &llvm_libc_20_1_2_fputil_FPBits_ubgsi, 16L, isVolatile: false);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, &anon_izyfb, 1L, isVolatile: false);
				Struct_fiz2nb struct_fiz2nb = FPRepSem_fputil_FPType_3_fputil_FPBits_float128_max_normal.Invoke(anon_izyfb2.Val);
				Int128* ptr = &llvm_libc_20_1_2_fputil_FPBits_ubgsi2.Val.Data.FPStorage.field_0;
				Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
				((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb2.field_0;
				Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
				((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb3.field_1;
				Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud2, &llvm_libc_20_1_2_fputil_FPBits_ubgsi2, 16L, isVolatile: false);
				if (Internal_Equals_svxrxh.Invoke(*(long*)(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud), ((long*)(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud))[1], *(long*)(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud2), ((long*)(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud2))[1]))
				{
					num2 = -1;
				}
				else
				{
					Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud3, &llvm_libc_20_1_2_fputil_FPBits_ubgsi, 16L, isVolatile: false);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb3, &anon_izyfb, 1L, isVolatile: false);
					Struct_fiz2nb struct_fiz2nb4 = FPRepSem_fputil_FPType_3_fputil_FPBits_float128_inf.Invoke(anon_izyfb3.Val);
					Int128* ptr2 = &llvm_libc_20_1_2_fputil_FPBits_ubgsi3.Val.Data.FPStorage.field_0;
					Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
					((Struct_fiz2nb*)ptr2)->field_0 = struct_fiz2nb5.field_0;
					Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
					((Struct_fiz2nb*)ptr2)->field_1 = struct_fiz2nb6.field_1;
					Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud4, &llvm_libc_20_1_2_fputil_FPBits_ubgsi3, 16L, isVolatile: false);
					num2 = (Internal_Equals_svxrxh.Invoke(*(long*)(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud3), ((long*)(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud3))[1], *(long*)(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud4), ((long*)(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud4))[1]) ? 1 : 0);
				}
			}
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi3);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
			double result;
			if (num2 != 0)
			{
				result = X;
			}
			else
			{
				if (NumericHelper.IsUnorderedOrNotEquals(X, 0.0))
				{
					anon_izyfb4.Val = FPStorage_fputil_FPType_3_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb5, &anon_izyfb, 1L, isVolatile: false);
					if (Llvm_libc_20_1_2_Equals_fy8fvt.Invoke(anon_izyfb4.Val, anon_izyfb5.Val))
					{
						Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi4);
						Struct_fiz2nb struct_fiz2nb7 = FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_uintval.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
						Int128* num3 = &x;
						Struct_fiz2nb struct_fiz2nb8 = struct_fiz2nb7;
						*(long*)num3 = struct_fiz2nb8.field_0;
						byte* num4 = (byte*)(&x) + 8u;
						Struct_fiz2nb struct_fiz2nb9 = struct_fiz2nb7;
						*(long*)num4 = struct_fiz2nb9.field_1;
						@int = NumericHelper.Add(x, 1L);
						FPBits_float128_FPBits_unsigned_int128.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi4, *(long*)(&@int), ((long*)(&@int))[1]);
						Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi, &llvm_libc_20_1_2_fputil_FPBits_ubgsi4, 16L, isVolatile: false);
						Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi4);
					}
					else
					{
						Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi5);
						Struct_fiz2nb struct_fiz2nb10 = FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_uintval.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
						Int128* num5 = &x2;
						Struct_fiz2nb struct_fiz2nb11 = struct_fiz2nb10;
						*(long*)num5 = struct_fiz2nb11.field_0;
						byte* num6 = (byte*)(&x2) + 8u;
						Struct_fiz2nb struct_fiz2nb12 = struct_fiz2nb10;
						*(long*)num6 = struct_fiz2nb12.field_1;
						int2 = NumericHelper.Subtract(x2, 1L);
						FPBits_float128_FPBits_unsigned_int128.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi5, *(long*)(&int2), ((long*)(&int2))[1]);
						Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi, &llvm_libc_20_1_2_fputil_FPBits_ubgsi5, 16L, isVolatile: false);
						Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi5);
					}
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi6);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb6, &anon_izyfb, 1L, isVolatile: false);
					Struct_fiz2nb struct_fiz2nb13 = FPRepSem_fputil_FPType_3_fputil_FPBits_float128_min_subnormal.Invoke(anon_izyfb6.Val);
					Int128* ptr3 = &llvm_libc_20_1_2_fputil_FPBits_ubgsi6.Val.Data.FPStorage.field_0;
					Struct_fiz2nb struct_fiz2nb14 = struct_fiz2nb13;
					((Struct_fiz2nb*)ptr3)->field_0 = struct_fiz2nb14.field_0;
					Struct_fiz2nb struct_fiz2nb15 = struct_fiz2nb13;
					((Struct_fiz2nb*)ptr3)->field_1 = struct_fiz2nb15.field_1;
					Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi, &llvm_libc_20_1_2_fputil_FPBits_ubgsi6, 16L, isVolatile: false);
					Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi6);
				}
				result = FPBits_float128_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
			}
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi);
			Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb);
			return result;
		}
	}
}
