using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_ldexp_long_double_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil5ldexpIelEENS_3cpp9enable_ifIXaasr3cppE19is_floating_point_vIT_Esr3cppE13is_integral_vIT0_EES4_E4typeES4_S5_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<long double> && cpp::is_integral_v<long>, long double>::type __llvm_libc_20_1_2_::fputil::ldexp<long double, long>(long double, long)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<long double> && cpp::is_integral_v<long>, long double>::type")]
	public unsafe static double Invoke([MangledName("x")][NativeType("long double")] double X, [MangledName("exp")][NativeType("long")] long Exp)
	{
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi = default(Fputil_FPBits_ubgsi2);
		int num = 0;
		int num2 = 0;
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb4 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb5 = default(Anon_izyfb7);
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi2 = default(Fputil_FPBits_ubgsi2);
		Anon_izyfb7 anon_izyfb6 = default(Anon_izyfb7);
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(Fputil_FPBits_ubgsi2);
		Anon_izyfb7 anon_izyfb7 = default(Anon_izyfb7);
		int num3 = 0;
		Anon_izyfb7 anon_izyfb8 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb9 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb10 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb11 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb12 = default(Anon_izyfb7);
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi4 = default(Fputil_FPBits_ubgsi2);
		Anon_izyfb7 anon_izyfb13 = default(Anon_izyfb7);
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi5 = default(Fputil_FPBits_ubgsi2);
		Anon_izyfb7 anon_izyfb14 = default(Anon_izyfb7);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd = default(Fputil_DyadicFloat_kt2kd4);
		Llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi);
		double result;
		unchecked
		{
			*(Int128*)(&fputil_FPBits_ubgsi) = -6148914691236517206L;
			FPBits_long_double_Constructor.Invoke(&fputil_FPBits_ubgsi, X);
			if (Details_expects_bool_condition_bool.Invoke(Exp == 0L || FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_zero.Invoke(&fputil_FPBits_ubgsi) || FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_is_inf_or_nan.Invoke(&fputil_FPBits_ubgsi), Expected: false))
			{
				result = X;
				goto IL_0675;
			}
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = 32831;
			if (Details_expects_bool_condition_bool.Invoke(Exp > 32831L, Expected: false))
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num2);
				num2 = Fputil_quick_get_round.Invoke();
				Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb);
				*(sbyte*)(&anon_izyfb) = -86;
				anon_izyfb.Val = FPStorage_fputil_FPType_4_sign.Invoke(&fputil_FPBits_ubgsi);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, &anon_izyfb, 1L, isVolatile: false);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb3, Sign_POS.Pointer, 1L, isVolatile: false);
				if (!Equals_fy8fvt.Invoke(anon_izyfb2.Val, anon_izyfb3.Val) || num2 != 1024)
				{
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb4, &anon_izyfb, 1L, isVolatile: false);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb5, Sign_NEG.Pointer, 1L, isVolatile: false);
					if ((!Equals_fy8fvt.Invoke(anon_izyfb4.Val, anon_izyfb5.Val) || num2 != 2048) && num2 != 3072)
					{
						Fputil_set_errno_if_required.Invoke(34);
						Fputil_raise_except_if_required.Invoke(8);
						Llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb7, &anon_izyfb, 1L, isVolatile: false);
						Struct_fiz2nb struct_fiz2nb = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_inf.Invoke(anon_izyfb7.Val);
						Int128* ptr = &fputil_FPBits_ubgsi3.Val.Data.FPStorage.field_0;
						Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
						((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb2.field_0;
						Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
						((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb3.field_1;
						result = FPBits_long_double_get_val.Invoke(&fputil_FPBits_ubgsi3);
						Llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
						goto IL_0357;
					}
				}
				Llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi2);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb6, &anon_izyfb, 1L, isVolatile: false);
				Struct_fiz2nb struct_fiz2nb4 = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_max_normal.Invoke(anon_izyfb6.Val);
				Int128* ptr2 = &fputil_FPBits_ubgsi2.Val.Data.FPStorage.field_0;
				Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
				((Struct_fiz2nb*)ptr2)->field_0 = struct_fiz2nb5.field_0;
				Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
				((Struct_fiz2nb*)ptr2)->field_1 = struct_fiz2nb6.field_1;
				result = FPBits_long_double_get_val.Invoke(&fputil_FPBits_ubgsi2);
				Llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi2);
				goto IL_0357;
			}
			if (Details_expects_bool_condition_bool.Invoke(Exp < -32831L, Expected: false))
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = Fputil_quick_get_round.Invoke();
				Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb8);
				*(sbyte*)(&anon_izyfb8) = -86;
				anon_izyfb8.Val = FPStorage_fputil_FPType_4_sign.Invoke(&fputil_FPBits_ubgsi);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, &anon_izyfb8, 1L, isVolatile: false);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, Sign_POS.Pointer, 1L, isVolatile: false);
				if (!Equals_fy8fvt.Invoke(anon_izyfb9.Val, anon_izyfb10.Val) || num3 != 2048)
				{
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb11, &anon_izyfb8, 1L, isVolatile: false);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb12, Sign_NEG.Pointer, 1L, isVolatile: false);
					if (!Equals_fy8fvt.Invoke(anon_izyfb11.Val, anon_izyfb12.Val) || num3 != 1024)
					{
						Fputil_set_errno_if_required.Invoke(34);
						Fputil_raise_except_if_required.Invoke(16);
						Llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi5);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb14, &anon_izyfb8, 1L, isVolatile: false);
						Struct_fiz2nb struct_fiz2nb7 = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_zero.Invoke(anon_izyfb14.Val);
						Int128* ptr3 = &fputil_FPBits_ubgsi5.Val.Data.FPStorage.field_0;
						Struct_fiz2nb struct_fiz2nb8 = struct_fiz2nb7;
						((Struct_fiz2nb*)ptr3)->field_0 = struct_fiz2nb8.field_0;
						Struct_fiz2nb struct_fiz2nb9 = struct_fiz2nb7;
						((Struct_fiz2nb*)ptr3)->field_1 = struct_fiz2nb9.field_1;
						result = FPBits_long_double_get_val.Invoke(&fputil_FPBits_ubgsi5);
						Llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi5);
						goto IL_0595;
					}
				}
				Llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb13, &anon_izyfb8, 1L, isVolatile: false);
				Struct_fiz2nb struct_fiz2nb10 = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_min_subnormal.Invoke(anon_izyfb13.Val);
				Int128* ptr4 = &fputil_FPBits_ubgsi4.Val.Data.FPStorage.field_0;
				Struct_fiz2nb struct_fiz2nb11 = struct_fiz2nb10;
				((Struct_fiz2nb*)ptr4)->field_0 = struct_fiz2nb11.field_0;
				Struct_fiz2nb struct_fiz2nb12 = struct_fiz2nb10;
				((Struct_fiz2nb*)ptr4)->field_1 = struct_fiz2nb12.field_1;
				result = FPBits_long_double_get_val.Invoke(&fputil_FPBits_ubgsi4);
				Llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
				goto IL_0595;
			}
			Llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd);
			*(sbyte*)(&fputil_DyadicFloat_kt2kd) = -86;
			sbyte* ptr5 = (sbyte*)(&fputil_DyadicFloat_kt2kd) + 1;
			*ptr5 = -86;
			ptr5[1] = -86;
			ptr5[2] = -86;
			((int*)(&fputil_DyadicFloat_kt2kd))[1] = -1431655766;
			sbyte* ptr6 = (sbyte*)(&fputil_DyadicFloat_kt2kd) + 8;
			*(long*)ptr6 = -6148914691236517206L;
			((long*)ptr6)[1] = -6148914691236517206L;
			DyadicFloat_128ul_DyadicFloat_long_double_0.Invoke(&fputil_DyadicFloat_kt2kd, FPBits_long_double_get_val.Invoke(&fputil_FPBits_ubgsi));
		}
		fputil_DyadicFloat_kt2kd.Exponent += unchecked((int)Exp);
		result = DyadicFloat_128ul_as_long_double_true_void.Invoke(&fputil_DyadicFloat_kt2kd);
		Llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd);
		goto IL_0663;
		IL_0357:
		Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb);
		Llvm_lifetime_end_p0.Invoke(4L, &num2);
		goto IL_0663;
		IL_0595:
		Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
		Llvm_lifetime_end_p0.Invoke(4L, &num3);
		goto IL_0663;
		IL_0675:
		Llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi);
		return result;
		IL_0663:
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		goto IL_0675;
	}
}
