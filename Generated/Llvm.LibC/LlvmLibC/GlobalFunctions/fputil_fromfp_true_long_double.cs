using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_fromfp_true_long_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil6fromfpILb1EeEENS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT0_EES4_E4typeES4_ij")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<long double>, long double>::type __llvm_libc_20_1_2_::fputil::fromfp<true, long double>(long double, int, unsigned int)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<long double>, long double>::type")]
	public unsafe static double Invoke([NativeType("long double")] double x, [NativeType("int")] int rnd, [NativeType("unsigned int")] int width)
	{
		Int128 @int = default(Int128);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		Int128 int2 = default(Int128);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi4 = default(fputil_FPBits_ubgsi2);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi5 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		Int128 int3 = default(Int128);
		double num = 0.0;
		Int128 int4 = default(Int128);
		double num2 = 0.0;
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi6 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		Int128 int5 = default(Int128);
		Int128 int6 = default(Int128);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi7 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb11 = default(anon_izyfb7);
		Int128 int7 = default(Int128);
		double num3 = 0.0;
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi8 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb12 = default(anon_izyfb7);
		Int128 int8 = default(Int128);
		Int128 int9 = default(Int128);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi9 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb13 = default(anon_izyfb7);
		Int128 int10 = default(Int128);
		llvm_lifetime_start_p0.Invoke(16L, &@int);
		@int = long.MinValue;
		unchecked
		{
			double result;
			if (width == 0)
			{
				fputil_raise_except_if_required.Invoke(1);
				llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
				sbyte val = anon_izyfb8.val;
				int2 = 0L;
				Struct_fiz2nb struct_fiz2nb = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_quiet_nan.Invoke(val, *(long*)(&int2), ((long*)(&int2))[1]);
				Int128* ptr = &fputil_FPBits_ubgsi3.val.Data.FPStorage.field_0;
				Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
				((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb2.field_0;
				Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
				((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb3.field_1;
				result = FPBits_long_double_get_val.Invoke(&fputil_FPBits_ubgsi3);
				llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
				*(Int128*)(&fputil_FPBits_ubgsi4) = -6148914691236517206L;
				FPBits_long_double_Constructor.Invoke(&fputil_FPBits_ubgsi4, x);
				if (FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_is_inf_or_nan.Invoke(&fputil_FPBits_ubgsi4))
				{
					fputil_raise_except_if_required.Invoke(1);
					llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi5);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, Sign_POS.Pointer, 1L, isVolatile: false);
					sbyte val2 = anon_izyfb9.val;
					int3 = 0L;
					Struct_fiz2nb struct_fiz2nb4 = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_quiet_nan.Invoke(val2, *(long*)(&int3), ((long*)(&int3))[1]);
					Int128* ptr2 = &fputil_FPBits_ubgsi5.val.Data.FPStorage.field_0;
					Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
					((Struct_fiz2nb*)ptr2)->field_0 = struct_fiz2nb5.field_0;
					Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
					((Struct_fiz2nb*)ptr2)->field_1 = struct_fiz2nb6.field_1;
					result = FPBits_long_double_get_val.Invoke(&fputil_FPBits_ubgsi5);
					llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi5);
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(16L, &num);
					num = fputil_round_using_specific_rounding_mode_long_double.Invoke(x, rnd);
					if ((uint)(width - 1) > 16383u)
					{
						result = num;
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(16L, &int4);
						int4 = (Int128)(UInt128)(uint)(width - 1 + 16383);
						llvm_lifetime_start_p0.Invoke(16L, &num2);
						llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi6);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, Sign_NEG.Pointer, 1L, isVolatile: false);
						Int128 int11 = int4;
						sbyte val3 = anon_izyfb10.val;
						int5 = int11;
						long biased_exp = *(long*)(&int5);
						long mantissa = ((long*)(&int5))[1];
						int6 = long.MinValue;
						Struct_fiz2nb struct_fiz2nb7 = FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_create_value.Invoke(val3, biased_exp, mantissa, *(long*)(&int6), ((long*)(&int6))[1]);
						Int128* ptr3 = &fputil_FPBits_ubgsi6.val.Data.FPStorage.field_0;
						Struct_fiz2nb struct_fiz2nb8 = struct_fiz2nb7;
						((Struct_fiz2nb*)ptr3)->field_0 = struct_fiz2nb8.field_0;
						Struct_fiz2nb struct_fiz2nb9 = struct_fiz2nb7;
						((Struct_fiz2nb*)ptr3)->field_1 = struct_fiz2nb9.field_1;
						double num4 = FPBits_long_double_get_val.Invoke(&fputil_FPBits_ubgsi6);
						llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi6);
						num2 = num4;
						if (num < num2)
						{
							fputil_raise_except_if_required.Invoke(1);
							llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi7);
							llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb11, Sign_POS.Pointer, 1L, isVolatile: false);
							sbyte val4 = anon_izyfb11.val;
							int7 = 0L;
							Struct_fiz2nb struct_fiz2nb10 = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_quiet_nan.Invoke(val4, *(long*)(&int7), ((long*)(&int7))[1]);
							Int128* ptr4 = &fputil_FPBits_ubgsi7.val.Data.FPStorage.field_0;
							Struct_fiz2nb struct_fiz2nb11 = struct_fiz2nb10;
							((Struct_fiz2nb*)ptr4)->field_0 = struct_fiz2nb11.field_0;
							Struct_fiz2nb struct_fiz2nb12 = struct_fiz2nb10;
							((Struct_fiz2nb*)ptr4)->field_1 = struct_fiz2nb12.field_1;
							result = FPBits_long_double_get_val.Invoke(&fputil_FPBits_ubgsi7);
							llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi7);
						}
						else
						{
							llvm_lifetime_start_p0.Invoke(16L, &num3);
							llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi8);
							llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb12, Sign_POS.Pointer, 1L, isVolatile: false);
							Int128 int12 = int4;
							sbyte val5 = anon_izyfb12.val;
							int8 = int12;
							long biased_exp2 = *(long*)(&int8);
							long mantissa2 = ((long*)(&int8))[1];
							int9 = long.MinValue;
							Struct_fiz2nb struct_fiz2nb13 = FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_create_value.Invoke(val5, biased_exp2, mantissa2, *(long*)(&int9), ((long*)(&int9))[1]);
							Int128* ptr5 = &fputil_FPBits_ubgsi8.val.Data.FPStorage.field_0;
							Struct_fiz2nb struct_fiz2nb14 = struct_fiz2nb13;
							((Struct_fiz2nb*)ptr5)->field_0 = struct_fiz2nb14.field_0;
							Struct_fiz2nb struct_fiz2nb15 = struct_fiz2nb13;
							((Struct_fiz2nb*)ptr5)->field_1 = struct_fiz2nb15.field_1;
							double num5 = FPBits_long_double_get_val.Invoke(&fputil_FPBits_ubgsi8) - 1.0;
							llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi8);
							num3 = num5;
							if (num > num3)
							{
								fputil_raise_except_if_required.Invoke(1);
								llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi9);
								llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb13, Sign_POS.Pointer, 1L, isVolatile: false);
								sbyte val6 = anon_izyfb13.val;
								int10 = 0L;
								Struct_fiz2nb struct_fiz2nb16 = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_quiet_nan.Invoke(val6, *(long*)(&int10), ((long*)(&int10))[1]);
								Int128* ptr6 = &fputil_FPBits_ubgsi9.val.Data.FPStorage.field_0;
								Struct_fiz2nb struct_fiz2nb17 = struct_fiz2nb16;
								((Struct_fiz2nb*)ptr6)->field_0 = struct_fiz2nb17.field_0;
								Struct_fiz2nb struct_fiz2nb18 = struct_fiz2nb16;
								((Struct_fiz2nb*)ptr6)->field_1 = struct_fiz2nb18.field_1;
								result = FPBits_long_double_get_val.Invoke(&fputil_FPBits_ubgsi9);
								llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi9);
							}
							else
							{
								result = num;
							}
							llvm_lifetime_end_p0.Invoke(16L, &num3);
						}
						llvm_lifetime_end_p0.Invoke(16L, &num2);
						llvm_lifetime_end_p0.Invoke(16L, &int4);
					}
					llvm_lifetime_end_p0.Invoke(16L, &num);
				}
				llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
			}
			llvm_lifetime_end_p0.Invoke(16L, &@int);
			return result;
		}
	}
}
