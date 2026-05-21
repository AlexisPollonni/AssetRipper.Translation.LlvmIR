using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_nextafter
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil9nextafterEee")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::nextafter(long double, long double)")]
	public unsafe static double Invoke([NativeType("long double")] double from, [NativeType("long double")] double to)
	{
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(fputil_FPBits_ubgsi2);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi4 = default(fputil_FPBits_ubgsi2);
		Int128 @int = default(Int128);
		Int128 int2 = default(Int128);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi5 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		fputil_internal_FPRepImpl_jrxud9 fputil_internal_FPRepImpl_jrxud10 = default(fputil_internal_FPRepImpl_jrxud9);
		fputil_internal_FPRepImpl_jrxud9 fputil_internal_FPRepImpl_jrxud11 = default(fputil_internal_FPRepImpl_jrxud9);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi6 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi7 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		Int128 x = default(Int128);
		Int128 int3 = default(Int128);
		Int128 int4 = default(Int128);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi8 = default(fputil_FPBits_ubgsi2);
		Int128 x2 = default(Int128);
		Int128 int5 = default(Int128);
		fputil_internal_FPRepImpl_jrxud9 fputil_internal_FPRepImpl_jrxud12 = default(fputil_internal_FPRepImpl_jrxud9);
		fputil_internal_FPRepImpl_jrxud9 fputil_internal_FPRepImpl_jrxud13 = default(fputil_internal_FPRepImpl_jrxud9);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi9 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb11 = default(anon_izyfb7);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi10 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb12 = default(anon_izyfb7);
		Int128 x3 = default(Int128);
		Int128 int6 = default(Int128);
		Int128 int7 = default(Int128);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi11 = default(fputil_FPBits_ubgsi2);
		Int128 x4 = default(Int128);
		Int128 int8 = default(Int128);
		fputil_internal_FPRepImpl_jrxud9 fputil_internal_FPRepImpl_jrxud14 = default(fputil_internal_FPRepImpl_jrxud9);
		fputil_internal_FPRepImpl_jrxud9 fputil_internal_FPRepImpl_jrxud15 = default(fputil_internal_FPRepImpl_jrxud9);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi12 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb13 = default(anon_izyfb7);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi13 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb14 = default(anon_izyfb7);
		Int128 x5 = default(Int128);
		Int128 int9 = default(Int128);
		Int128 int10 = default(Int128);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi14 = default(fputil_FPBits_ubgsi2);
		Int128 x6 = default(Int128);
		Int128 int11 = default(Int128);
		fputil_internal_FPRepImpl_jrxud9 fputil_internal_FPRepImpl_jrxud16 = default(fputil_internal_FPRepImpl_jrxud9);
		fputil_internal_FPRepImpl_jrxud9 fputil_internal_FPRepImpl_jrxud17 = default(fputil_internal_FPRepImpl_jrxud9);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi15 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb15 = default(anon_izyfb7);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi16 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb16 = default(anon_izyfb7);
		Int128 x7 = default(Int128);
		Int128 int12 = default(Int128);
		Int128 int13 = default(Int128);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi17 = default(fputil_FPBits_ubgsi2);
		Int128 x8 = default(Int128);
		Int128 int14 = default(Int128);
		llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		double result;
		unchecked
		{
			*(Int128*)(&fputil_FPBits_ubgsi3) = -6148914691236517206L;
			FPBits_long_double_Constructor.Invoke(&fputil_FPBits_ubgsi3, from);
			if (FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_nan.Invoke(&fputil_FPBits_ubgsi3))
			{
				result = from;
				goto IL_0e99;
			}
			llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
			*(Int128*)(&fputil_FPBits_ubgsi4) = -6148914691236517206L;
			FPBits_long_double_Constructor.Invoke(&fputil_FPBits_ubgsi4, to);
			if (FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_nan.Invoke(&fputil_FPBits_ubgsi4))
			{
				result = to;
			}
			else
			{
				if (from != to)
				{
					if (FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_get_implicit_bit.Invoke(&fputil_FPBits_ubgsi3) && FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_subnormal.Invoke(&fputil_FPBits_ubgsi3))
					{
						@int = 1L;
						FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_set_biased_exponent.Invoke(&fputil_FPBits_ubgsi3, *(long*)(&@int), ((long*)(&@int))[1]);
					}
					llvm_lifetime_start_p0.Invoke(16L, &int2);
					int2 = long.MaxValue;
					if (from == 0.0)
					{
						llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi5);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, (!(from > to)) ? Sign_POS.Pointer : Sign_NEG.Pointer, 1L, isVolatile: false);
						Struct_fiz2nb struct_fiz2nb = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_min_subnormal.Invoke(anon_izyfb8.val);
						Int128* ptr = &fputil_FPBits_ubgsi5.val.Data.FPStorage.field_0;
						Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
						((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb2.field_0;
						Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
						((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb3.field_1;
						llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi3, &fputil_FPBits_ubgsi5, 16L, isVolatile: false);
						llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi5);
					}
					else if (from < 0.0)
					{
						if (to < from)
						{
							llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepImpl_jrxud10, &fputil_FPBits_ubgsi3, 16L, isVolatile: false);
							llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi6);
							llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, Sign_NEG.Pointer, 1L, isVolatile: false);
							Struct_fiz2nb struct_fiz2nb4 = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_max_subnormal.Invoke(anon_izyfb9.val);
							Int128* ptr2 = &fputil_FPBits_ubgsi6.val.Data.FPStorage.field_0;
							Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
							((Struct_fiz2nb*)ptr2)->field_0 = struct_fiz2nb5.field_0;
							Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
							((Struct_fiz2nb*)ptr2)->field_1 = struct_fiz2nb6.field_1;
							llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepImpl_jrxud11, &fputil_FPBits_ubgsi6, 16L, isVolatile: false);
							bool num = internal_Equals_jif2sf.Invoke(*(long*)(&fputil_internal_FPRepImpl_jrxud10), ((long*)(&fputil_internal_FPRepImpl_jrxud10))[1], *(long*)(&fputil_internal_FPRepImpl_jrxud11), ((long*)(&fputil_internal_FPRepImpl_jrxud11))[1]);
							llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi6);
							if (num)
							{
								llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi7);
								llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, Sign_NEG.Pointer, 1L, isVolatile: false);
								Struct_fiz2nb struct_fiz2nb7 = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_min_normal.Invoke(anon_izyfb10.val);
								Int128* ptr3 = &fputil_FPBits_ubgsi7.val.Data.FPStorage.field_0;
								Struct_fiz2nb struct_fiz2nb8 = struct_fiz2nb7;
								((Struct_fiz2nb*)ptr3)->field_0 = struct_fiz2nb8.field_0;
								Struct_fiz2nb struct_fiz2nb9 = struct_fiz2nb7;
								((Struct_fiz2nb*)ptr3)->field_1 = struct_fiz2nb9.field_1;
								llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi3, &fputil_FPBits_ubgsi7, 16L, isVolatile: false);
								llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi7);
							}
							else
							{
								Struct_fiz2nb struct_fiz2nb10 = FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_mantissa.Invoke(&fputil_FPBits_ubgsi3);
								Int128* num2 = &x;
								Struct_fiz2nb struct_fiz2nb11 = struct_fiz2nb10;
								*(long*)num2 = struct_fiz2nb11.field_0;
								byte* num3 = (byte*)(&x) + 8u;
								Struct_fiz2nb struct_fiz2nb12 = struct_fiz2nb10;
								*(long*)num3 = struct_fiz2nb12.field_1;
								if (NumericHelper.IntCmpEq(x, long.MaxValue))
								{
									int3 = 0L;
									FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_set_mantissa.Invoke(&fputil_FPBits_ubgsi3, *(long*)(&int3), ((long*)(&int3))[1]);
									checked
									{
										int4 = unchecked((ushort)FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_biased_exponent.Invoke(&fputil_FPBits_ubgsi3)) + 1;
									}
									FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_set_biased_exponent.Invoke(&fputil_FPBits_ubgsi3, *(long*)(&int4), ((long*)(&int4))[1]);
									if (FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_inf.Invoke(&fputil_FPBits_ubgsi3))
									{
										fputil_raise_except_if_required.Invoke(40);
									}
									result = FPBits_long_double_get_val.Invoke(&fputil_FPBits_ubgsi3);
									goto IL_0e75;
								}
								llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi8);
								Struct_fiz2nb struct_fiz2nb13 = FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_uintval.Invoke(&fputil_FPBits_ubgsi3);
								Int128* num4 = &x2;
								Struct_fiz2nb struct_fiz2nb14 = struct_fiz2nb13;
								*(long*)num4 = struct_fiz2nb14.field_0;
								byte* num5 = (byte*)(&x2) + 8u;
								Struct_fiz2nb struct_fiz2nb15 = struct_fiz2nb13;
								*(long*)num5 = struct_fiz2nb15.field_1;
								int5 = NumericHelper.Add(x2, 1L);
								FPBits_long_double_FPBits_unsigned_int128.Invoke(&fputil_FPBits_ubgsi8, *(long*)(&int5), ((long*)(&int5))[1]);
								llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi3, &fputil_FPBits_ubgsi8, 16L, isVolatile: false);
								llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi8);
							}
						}
						else
						{
							llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepImpl_jrxud12, &fputil_FPBits_ubgsi3, 16L, isVolatile: false);
							llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi9);
							llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb11, Sign_NEG.Pointer, 1L, isVolatile: false);
							Struct_fiz2nb struct_fiz2nb16 = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_min_normal.Invoke(anon_izyfb11.val);
							Int128* ptr4 = &fputil_FPBits_ubgsi9.val.Data.FPStorage.field_0;
							Struct_fiz2nb struct_fiz2nb17 = struct_fiz2nb16;
							((Struct_fiz2nb*)ptr4)->field_0 = struct_fiz2nb17.field_0;
							Struct_fiz2nb struct_fiz2nb18 = struct_fiz2nb16;
							((Struct_fiz2nb*)ptr4)->field_1 = struct_fiz2nb18.field_1;
							llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepImpl_jrxud13, &fputil_FPBits_ubgsi9, 16L, isVolatile: false);
							bool num6 = internal_Equals_jif2sf.Invoke(*(long*)(&fputil_internal_FPRepImpl_jrxud12), ((long*)(&fputil_internal_FPRepImpl_jrxud12))[1], *(long*)(&fputil_internal_FPRepImpl_jrxud13), ((long*)(&fputil_internal_FPRepImpl_jrxud13))[1]);
							llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi9);
							if (num6)
							{
								llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi10);
								llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb12, Sign_NEG.Pointer, 1L, isVolatile: false);
								Struct_fiz2nb struct_fiz2nb19 = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_max_subnormal.Invoke(anon_izyfb12.val);
								Int128* ptr5 = &fputil_FPBits_ubgsi10.val.Data.FPStorage.field_0;
								Struct_fiz2nb struct_fiz2nb20 = struct_fiz2nb19;
								((Struct_fiz2nb*)ptr5)->field_0 = struct_fiz2nb20.field_0;
								Struct_fiz2nb struct_fiz2nb21 = struct_fiz2nb19;
								((Struct_fiz2nb*)ptr5)->field_1 = struct_fiz2nb21.field_1;
								llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi3, &fputil_FPBits_ubgsi10, 16L, isVolatile: false);
								llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi10);
							}
							else
							{
								Struct_fiz2nb struct_fiz2nb22 = FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_mantissa.Invoke(&fputil_FPBits_ubgsi3);
								Int128* num7 = &x3;
								Struct_fiz2nb struct_fiz2nb23 = struct_fiz2nb22;
								*(long*)num7 = struct_fiz2nb23.field_0;
								byte* num8 = (byte*)(&x3) + 8u;
								Struct_fiz2nb struct_fiz2nb24 = struct_fiz2nb22;
								*(long*)num8 = struct_fiz2nb24.field_1;
								if (NumericHelper.IntCmpEq(x3, 0L))
								{
									int6 = long.MaxValue;
									FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_set_mantissa.Invoke(&fputil_FPBits_ubgsi3, *(long*)(&int6), ((long*)(&int6))[1]);
									checked
									{
										int7 = unchecked((ushort)FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_biased_exponent.Invoke(&fputil_FPBits_ubgsi3)) - 1;
									}
									FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_set_biased_exponent.Invoke(&fputil_FPBits_ubgsi3, *(long*)(&int7), ((long*)(&int7))[1]);
									result = FPBits_long_double_get_val.Invoke(&fputil_FPBits_ubgsi3);
									goto IL_0e75;
								}
								llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi11);
								Struct_fiz2nb struct_fiz2nb25 = FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_uintval.Invoke(&fputil_FPBits_ubgsi3);
								Int128* num9 = &x4;
								Struct_fiz2nb struct_fiz2nb26 = struct_fiz2nb25;
								*(long*)num9 = struct_fiz2nb26.field_0;
								byte* num10 = (byte*)(&x4) + 8u;
								Struct_fiz2nb struct_fiz2nb27 = struct_fiz2nb25;
								*(long*)num10 = struct_fiz2nb27.field_1;
								int8 = NumericHelper.Subtract(x4, 1L);
								FPBits_long_double_FPBits_unsigned_int128.Invoke(&fputil_FPBits_ubgsi11, *(long*)(&int8), ((long*)(&int8))[1]);
								llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi3, &fputil_FPBits_ubgsi11, 16L, isVolatile: false);
								llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi11);
							}
						}
					}
					else if (to < from)
					{
						llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepImpl_jrxud14, &fputil_FPBits_ubgsi3, 16L, isVolatile: false);
						llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi12);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb13, Sign_POS.Pointer, 1L, isVolatile: false);
						Struct_fiz2nb struct_fiz2nb28 = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_min_normal.Invoke(anon_izyfb13.val);
						Int128* ptr6 = &fputil_FPBits_ubgsi12.val.Data.FPStorage.field_0;
						Struct_fiz2nb struct_fiz2nb29 = struct_fiz2nb28;
						((Struct_fiz2nb*)ptr6)->field_0 = struct_fiz2nb29.field_0;
						Struct_fiz2nb struct_fiz2nb30 = struct_fiz2nb28;
						((Struct_fiz2nb*)ptr6)->field_1 = struct_fiz2nb30.field_1;
						llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepImpl_jrxud15, &fputil_FPBits_ubgsi12, 16L, isVolatile: false);
						bool num11 = internal_Equals_jif2sf.Invoke(*(long*)(&fputil_internal_FPRepImpl_jrxud14), ((long*)(&fputil_internal_FPRepImpl_jrxud14))[1], *(long*)(&fputil_internal_FPRepImpl_jrxud15), ((long*)(&fputil_internal_FPRepImpl_jrxud15))[1]);
						llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi12);
						if (num11)
						{
							llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi13);
							llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb14, Sign_POS.Pointer, 1L, isVolatile: false);
							Struct_fiz2nb struct_fiz2nb31 = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_max_subnormal.Invoke(anon_izyfb14.val);
							Int128* ptr7 = &fputil_FPBits_ubgsi13.val.Data.FPStorage.field_0;
							Struct_fiz2nb struct_fiz2nb32 = struct_fiz2nb31;
							((Struct_fiz2nb*)ptr7)->field_0 = struct_fiz2nb32.field_0;
							Struct_fiz2nb struct_fiz2nb33 = struct_fiz2nb31;
							((Struct_fiz2nb*)ptr7)->field_1 = struct_fiz2nb33.field_1;
							llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi3, &fputil_FPBits_ubgsi13, 16L, isVolatile: false);
							llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi13);
						}
						else
						{
							Struct_fiz2nb struct_fiz2nb34 = FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_mantissa.Invoke(&fputil_FPBits_ubgsi3);
							Int128* num12 = &x5;
							Struct_fiz2nb struct_fiz2nb35 = struct_fiz2nb34;
							*(long*)num12 = struct_fiz2nb35.field_0;
							byte* num13 = (byte*)(&x5) + 8u;
							Struct_fiz2nb struct_fiz2nb36 = struct_fiz2nb34;
							*(long*)num13 = struct_fiz2nb36.field_1;
							if (NumericHelper.IntCmpEq(x5, 0L))
							{
								int9 = long.MaxValue;
								FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_set_mantissa.Invoke(&fputil_FPBits_ubgsi3, *(long*)(&int9), ((long*)(&int9))[1]);
								checked
								{
									int10 = unchecked((ushort)FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_biased_exponent.Invoke(&fputil_FPBits_ubgsi3)) - 1;
								}
								FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_set_biased_exponent.Invoke(&fputil_FPBits_ubgsi3, *(long*)(&int10), ((long*)(&int10))[1]);
								result = FPBits_long_double_get_val.Invoke(&fputil_FPBits_ubgsi3);
								goto IL_0e75;
							}
							llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi14);
							Struct_fiz2nb struct_fiz2nb37 = FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_uintval.Invoke(&fputil_FPBits_ubgsi3);
							Int128* num14 = &x6;
							Struct_fiz2nb struct_fiz2nb38 = struct_fiz2nb37;
							*(long*)num14 = struct_fiz2nb38.field_0;
							byte* num15 = (byte*)(&x6) + 8u;
							Struct_fiz2nb struct_fiz2nb39 = struct_fiz2nb37;
							*(long*)num15 = struct_fiz2nb39.field_1;
							int11 = NumericHelper.Subtract(x6, 1L);
							FPBits_long_double_FPBits_unsigned_int128.Invoke(&fputil_FPBits_ubgsi14, *(long*)(&int11), ((long*)(&int11))[1]);
							llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi3, &fputil_FPBits_ubgsi14, 16L, isVolatile: false);
							llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi14);
						}
					}
					else
					{
						llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepImpl_jrxud16, &fputil_FPBits_ubgsi3, 16L, isVolatile: false);
						llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi15);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb15, Sign_POS.Pointer, 1L, isVolatile: false);
						Struct_fiz2nb struct_fiz2nb40 = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_max_subnormal.Invoke(anon_izyfb15.val);
						Int128* ptr8 = &fputil_FPBits_ubgsi15.val.Data.FPStorage.field_0;
						Struct_fiz2nb struct_fiz2nb41 = struct_fiz2nb40;
						((Struct_fiz2nb*)ptr8)->field_0 = struct_fiz2nb41.field_0;
						Struct_fiz2nb struct_fiz2nb42 = struct_fiz2nb40;
						((Struct_fiz2nb*)ptr8)->field_1 = struct_fiz2nb42.field_1;
						llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepImpl_jrxud17, &fputil_FPBits_ubgsi15, 16L, isVolatile: false);
						bool num16 = internal_Equals_jif2sf.Invoke(*(long*)(&fputil_internal_FPRepImpl_jrxud16), ((long*)(&fputil_internal_FPRepImpl_jrxud16))[1], *(long*)(&fputil_internal_FPRepImpl_jrxud17), ((long*)(&fputil_internal_FPRepImpl_jrxud17))[1]);
						llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi15);
						if (num16)
						{
							llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi16);
							llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb16, Sign_POS.Pointer, 1L, isVolatile: false);
							Struct_fiz2nb struct_fiz2nb43 = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_min_normal.Invoke(anon_izyfb16.val);
							Int128* ptr9 = &fputil_FPBits_ubgsi16.val.Data.FPStorage.field_0;
							Struct_fiz2nb struct_fiz2nb44 = struct_fiz2nb43;
							((Struct_fiz2nb*)ptr9)->field_0 = struct_fiz2nb44.field_0;
							Struct_fiz2nb struct_fiz2nb45 = struct_fiz2nb43;
							((Struct_fiz2nb*)ptr9)->field_1 = struct_fiz2nb45.field_1;
							llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi3, &fputil_FPBits_ubgsi16, 16L, isVolatile: false);
							llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi16);
						}
						else
						{
							Struct_fiz2nb struct_fiz2nb46 = FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_mantissa.Invoke(&fputil_FPBits_ubgsi3);
							Int128* num17 = &x7;
							Struct_fiz2nb struct_fiz2nb47 = struct_fiz2nb46;
							*(long*)num17 = struct_fiz2nb47.field_0;
							byte* num18 = (byte*)(&x7) + 8u;
							Struct_fiz2nb struct_fiz2nb48 = struct_fiz2nb46;
							*(long*)num18 = struct_fiz2nb48.field_1;
							if (NumericHelper.IntCmpEq(x7, long.MaxValue))
							{
								int12 = 0L;
								FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_set_mantissa.Invoke(&fputil_FPBits_ubgsi3, *(long*)(&int12), ((long*)(&int12))[1]);
								checked
								{
									int13 = unchecked((ushort)FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_biased_exponent.Invoke(&fputil_FPBits_ubgsi3)) + 1;
								}
								FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_set_biased_exponent.Invoke(&fputil_FPBits_ubgsi3, *(long*)(&int13), ((long*)(&int13))[1]);
								if (FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_inf.Invoke(&fputil_FPBits_ubgsi3))
								{
									fputil_raise_except_if_required.Invoke(40);
								}
								result = FPBits_long_double_get_val.Invoke(&fputil_FPBits_ubgsi3);
								goto IL_0e75;
							}
							llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi17);
							Struct_fiz2nb struct_fiz2nb49 = FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_uintval.Invoke(&fputil_FPBits_ubgsi3);
							Int128* num19 = &x8;
							Struct_fiz2nb struct_fiz2nb50 = struct_fiz2nb49;
							*(long*)num19 = struct_fiz2nb50.field_0;
							byte* num20 = (byte*)(&x8) + 8u;
							Struct_fiz2nb struct_fiz2nb51 = struct_fiz2nb49;
							*(long*)num20 = struct_fiz2nb51.field_1;
							int14 = NumericHelper.Add(x8, 1L);
							FPBits_long_double_FPBits_unsigned_int128.Invoke(&fputil_FPBits_ubgsi17, *(long*)(&int14), ((long*)(&int14))[1]);
							llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi3, &fputil_FPBits_ubgsi17, 16L, isVolatile: false);
							llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi17);
						}
					}
					if (!FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_get_implicit_bit.Invoke(&fputil_FPBits_ubgsi3))
					{
						fputil_raise_except_if_required.Invoke(48);
					}
					result = FPBits_long_double_get_val.Invoke(&fputil_FPBits_ubgsi3);
					goto IL_0e75;
				}
				result = to;
			}
			goto IL_0e87;
		}
		IL_0e99:
		llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		return result;
		IL_0e87:
		llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
		goto IL_0e99;
		IL_0e75:
		llvm_lifetime_end_p0.Invoke(16L, &int2);
		goto IL_0e87;
	}
}
