using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_nextupdown_true
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil10nextupdownILb1EEEee")]
	[DemangledName("long double __llvm_libc_20_1_2_::fputil::nextupdown<true>(long double)")]
	[return: NativeType("long double")]
	public unsafe static double Invoke([MangledName("x")][NativeType("long double")] double X)
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
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi4 = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Anon_izyfb7 anon_izyfb4 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb5 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb6 = default(Anon_izyfb7);
		Int128 x = default(Int128);
		Int128 @int = default(Int128);
		Int128 int2 = default(Int128);
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi5 = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Int128 x2 = default(Int128);
		Int128 int3 = default(Int128);
		Int128 x3 = default(Int128);
		Int128 int4 = default(Int128);
		Int128 int5 = default(Int128);
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi6 = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Int128 x4 = default(Int128);
		Int128 int6 = default(Int128);
		Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb);
		unchecked
		{
			*(sbyte*)(&anon_izyfb) = 1;
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi);
			*(Int128*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi) = -6148914691236517206L;
			FPBits_long_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi, X);
			bool num = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_nan.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi3);
			int num2;
			if (num)
			{
				num2 = 1;
			}
			else
			{
				Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud, &llvm_libc_20_1_2_fputil_FPBits_ubgsi, 16L, isVolatile: false);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, &anon_izyfb, 1L, isVolatile: false);
				Struct_fiz2nb struct_fiz2nb = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_max_normal.Invoke(anon_izyfb2.Val);
				Int128* ptr = &llvm_libc_20_1_2_fputil_FPBits_ubgsi2.Val.Data.FPStorage.field_0;
				Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
				((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb2.field_0;
				Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
				((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb3.field_1;
				Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud2, &llvm_libc_20_1_2_fputil_FPBits_ubgsi2, 16L, isVolatile: false);
				if (Internal_Equals_jif2sf.Invoke(*(long*)(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud), ((long*)(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud))[1], *(long*)(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud2), ((long*)(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud2))[1]))
				{
					num2 = 1;
				}
				else
				{
					Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud3, &llvm_libc_20_1_2_fputil_FPBits_ubgsi, 16L, isVolatile: false);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb3, &anon_izyfb, 1L, isVolatile: false);
					Struct_fiz2nb struct_fiz2nb4 = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_inf.Invoke(anon_izyfb3.Val);
					Int128* ptr2 = &llvm_libc_20_1_2_fputil_FPBits_ubgsi3.Val.Data.FPStorage.field_0;
					Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
					((Struct_fiz2nb*)ptr2)->field_0 = struct_fiz2nb5.field_0;
					Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
					((Struct_fiz2nb*)ptr2)->field_1 = struct_fiz2nb6.field_1;
					Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud4, &llvm_libc_20_1_2_fputil_FPBits_ubgsi3, 16L, isVolatile: false);
					num2 = (Internal_Equals_jif2sf.Invoke(*(long*)(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud3), ((long*)(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud3))[1], *(long*)(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud4), ((long*)(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud4))[1]) ? 1 : 0);
				}
			}
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi3);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
			double result;
			if (num2 != 0)
			{
				result = X;
			}
			else if (X == 0.0)
			{
				Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi4);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb4, &anon_izyfb, 1L, isVolatile: false);
				Struct_fiz2nb struct_fiz2nb7 = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_min_subnormal.Invoke(anon_izyfb4.Val);
				Int128* ptr3 = &llvm_libc_20_1_2_fputil_FPBits_ubgsi4.Val.Data.FPStorage.field_0;
				Struct_fiz2nb struct_fiz2nb8 = struct_fiz2nb7;
				((Struct_fiz2nb*)ptr3)->field_0 = struct_fiz2nb8.field_0;
				Struct_fiz2nb struct_fiz2nb9 = struct_fiz2nb7;
				((Struct_fiz2nb*)ptr3)->field_1 = struct_fiz2nb9.field_1;
				result = FPBits_long_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi4);
				Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi4);
			}
			else
			{
				anon_izyfb5.Val = FPStorage_fputil_FPType_4_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb6, &anon_izyfb, 1L, isVolatile: false);
				if (Llvm_libc_20_1_2_Equals_fy8fvt.Invoke(anon_izyfb5.Val, anon_izyfb6.Val))
				{
					Struct_fiz2nb struct_fiz2nb10 = FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_mantissa.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
					Int128* num3 = &x;
					Struct_fiz2nb struct_fiz2nb11 = struct_fiz2nb10;
					*(long*)num3 = struct_fiz2nb11.field_0;
					byte* num4 = (byte*)(&x) + 8u;
					Struct_fiz2nb struct_fiz2nb12 = struct_fiz2nb10;
					*(long*)num4 = struct_fiz2nb12.field_1;
					if (NumericHelper.IntCmpEq(x, long.MaxValue))
					{
						@int = 0L;
						FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_set_mantissa.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi, *(long*)(&@int), ((long*)(&@int))[1]);
						checked
						{
							int2 = unchecked((ushort)FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_biased_exponent.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi)) + 1;
						}
						FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_set_biased_exponent.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi, *(long*)(&int2), ((long*)(&int2))[1]);
					}
					else
					{
						Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi5);
						Struct_fiz2nb struct_fiz2nb13 = FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_uintval.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
						Int128* num5 = &x2;
						Struct_fiz2nb struct_fiz2nb14 = struct_fiz2nb13;
						*(long*)num5 = struct_fiz2nb14.field_0;
						byte* num6 = (byte*)(&x2) + 8u;
						Struct_fiz2nb struct_fiz2nb15 = struct_fiz2nb13;
						*(long*)num6 = struct_fiz2nb15.field_1;
						int3 = NumericHelper.Add(x2, 1L);
						FPBits_long_double_FPBits_unsigned_int128.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi5, *(long*)(&int3), ((long*)(&int3))[1]);
						Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi, &llvm_libc_20_1_2_fputil_FPBits_ubgsi5, 16L, isVolatile: false);
						Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi5);
					}
					result = FPBits_long_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
				}
				else
				{
					Struct_fiz2nb struct_fiz2nb16 = FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_mantissa.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
					Int128* num7 = &x3;
					Struct_fiz2nb struct_fiz2nb17 = struct_fiz2nb16;
					*(long*)num7 = struct_fiz2nb17.field_0;
					byte* num8 = (byte*)(&x3) + 8u;
					Struct_fiz2nb struct_fiz2nb18 = struct_fiz2nb16;
					*(long*)num8 = struct_fiz2nb18.field_1;
					if (NumericHelper.IntCmpEq(x3, 0L))
					{
						int4 = long.MaxValue;
						FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_set_mantissa.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi, *(long*)(&int4), ((long*)(&int4))[1]);
						checked
						{
							int5 = unchecked((ushort)FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_biased_exponent.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi)) - 1;
						}
						FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_set_biased_exponent.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi, *(long*)(&int5), ((long*)(&int5))[1]);
					}
					else
					{
						Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi6);
						Struct_fiz2nb struct_fiz2nb19 = FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_uintval.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
						Int128* num9 = &x4;
						Struct_fiz2nb struct_fiz2nb20 = struct_fiz2nb19;
						*(long*)num9 = struct_fiz2nb20.field_0;
						byte* num10 = (byte*)(&x4) + 8u;
						Struct_fiz2nb struct_fiz2nb21 = struct_fiz2nb19;
						*(long*)num10 = struct_fiz2nb21.field_1;
						int6 = NumericHelper.Subtract(x4, 1L);
						FPBits_long_double_FPBits_unsigned_int128.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi6, *(long*)(&int6), ((long*)(&int6))[1]);
						Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi, &llvm_libc_20_1_2_fputil_FPBits_ubgsi6, 16L, isVolatile: false);
						Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi6);
					}
					result = FPBits_long_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
				}
			}
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi);
			Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb);
			return result;
		}
	}
}
