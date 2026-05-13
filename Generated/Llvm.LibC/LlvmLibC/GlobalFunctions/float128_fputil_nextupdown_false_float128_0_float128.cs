using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil10nextupdownILb0EgTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT0_EEiE4typeELi0EEES4_S4_")]
[DemangledName("__float128 __llvm_libc_20_1_2_::fputil::nextupdown<false, __float128, 0>(__float128)")]
internal static partial class float128_fputil_nextupdown_false_float128_0_float128
{
	public unsafe static double Invoke(double x)
	{
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(fputil_FPBits_ubgsi2);
		fputil_internal_FPRepImpl_jrxud9 fputil_internal_FPRepImpl_jrxud10 = default(fputil_internal_FPRepImpl_jrxud9);
		fputil_internal_FPRepImpl_jrxud9 fputil_internal_FPRepImpl_jrxud11 = default(fputil_internal_FPRepImpl_jrxud9);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi4 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		fputil_internal_FPRepImpl_jrxud9 fputil_internal_FPRepImpl_jrxud12 = default(fputil_internal_FPRepImpl_jrxud9);
		fputil_internal_FPRepImpl_jrxud9 fputil_internal_FPRepImpl_jrxud13 = default(fputil_internal_FPRepImpl_jrxud9);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi5 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb11 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb12 = default(anon_izyfb7);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi6 = default(fputil_FPBits_ubgsi2);
		Int128 x2 = default(Int128);
		Int128 @int = default(Int128);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi7 = default(fputil_FPBits_ubgsi2);
		Int128 x3 = default(Int128);
		Int128 int2 = default(Int128);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi8 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb13 = default(anon_izyfb7);
		llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb8);
		llvm_memset_p0_i64.Invoke(&anon_izyfb8, 0, 1L, isVolatile: false);
		llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		unchecked
		{
			*(Int128*)(&fputil_FPBits_ubgsi3) = -6148914691236517206L;
			fputil_FPBits_float128_FPBits_float128_float128.Invoke(&fputil_FPBits_ubgsi3, x);
			bool num = fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_nan_const.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi3));
			llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
			llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi5);
			int num2;
			if (num)
			{
				num2 = -1;
			}
			else
			{
				llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepImpl_jrxud10, &fputil_FPBits_ubgsi3, 16L, isVolatile: false);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, &anon_izyfb8, 1L, isVolatile: false);
				Struct_fiz2nb struct_fiz2nb = fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_max_normal_Sign.Invoke(anon_izyfb9.val);
				Int128* ptr = &fputil_FPBits_ubgsi4.val.Data.FPStorage.field_0;
				Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
				((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb2.field_0;
				Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
				((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb3.field_1;
				llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepImpl_jrxud11, &fputil_FPBits_ubgsi4, 16L, isVolatile: false);
				if (fputil_internal_operator_fputil_internal_FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_fputil_internal_FPRepImpl_fputil_FPType_3_fputil_FPBits_float128.Invoke(*(long*)(&fputil_internal_FPRepImpl_jrxud10), ((long*)(&fputil_internal_FPRepImpl_jrxud10))[1], *(long*)(&fputil_internal_FPRepImpl_jrxud11), ((long*)(&fputil_internal_FPRepImpl_jrxud11))[1]))
				{
					num2 = -1;
				}
				else
				{
					llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepImpl_jrxud12, &fputil_FPBits_ubgsi3, 16L, isVolatile: false);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, &anon_izyfb8, 1L, isVolatile: false);
					Struct_fiz2nb struct_fiz2nb4 = fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_inf_Sign.Invoke(anon_izyfb10.val);
					Int128* ptr2 = &fputil_FPBits_ubgsi5.val.Data.FPStorage.field_0;
					Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
					((Struct_fiz2nb*)ptr2)->field_0 = struct_fiz2nb5.field_0;
					Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
					((Struct_fiz2nb*)ptr2)->field_1 = struct_fiz2nb6.field_1;
					llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepImpl_jrxud13, &fputil_FPBits_ubgsi5, 16L, isVolatile: false);
					num2 = (fputil_internal_operator_fputil_internal_FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_fputil_internal_FPRepImpl_fputil_FPType_3_fputil_FPBits_float128.Invoke(*(long*)(&fputil_internal_FPRepImpl_jrxud12), ((long*)(&fputil_internal_FPRepImpl_jrxud12))[1], *(long*)(&fputil_internal_FPRepImpl_jrxud13), ((long*)(&fputil_internal_FPRepImpl_jrxud13))[1]) ? 1 : 0);
				}
			}
			llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi5);
			llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
			double result;
			if (num2 != 0)
			{
				result = x;
			}
			else
			{
				if (NumericHelper.IsUnorderedOrNotEquals(x, 0.0))
				{
					anon_izyfb11.val = fputil_internal_FPStorage_fputil_FPType_3_sign_const.Invoke(&fputil_FPBits_ubgsi3);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb12, &anon_izyfb8, 1L, isVolatile: false);
					if (operator_Sign_Sign_fy8fvt.Invoke(anon_izyfb11.val, anon_izyfb12.val))
					{
						llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi6);
						Struct_fiz2nb struct_fiz2nb7 = fputil_internal_FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_uintval_const.Invoke(&fputil_FPBits_ubgsi3);
						Int128* num3 = &x2;
						Struct_fiz2nb struct_fiz2nb8 = struct_fiz2nb7;
						*(long*)num3 = struct_fiz2nb8.field_0;
						byte* num4 = (byte*)(&x2) + 8u;
						Struct_fiz2nb struct_fiz2nb9 = struct_fiz2nb7;
						*(long*)num4 = struct_fiz2nb9.field_1;
						@int = NumericHelper.Add(x2, 1L);
						fputil_FPBits_float128_FPBits_unsigned_int128_unsigned_int128.Invoke(&fputil_FPBits_ubgsi6, *(long*)(&@int), ((long*)(&@int))[1]);
						llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi3, &fputil_FPBits_ubgsi6, 16L, isVolatile: false);
						llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi6);
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi7);
						Struct_fiz2nb struct_fiz2nb10 = fputil_internal_FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_uintval_const.Invoke(&fputil_FPBits_ubgsi3);
						Int128* num5 = &x3;
						Struct_fiz2nb struct_fiz2nb11 = struct_fiz2nb10;
						*(long*)num5 = struct_fiz2nb11.field_0;
						byte* num6 = (byte*)(&x3) + 8u;
						Struct_fiz2nb struct_fiz2nb12 = struct_fiz2nb10;
						*(long*)num6 = struct_fiz2nb12.field_1;
						int2 = NumericHelper.Subtract(x3, 1L);
						fputil_FPBits_float128_FPBits_unsigned_int128_unsigned_int128.Invoke(&fputil_FPBits_ubgsi7, *(long*)(&int2), ((long*)(&int2))[1]);
						llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi3, &fputil_FPBits_ubgsi7, 16L, isVolatile: false);
						llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi7);
					}
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi8);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb13, &anon_izyfb8, 1L, isVolatile: false);
					Struct_fiz2nb struct_fiz2nb13 = fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_min_subnormal_Sign.Invoke(anon_izyfb13.val);
					Int128* ptr3 = &fputil_FPBits_ubgsi8.val.Data.FPStorage.field_0;
					Struct_fiz2nb struct_fiz2nb14 = struct_fiz2nb13;
					((Struct_fiz2nb*)ptr3)->field_0 = struct_fiz2nb14.field_0;
					Struct_fiz2nb struct_fiz2nb15 = struct_fiz2nb13;
					((Struct_fiz2nb*)ptr3)->field_1 = struct_fiz2nb15.field_1;
					llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi3, &fputil_FPBits_ubgsi8, 16L, isVolatile: false);
					llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi8);
				}
				result = fputil_FPBits_float128_get_val_const.Invoke(&fputil_FPBits_ubgsi3);
			}
			llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
			llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
			return result;
		}
	}
}
