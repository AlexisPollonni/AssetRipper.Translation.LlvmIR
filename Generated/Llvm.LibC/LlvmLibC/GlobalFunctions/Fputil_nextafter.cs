using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_nextafter
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil9nextafterEee")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::nextafter(long double, long double)")]
	public unsafe static double Invoke([MangledName("from")][NativeType("long double")] double From, [MangledName("to")][NativeType("long double")] double To)
	{
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi2 = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Int128 @int = default(Int128);
		Int128 int2 = default(Int128);
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi3 = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud9 llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud = default(Llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud9);
		Llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud9 llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud2 = default(Llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud9);
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi4 = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi5 = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		Int128 x = default(Int128);
		Int128 int3 = default(Int128);
		Int128 int4 = default(Int128);
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi6 = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Int128 x2 = default(Int128);
		Int128 int5 = default(Int128);
		Llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud9 llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud3 = default(Llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud9);
		Llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud9 llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud4 = default(Llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud9);
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi7 = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Anon_izyfb7 anon_izyfb4 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi8 = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Anon_izyfb7 anon_izyfb5 = default(Anon_izyfb7);
		Int128 x3 = default(Int128);
		Int128 int6 = default(Int128);
		Int128 int7 = default(Int128);
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi9 = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Int128 x4 = default(Int128);
		Int128 int8 = default(Int128);
		Llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud9 llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud5 = default(Llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud9);
		Llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud9 llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud6 = default(Llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud9);
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi10 = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Anon_izyfb7 anon_izyfb6 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi11 = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Anon_izyfb7 anon_izyfb7 = default(Anon_izyfb7);
		Int128 x5 = default(Int128);
		Int128 int9 = default(Int128);
		Int128 int10 = default(Int128);
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi12 = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Int128 x6 = default(Int128);
		Int128 int11 = default(Int128);
		Llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud9 llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud7 = default(Llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud9);
		Llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud9 llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud8 = default(Llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud9);
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi13 = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Anon_izyfb7 anon_izyfb8 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi14 = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Anon_izyfb7 anon_izyfb9 = default(Anon_izyfb7);
		Int128 x7 = default(Int128);
		Int128 int12 = default(Int128);
		Int128 int13 = default(Int128);
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi15 = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Int128 x8 = default(Int128);
		Int128 int14 = default(Int128);
		Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi);
		double result;
		unchecked
		{
			*(Int128*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi) = -6148914691236517206L;
			FPBits_long_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi, From);
			if (FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_nan.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi))
			{
				result = From;
				goto IL_0e99;
			}
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
			*(Int128*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi2) = -6148914691236517206L;
			FPBits_long_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi2, To);
			if (FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_nan.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi2))
			{
				result = To;
			}
			else
			{
				if (From != To)
				{
					if (FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_get_implicit_bit.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi) && FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_subnormal.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi))
					{
						@int = 1L;
						FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_set_biased_exponent.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi, *(long*)(&@int), ((long*)(&@int))[1]);
					}
					Llvm_lifetime_start_p0.Invoke(16L, &int2);
					int2 = long.MaxValue;
					if (From == 0.0)
					{
						Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi3);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, (!(From > To)) ? Llvm_libc_20_1_2_Sign_POS.Pointer : Llvm_libc_20_1_2_Sign_NEG.Pointer, 1L, isVolatile: false);
						Struct_fiz2nb struct_fiz2nb = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_min_subnormal.Invoke(anon_izyfb.Val);
						Int128* ptr = &llvm_libc_20_1_2_fputil_FPBits_ubgsi3.Val.Data.FPStorage.field_0;
						Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
						((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb2.field_0;
						Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
						((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb3.field_1;
						Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi, &llvm_libc_20_1_2_fputil_FPBits_ubgsi3, 16L, isVolatile: false);
						Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi3);
					}
					else if (From < 0.0)
					{
						if (To < From)
						{
							Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud, &llvm_libc_20_1_2_fputil_FPBits_ubgsi, 16L, isVolatile: false);
							Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi4);
							Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, Llvm_libc_20_1_2_Sign_NEG.Pointer, 1L, isVolatile: false);
							Struct_fiz2nb struct_fiz2nb4 = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_max_subnormal.Invoke(anon_izyfb2.Val);
							Int128* ptr2 = &llvm_libc_20_1_2_fputil_FPBits_ubgsi4.Val.Data.FPStorage.field_0;
							Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
							((Struct_fiz2nb*)ptr2)->field_0 = struct_fiz2nb5.field_0;
							Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
							((Struct_fiz2nb*)ptr2)->field_1 = struct_fiz2nb6.field_1;
							Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud2, &llvm_libc_20_1_2_fputil_FPBits_ubgsi4, 16L, isVolatile: false);
							bool num = Internal_Equals_jif2sf.Invoke(*(long*)(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud), ((long*)(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud))[1], *(long*)(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud2), ((long*)(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud2))[1]);
							Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi4);
							if (num)
							{
								Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi5);
								Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb3, Llvm_libc_20_1_2_Sign_NEG.Pointer, 1L, isVolatile: false);
								Struct_fiz2nb struct_fiz2nb7 = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_min_normal.Invoke(anon_izyfb3.Val);
								Int128* ptr3 = &llvm_libc_20_1_2_fputil_FPBits_ubgsi5.Val.Data.FPStorage.field_0;
								Struct_fiz2nb struct_fiz2nb8 = struct_fiz2nb7;
								((Struct_fiz2nb*)ptr3)->field_0 = struct_fiz2nb8.field_0;
								Struct_fiz2nb struct_fiz2nb9 = struct_fiz2nb7;
								((Struct_fiz2nb*)ptr3)->field_1 = struct_fiz2nb9.field_1;
								Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi, &llvm_libc_20_1_2_fputil_FPBits_ubgsi5, 16L, isVolatile: false);
								Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi5);
							}
							else
							{
								Struct_fiz2nb struct_fiz2nb10 = FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_mantissa.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
								Int128* num2 = &x;
								Struct_fiz2nb struct_fiz2nb11 = struct_fiz2nb10;
								*(long*)num2 = struct_fiz2nb11.field_0;
								byte* num3 = (byte*)(&x) + 8u;
								Struct_fiz2nb struct_fiz2nb12 = struct_fiz2nb10;
								*(long*)num3 = struct_fiz2nb12.field_1;
								if (NumericHelper.IntCmpEq(x, long.MaxValue))
								{
									int3 = 0L;
									FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_set_mantissa.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi, *(long*)(&int3), ((long*)(&int3))[1]);
									checked
									{
										int4 = unchecked((ushort)FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_biased_exponent.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi)) + 1;
									}
									FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_set_biased_exponent.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi, *(long*)(&int4), ((long*)(&int4))[1]);
									if (FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_inf.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi))
									{
										Fputil_raise_except_if_required.Invoke(40);
									}
									result = FPBits_long_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
									goto IL_0e75;
								}
								Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi6);
								Struct_fiz2nb struct_fiz2nb13 = FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_uintval.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
								Int128* num4 = &x2;
								Struct_fiz2nb struct_fiz2nb14 = struct_fiz2nb13;
								*(long*)num4 = struct_fiz2nb14.field_0;
								byte* num5 = (byte*)(&x2) + 8u;
								Struct_fiz2nb struct_fiz2nb15 = struct_fiz2nb13;
								*(long*)num5 = struct_fiz2nb15.field_1;
								int5 = NumericHelper.Add(x2, 1L);
								FPBits_long_double_FPBits_unsigned_int128.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi6, *(long*)(&int5), ((long*)(&int5))[1]);
								Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi, &llvm_libc_20_1_2_fputil_FPBits_ubgsi6, 16L, isVolatile: false);
								Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi6);
							}
						}
						else
						{
							Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud3, &llvm_libc_20_1_2_fputil_FPBits_ubgsi, 16L, isVolatile: false);
							Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi7);
							Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb4, Llvm_libc_20_1_2_Sign_NEG.Pointer, 1L, isVolatile: false);
							Struct_fiz2nb struct_fiz2nb16 = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_min_normal.Invoke(anon_izyfb4.Val);
							Int128* ptr4 = &llvm_libc_20_1_2_fputil_FPBits_ubgsi7.Val.Data.FPStorage.field_0;
							Struct_fiz2nb struct_fiz2nb17 = struct_fiz2nb16;
							((Struct_fiz2nb*)ptr4)->field_0 = struct_fiz2nb17.field_0;
							Struct_fiz2nb struct_fiz2nb18 = struct_fiz2nb16;
							((Struct_fiz2nb*)ptr4)->field_1 = struct_fiz2nb18.field_1;
							Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud4, &llvm_libc_20_1_2_fputil_FPBits_ubgsi7, 16L, isVolatile: false);
							bool num6 = Internal_Equals_jif2sf.Invoke(*(long*)(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud3), ((long*)(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud3))[1], *(long*)(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud4), ((long*)(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud4))[1]);
							Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi7);
							if (num6)
							{
								Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi8);
								Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb5, Llvm_libc_20_1_2_Sign_NEG.Pointer, 1L, isVolatile: false);
								Struct_fiz2nb struct_fiz2nb19 = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_max_subnormal.Invoke(anon_izyfb5.Val);
								Int128* ptr5 = &llvm_libc_20_1_2_fputil_FPBits_ubgsi8.Val.Data.FPStorage.field_0;
								Struct_fiz2nb struct_fiz2nb20 = struct_fiz2nb19;
								((Struct_fiz2nb*)ptr5)->field_0 = struct_fiz2nb20.field_0;
								Struct_fiz2nb struct_fiz2nb21 = struct_fiz2nb19;
								((Struct_fiz2nb*)ptr5)->field_1 = struct_fiz2nb21.field_1;
								Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi, &llvm_libc_20_1_2_fputil_FPBits_ubgsi8, 16L, isVolatile: false);
								Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi8);
							}
							else
							{
								Struct_fiz2nb struct_fiz2nb22 = FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_mantissa.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
								Int128* num7 = &x3;
								Struct_fiz2nb struct_fiz2nb23 = struct_fiz2nb22;
								*(long*)num7 = struct_fiz2nb23.field_0;
								byte* num8 = (byte*)(&x3) + 8u;
								Struct_fiz2nb struct_fiz2nb24 = struct_fiz2nb22;
								*(long*)num8 = struct_fiz2nb24.field_1;
								if (NumericHelper.IntCmpEq(x3, 0L))
								{
									int6 = long.MaxValue;
									FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_set_mantissa.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi, *(long*)(&int6), ((long*)(&int6))[1]);
									checked
									{
										int7 = unchecked((ushort)FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_biased_exponent.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi)) - 1;
									}
									FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_set_biased_exponent.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi, *(long*)(&int7), ((long*)(&int7))[1]);
									result = FPBits_long_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
									goto IL_0e75;
								}
								Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi9);
								Struct_fiz2nb struct_fiz2nb25 = FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_uintval.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
								Int128* num9 = &x4;
								Struct_fiz2nb struct_fiz2nb26 = struct_fiz2nb25;
								*(long*)num9 = struct_fiz2nb26.field_0;
								byte* num10 = (byte*)(&x4) + 8u;
								Struct_fiz2nb struct_fiz2nb27 = struct_fiz2nb25;
								*(long*)num10 = struct_fiz2nb27.field_1;
								int8 = NumericHelper.Subtract(x4, 1L);
								FPBits_long_double_FPBits_unsigned_int128.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi9, *(long*)(&int8), ((long*)(&int8))[1]);
								Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi, &llvm_libc_20_1_2_fputil_FPBits_ubgsi9, 16L, isVolatile: false);
								Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi9);
							}
						}
					}
					else if (To < From)
					{
						Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud5, &llvm_libc_20_1_2_fputil_FPBits_ubgsi, 16L, isVolatile: false);
						Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi10);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb6, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
						Struct_fiz2nb struct_fiz2nb28 = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_min_normal.Invoke(anon_izyfb6.Val);
						Int128* ptr6 = &llvm_libc_20_1_2_fputil_FPBits_ubgsi10.Val.Data.FPStorage.field_0;
						Struct_fiz2nb struct_fiz2nb29 = struct_fiz2nb28;
						((Struct_fiz2nb*)ptr6)->field_0 = struct_fiz2nb29.field_0;
						Struct_fiz2nb struct_fiz2nb30 = struct_fiz2nb28;
						((Struct_fiz2nb*)ptr6)->field_1 = struct_fiz2nb30.field_1;
						Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud6, &llvm_libc_20_1_2_fputil_FPBits_ubgsi10, 16L, isVolatile: false);
						bool num11 = Internal_Equals_jif2sf.Invoke(*(long*)(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud5), ((long*)(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud5))[1], *(long*)(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud6), ((long*)(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud6))[1]);
						Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi10);
						if (num11)
						{
							Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi11);
							Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb7, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
							Struct_fiz2nb struct_fiz2nb31 = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_max_subnormal.Invoke(anon_izyfb7.Val);
							Int128* ptr7 = &llvm_libc_20_1_2_fputil_FPBits_ubgsi11.Val.Data.FPStorage.field_0;
							Struct_fiz2nb struct_fiz2nb32 = struct_fiz2nb31;
							((Struct_fiz2nb*)ptr7)->field_0 = struct_fiz2nb32.field_0;
							Struct_fiz2nb struct_fiz2nb33 = struct_fiz2nb31;
							((Struct_fiz2nb*)ptr7)->field_1 = struct_fiz2nb33.field_1;
							Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi, &llvm_libc_20_1_2_fputil_FPBits_ubgsi11, 16L, isVolatile: false);
							Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi11);
						}
						else
						{
							Struct_fiz2nb struct_fiz2nb34 = FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_mantissa.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
							Int128* num12 = &x5;
							Struct_fiz2nb struct_fiz2nb35 = struct_fiz2nb34;
							*(long*)num12 = struct_fiz2nb35.field_0;
							byte* num13 = (byte*)(&x5) + 8u;
							Struct_fiz2nb struct_fiz2nb36 = struct_fiz2nb34;
							*(long*)num13 = struct_fiz2nb36.field_1;
							if (NumericHelper.IntCmpEq(x5, 0L))
							{
								int9 = long.MaxValue;
								FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_set_mantissa.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi, *(long*)(&int9), ((long*)(&int9))[1]);
								checked
								{
									int10 = unchecked((ushort)FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_biased_exponent.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi)) - 1;
								}
								FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_set_biased_exponent.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi, *(long*)(&int10), ((long*)(&int10))[1]);
								result = FPBits_long_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
								goto IL_0e75;
							}
							Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi12);
							Struct_fiz2nb struct_fiz2nb37 = FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_uintval.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
							Int128* num14 = &x6;
							Struct_fiz2nb struct_fiz2nb38 = struct_fiz2nb37;
							*(long*)num14 = struct_fiz2nb38.field_0;
							byte* num15 = (byte*)(&x6) + 8u;
							Struct_fiz2nb struct_fiz2nb39 = struct_fiz2nb37;
							*(long*)num15 = struct_fiz2nb39.field_1;
							int11 = NumericHelper.Subtract(x6, 1L);
							FPBits_long_double_FPBits_unsigned_int128.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi12, *(long*)(&int11), ((long*)(&int11))[1]);
							Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi, &llvm_libc_20_1_2_fputil_FPBits_ubgsi12, 16L, isVolatile: false);
							Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi12);
						}
					}
					else
					{
						Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud7, &llvm_libc_20_1_2_fputil_FPBits_ubgsi, 16L, isVolatile: false);
						Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi13);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
						Struct_fiz2nb struct_fiz2nb40 = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_max_subnormal.Invoke(anon_izyfb8.Val);
						Int128* ptr8 = &llvm_libc_20_1_2_fputil_FPBits_ubgsi13.Val.Data.FPStorage.field_0;
						Struct_fiz2nb struct_fiz2nb41 = struct_fiz2nb40;
						((Struct_fiz2nb*)ptr8)->field_0 = struct_fiz2nb41.field_0;
						Struct_fiz2nb struct_fiz2nb42 = struct_fiz2nb40;
						((Struct_fiz2nb*)ptr8)->field_1 = struct_fiz2nb42.field_1;
						Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud8, &llvm_libc_20_1_2_fputil_FPBits_ubgsi13, 16L, isVolatile: false);
						bool num16 = Internal_Equals_jif2sf.Invoke(*(long*)(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud7), ((long*)(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud7))[1], *(long*)(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud8), ((long*)(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_jrxud8))[1]);
						Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi13);
						if (num16)
						{
							Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi14);
							Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
							Struct_fiz2nb struct_fiz2nb43 = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_min_normal.Invoke(anon_izyfb9.Val);
							Int128* ptr9 = &llvm_libc_20_1_2_fputil_FPBits_ubgsi14.Val.Data.FPStorage.field_0;
							Struct_fiz2nb struct_fiz2nb44 = struct_fiz2nb43;
							((Struct_fiz2nb*)ptr9)->field_0 = struct_fiz2nb44.field_0;
							Struct_fiz2nb struct_fiz2nb45 = struct_fiz2nb43;
							((Struct_fiz2nb*)ptr9)->field_1 = struct_fiz2nb45.field_1;
							Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi, &llvm_libc_20_1_2_fputil_FPBits_ubgsi14, 16L, isVolatile: false);
							Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi14);
						}
						else
						{
							Struct_fiz2nb struct_fiz2nb46 = FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_mantissa.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
							Int128* num17 = &x7;
							Struct_fiz2nb struct_fiz2nb47 = struct_fiz2nb46;
							*(long*)num17 = struct_fiz2nb47.field_0;
							byte* num18 = (byte*)(&x7) + 8u;
							Struct_fiz2nb struct_fiz2nb48 = struct_fiz2nb46;
							*(long*)num18 = struct_fiz2nb48.field_1;
							if (NumericHelper.IntCmpEq(x7, long.MaxValue))
							{
								int12 = 0L;
								FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_set_mantissa.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi, *(long*)(&int12), ((long*)(&int12))[1]);
								checked
								{
									int13 = unchecked((ushort)FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_biased_exponent.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi)) + 1;
								}
								FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_set_biased_exponent.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi, *(long*)(&int13), ((long*)(&int13))[1]);
								if (FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_inf.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi))
								{
									Fputil_raise_except_if_required.Invoke(40);
								}
								result = FPBits_long_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
								goto IL_0e75;
							}
							Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi15);
							Struct_fiz2nb struct_fiz2nb49 = FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_uintval.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
							Int128* num19 = &x8;
							Struct_fiz2nb struct_fiz2nb50 = struct_fiz2nb49;
							*(long*)num19 = struct_fiz2nb50.field_0;
							byte* num20 = (byte*)(&x8) + 8u;
							Struct_fiz2nb struct_fiz2nb51 = struct_fiz2nb49;
							*(long*)num20 = struct_fiz2nb51.field_1;
							int14 = NumericHelper.Add(x8, 1L);
							FPBits_long_double_FPBits_unsigned_int128.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi15, *(long*)(&int14), ((long*)(&int14))[1]);
							Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi, &llvm_libc_20_1_2_fputil_FPBits_ubgsi15, 16L, isVolatile: false);
							Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi15);
						}
					}
					if (!FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_get_implicit_bit.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi))
					{
						Fputil_raise_except_if_required.Invoke(48);
					}
					result = FPBits_long_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
					goto IL_0e75;
				}
				result = To;
			}
			goto IL_0e87;
		}
		IL_0e99:
		Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi);
		return result;
		IL_0e87:
		Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		goto IL_0e99;
		IL_0e75:
		Llvm_lifetime_end_p0.Invoke(16L, &int2);
		goto IL_0e87;
	}
}
