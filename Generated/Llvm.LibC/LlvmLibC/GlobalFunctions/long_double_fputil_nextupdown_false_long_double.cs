using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil10nextupdownILb0EEEee")]
[DemangledName("long double __llvm_libc_20_1_2_::fputil::nextupdown<false>(long double)")]
internal static partial class long_double_fputil_nextupdown_false_long_double
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
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi6 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb11 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb12 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb13 = default(anon_izyfb7);
		Int128 x2 = default(Int128);
		Int128 @int = default(Int128);
		Int128 int2 = default(Int128);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi7 = default(fputil_FPBits_ubgsi2);
		Int128 x3 = default(Int128);
		Int128 int3 = default(Int128);
		Int128 x4 = default(Int128);
		Int128 int4 = default(Int128);
		Int128 int5 = default(Int128);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi8 = default(fputil_FPBits_ubgsi2);
		Int128 x5 = default(Int128);
		Int128 int6 = default(Int128);
		llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb8);
		llvm_memset_p0_i64.Invoke(&anon_izyfb8, 0, 1L, isVolatile: false);
		llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		unchecked
		{
			*(Int128*)(&fputil_FPBits_ubgsi3) = -6148914691236517206L;
			fputil_FPBits_long_double_FPBits_long_double_long_double.Invoke(&fputil_FPBits_ubgsi3, x);
			bool num = fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_nan_const.Invoke(&fputil_FPBits_ubgsi3);
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
				Struct_fiz2nb struct_fiz2nb = fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_max_normal_Sign.Invoke(anon_izyfb9.val);
				Int128* ptr = &fputil_FPBits_ubgsi4.val.Data.FPStorage.field_0;
				Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
				((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb2.field_0;
				Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
				((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb3.field_1;
				llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepImpl_jrxud11, &fputil_FPBits_ubgsi4, 16L, isVolatile: false);
				if (fputil_internal_operator_fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double.Invoke(*(long*)(&fputil_internal_FPRepImpl_jrxud10), ((long*)(&fputil_internal_FPRepImpl_jrxud10))[1], *(long*)(&fputil_internal_FPRepImpl_jrxud11), ((long*)(&fputil_internal_FPRepImpl_jrxud11))[1]))
				{
					num2 = -1;
				}
				else
				{
					llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepImpl_jrxud12, &fputil_FPBits_ubgsi3, 16L, isVolatile: false);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, &anon_izyfb8, 1L, isVolatile: false);
					Struct_fiz2nb struct_fiz2nb4 = fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_inf_Sign.Invoke(anon_izyfb10.val);
					Int128* ptr2 = &fputil_FPBits_ubgsi5.val.Data.FPStorage.field_0;
					Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
					((Struct_fiz2nb*)ptr2)->field_0 = struct_fiz2nb5.field_0;
					Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
					((Struct_fiz2nb*)ptr2)->field_1 = struct_fiz2nb6.field_1;
					llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepImpl_jrxud13, &fputil_FPBits_ubgsi5, 16L, isVolatile: false);
					num2 = (fputil_internal_operator_fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double.Invoke(*(long*)(&fputil_internal_FPRepImpl_jrxud12), ((long*)(&fputil_internal_FPRepImpl_jrxud12))[1], *(long*)(&fputil_internal_FPRepImpl_jrxud13), ((long*)(&fputil_internal_FPRepImpl_jrxud13))[1]) ? 1 : 0);
				}
			}
			llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi5);
			llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
			double result;
			if (num2 != 0)
			{
				result = x;
			}
			else if (x == 0.0)
			{
				llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi6);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb11, &anon_izyfb8, 1L, isVolatile: false);
				Struct_fiz2nb struct_fiz2nb7 = fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_min_subnormal_Sign.Invoke(anon_izyfb11.val);
				Int128* ptr3 = &fputil_FPBits_ubgsi6.val.Data.FPStorage.field_0;
				Struct_fiz2nb struct_fiz2nb8 = struct_fiz2nb7;
				((Struct_fiz2nb*)ptr3)->field_0 = struct_fiz2nb8.field_0;
				Struct_fiz2nb struct_fiz2nb9 = struct_fiz2nb7;
				((Struct_fiz2nb*)ptr3)->field_1 = struct_fiz2nb9.field_1;
				result = fputil_FPBits_long_double_get_val_const.Invoke(&fputil_FPBits_ubgsi6);
				llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi6);
			}
			else
			{
				anon_izyfb12.val = fputil_internal_FPStorage_fputil_FPType_4_sign_const.Invoke(&fputil_FPBits_ubgsi3);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb13, &anon_izyfb8, 1L, isVolatile: false);
				if (operator_Sign_Sign_fy8fvt.Invoke(anon_izyfb12.val, anon_izyfb13.val))
				{
					Struct_fiz2nb struct_fiz2nb10 = fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_mantissa_const.Invoke(&fputil_FPBits_ubgsi3);
					Int128* num3 = &x2;
					Struct_fiz2nb struct_fiz2nb11 = struct_fiz2nb10;
					*(long*)num3 = struct_fiz2nb11.field_0;
					byte* num4 = (byte*)(&x2) + 8u;
					Struct_fiz2nb struct_fiz2nb12 = struct_fiz2nb10;
					*(long*)num4 = struct_fiz2nb12.field_1;
					if (NumericHelper.IntCmpEq(x2, long.MaxValue))
					{
						@int = 0L;
						fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_set_mantissa_unsigned_int128.Invoke(&fputil_FPBits_ubgsi3, *(long*)(&@int), ((long*)(&@int))[1]);
						checked
						{
							int2 = unchecked((ushort)fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_biased_exponent_const.Invoke(&fputil_FPBits_ubgsi3)) + 1;
						}
						fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_set_biased_exponent_unsigned_int128.Invoke(&fputil_FPBits_ubgsi3, *(long*)(&int2), ((long*)(&int2))[1]);
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi7);
						Struct_fiz2nb struct_fiz2nb13 = fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_uintval_const.Invoke(&fputil_FPBits_ubgsi3);
						Int128* num5 = &x3;
						Struct_fiz2nb struct_fiz2nb14 = struct_fiz2nb13;
						*(long*)num5 = struct_fiz2nb14.field_0;
						byte* num6 = (byte*)(&x3) + 8u;
						Struct_fiz2nb struct_fiz2nb15 = struct_fiz2nb13;
						*(long*)num6 = struct_fiz2nb15.field_1;
						int3 = NumericHelper.Add(x3, 1L);
						fputil_FPBits_long_double_FPBits_unsigned_int128_unsigned_int128.Invoke(&fputil_FPBits_ubgsi7, *(long*)(&int3), ((long*)(&int3))[1]);
						llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi3, &fputil_FPBits_ubgsi7, 16L, isVolatile: false);
						llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi7);
					}
					result = fputil_FPBits_long_double_get_val_const.Invoke(&fputil_FPBits_ubgsi3);
				}
				else
				{
					Struct_fiz2nb struct_fiz2nb16 = fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_mantissa_const.Invoke(&fputil_FPBits_ubgsi3);
					Int128* num7 = &x4;
					Struct_fiz2nb struct_fiz2nb17 = struct_fiz2nb16;
					*(long*)num7 = struct_fiz2nb17.field_0;
					byte* num8 = (byte*)(&x4) + 8u;
					Struct_fiz2nb struct_fiz2nb18 = struct_fiz2nb16;
					*(long*)num8 = struct_fiz2nb18.field_1;
					if (NumericHelper.IntCmpEq(x4, 0L))
					{
						int4 = long.MaxValue;
						fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_set_mantissa_unsigned_int128.Invoke(&fputil_FPBits_ubgsi3, *(long*)(&int4), ((long*)(&int4))[1]);
						checked
						{
							int5 = unchecked((ushort)fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_biased_exponent_const.Invoke(&fputil_FPBits_ubgsi3)) - 1;
						}
						fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_set_biased_exponent_unsigned_int128.Invoke(&fputil_FPBits_ubgsi3, *(long*)(&int5), ((long*)(&int5))[1]);
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi8);
						Struct_fiz2nb struct_fiz2nb19 = fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_uintval_const.Invoke(&fputil_FPBits_ubgsi3);
						Int128* num9 = &x5;
						Struct_fiz2nb struct_fiz2nb20 = struct_fiz2nb19;
						*(long*)num9 = struct_fiz2nb20.field_0;
						byte* num10 = (byte*)(&x5) + 8u;
						Struct_fiz2nb struct_fiz2nb21 = struct_fiz2nb19;
						*(long*)num10 = struct_fiz2nb21.field_1;
						int6 = NumericHelper.Subtract(x5, 1L);
						fputil_FPBits_long_double_FPBits_unsigned_int128_unsigned_int128.Invoke(&fputil_FPBits_ubgsi8, *(long*)(&int6), ((long*)(&int6))[1]);
						llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi3, &fputil_FPBits_ubgsi8, 16L, isVolatile: false);
						llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi8);
					}
					result = fputil_FPBits_long_double_get_val_const.Invoke(&fputil_FPBits_ubgsi3);
				}
			}
			llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
			llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
			return result;
		}
	}
}
