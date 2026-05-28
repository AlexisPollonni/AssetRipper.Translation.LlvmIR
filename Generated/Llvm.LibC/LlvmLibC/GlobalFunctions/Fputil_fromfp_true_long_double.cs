using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_fromfp_true_long_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil6fromfpILb1EeEENS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT0_EES4_E4typeES4_ij")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<long double>, long double>::type __llvm_libc_20_1_2_::fputil::fromfp<true, long double>(long double, int, unsigned int)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<long double>, long double>::type")]
	public unsafe static double Invoke([MangledName("x")][NativeType("long double")] double X, [MangledName("rnd")][NativeType("int")] int Rnd, [MangledName("width")][NativeType("unsigned int")] int Width)
	{
		Int128 @int = default(Int128);
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi = default(Fputil_FPBits_ubgsi2);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Int128 int2 = default(Int128);
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi2 = default(Fputil_FPBits_ubgsi2);
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(Fputil_FPBits_ubgsi2);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Int128 int3 = default(Int128);
		double num = 0.0;
		Int128 int4 = default(Int128);
		double num2 = 0.0;
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi4 = default(Fputil_FPBits_ubgsi2);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		Int128 int5 = default(Int128);
		Int128 int6 = default(Int128);
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi5 = default(Fputil_FPBits_ubgsi2);
		Anon_izyfb7 anon_izyfb4 = default(Anon_izyfb7);
		Int128 int7 = default(Int128);
		double num3 = 0.0;
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi6 = default(Fputil_FPBits_ubgsi2);
		Anon_izyfb7 anon_izyfb5 = default(Anon_izyfb7);
		Int128 int8 = default(Int128);
		Int128 int9 = default(Int128);
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi7 = default(Fputil_FPBits_ubgsi2);
		Anon_izyfb7 anon_izyfb6 = default(Anon_izyfb7);
		Int128 int10 = default(Int128);
		Llvm_lifetime_start_p0.Invoke(16L, &@int);
		@int = long.MinValue;
		unchecked
		{
			double result;
			if (Width == 0)
			{
				Fputil_raise_except_if_required.Invoke(1);
				Llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Sign_POS.Pointer, 1L, isVolatile: false);
				sbyte val = anon_izyfb.Val;
				int2 = 0L;
				Struct_fiz2nb struct_fiz2nb = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_quiet_nan.Invoke(val, *(long*)(&int2), ((long*)(&int2))[1]);
				Int128* ptr = &fputil_FPBits_ubgsi.Val.Data.FPStorage.field_0;
				Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
				((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb2.field_0;
				Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
				((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb3.field_1;
				result = FPBits_long_double_get_val.Invoke(&fputil_FPBits_ubgsi);
				Llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi);
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi2);
				*(Int128*)(&fputil_FPBits_ubgsi2) = -6148914691236517206L;
				FPBits_long_double_Constructor.Invoke(&fputil_FPBits_ubgsi2, X);
				if (FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_is_inf_or_nan.Invoke(&fputil_FPBits_ubgsi2))
				{
					Fputil_raise_except_if_required.Invoke(1);
					Llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, Sign_POS.Pointer, 1L, isVolatile: false);
					sbyte val2 = anon_izyfb2.Val;
					int3 = 0L;
					Struct_fiz2nb struct_fiz2nb4 = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_quiet_nan.Invoke(val2, *(long*)(&int3), ((long*)(&int3))[1]);
					Int128* ptr2 = &fputil_FPBits_ubgsi3.Val.Data.FPStorage.field_0;
					Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
					((Struct_fiz2nb*)ptr2)->field_0 = struct_fiz2nb5.field_0;
					Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
					((Struct_fiz2nb*)ptr2)->field_1 = struct_fiz2nb6.field_1;
					result = FPBits_long_double_get_val.Invoke(&fputil_FPBits_ubgsi3);
					Llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(16L, &num);
					num = Fputil_round_using_specific_rounding_mode_long_double.Invoke(X, Rnd);
					if ((uint)(Width - 1) > 16383u)
					{
						result = num;
					}
					else
					{
						Llvm_lifetime_start_p0.Invoke(16L, &int4);
						int4 = (Int128)(UInt128)(uint)(Width - 1 + 16383);
						Llvm_lifetime_start_p0.Invoke(16L, &num2);
						Llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb3, Sign_NEG.Pointer, 1L, isVolatile: false);
						Int128 int11 = int4;
						sbyte val3 = anon_izyfb3.Val;
						int5 = int11;
						long biased_exp = *(long*)(&int5);
						long mantissa = ((long*)(&int5))[1];
						int6 = long.MinValue;
						Struct_fiz2nb struct_fiz2nb7 = FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_create_value.Invoke(val3, biased_exp, mantissa, *(long*)(&int6), ((long*)(&int6))[1]);
						Int128* ptr3 = &fputil_FPBits_ubgsi4.Val.Data.FPStorage.field_0;
						Struct_fiz2nb struct_fiz2nb8 = struct_fiz2nb7;
						((Struct_fiz2nb*)ptr3)->field_0 = struct_fiz2nb8.field_0;
						Struct_fiz2nb struct_fiz2nb9 = struct_fiz2nb7;
						((Struct_fiz2nb*)ptr3)->field_1 = struct_fiz2nb9.field_1;
						double num4 = FPBits_long_double_get_val.Invoke(&fputil_FPBits_ubgsi4);
						Llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
						num2 = num4;
						if (num < num2)
						{
							Fputil_raise_except_if_required.Invoke(1);
							Llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi5);
							Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb4, Sign_POS.Pointer, 1L, isVolatile: false);
							sbyte val4 = anon_izyfb4.Val;
							int7 = 0L;
							Struct_fiz2nb struct_fiz2nb10 = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_quiet_nan.Invoke(val4, *(long*)(&int7), ((long*)(&int7))[1]);
							Int128* ptr4 = &fputil_FPBits_ubgsi5.Val.Data.FPStorage.field_0;
							Struct_fiz2nb struct_fiz2nb11 = struct_fiz2nb10;
							((Struct_fiz2nb*)ptr4)->field_0 = struct_fiz2nb11.field_0;
							Struct_fiz2nb struct_fiz2nb12 = struct_fiz2nb10;
							((Struct_fiz2nb*)ptr4)->field_1 = struct_fiz2nb12.field_1;
							result = FPBits_long_double_get_val.Invoke(&fputil_FPBits_ubgsi5);
							Llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi5);
						}
						else
						{
							Llvm_lifetime_start_p0.Invoke(16L, &num3);
							Llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi6);
							Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb5, Sign_POS.Pointer, 1L, isVolatile: false);
							Int128 int12 = int4;
							sbyte val5 = anon_izyfb5.Val;
							int8 = int12;
							long biased_exp2 = *(long*)(&int8);
							long mantissa2 = ((long*)(&int8))[1];
							int9 = long.MinValue;
							Struct_fiz2nb struct_fiz2nb13 = FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_create_value.Invoke(val5, biased_exp2, mantissa2, *(long*)(&int9), ((long*)(&int9))[1]);
							Int128* ptr5 = &fputil_FPBits_ubgsi6.Val.Data.FPStorage.field_0;
							Struct_fiz2nb struct_fiz2nb14 = struct_fiz2nb13;
							((Struct_fiz2nb*)ptr5)->field_0 = struct_fiz2nb14.field_0;
							Struct_fiz2nb struct_fiz2nb15 = struct_fiz2nb13;
							((Struct_fiz2nb*)ptr5)->field_1 = struct_fiz2nb15.field_1;
							double num5 = FPBits_long_double_get_val.Invoke(&fputil_FPBits_ubgsi6) - 1.0;
							Llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi6);
							num3 = num5;
							if (num > num3)
							{
								Fputil_raise_except_if_required.Invoke(1);
								Llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi7);
								Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb6, Sign_POS.Pointer, 1L, isVolatile: false);
								sbyte val6 = anon_izyfb6.Val;
								int10 = 0L;
								Struct_fiz2nb struct_fiz2nb16 = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_quiet_nan.Invoke(val6, *(long*)(&int10), ((long*)(&int10))[1]);
								Int128* ptr6 = &fputil_FPBits_ubgsi7.Val.Data.FPStorage.field_0;
								Struct_fiz2nb struct_fiz2nb17 = struct_fiz2nb16;
								((Struct_fiz2nb*)ptr6)->field_0 = struct_fiz2nb17.field_0;
								Struct_fiz2nb struct_fiz2nb18 = struct_fiz2nb16;
								((Struct_fiz2nb*)ptr6)->field_1 = struct_fiz2nb18.field_1;
								result = FPBits_long_double_get_val.Invoke(&fputil_FPBits_ubgsi7);
								Llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi7);
							}
							else
							{
								result = num;
							}
							Llvm_lifetime_end_p0.Invoke(16L, &num3);
						}
						Llvm_lifetime_end_p0.Invoke(16L, &num2);
						Llvm_lifetime_end_p0.Invoke(16L, &int4);
					}
					Llvm_lifetime_end_p0.Invoke(16L, &num);
				}
				Llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi2);
			}
			Llvm_lifetime_end_p0.Invoke(16L, &@int);
			return result;
		}
	}
}
