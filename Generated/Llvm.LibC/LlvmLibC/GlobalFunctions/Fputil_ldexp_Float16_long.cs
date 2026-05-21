using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_ldexp_Float16_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil5ldexpIDF16_lEENS_3cpp9enable_ifIXaasr3cppE19is_floating_point_vIT_Esr3cppE13is_integral_vIT0_EES4_E4typeES4_S5_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16> && cpp::is_integral_v<long>, _Float16>::type __llvm_libc_20_1_2_::fputil::ldexp<_Float16, long>(_Float16, long)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16> && cpp::is_integral_v<long>, _Float16>::type")]
	public unsafe static Half Invoke([MangledName("x")][NativeType("_Float16")] Half X, [MangledName("exp")][NativeType("long")] long Exp)
	{
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		int num = 0;
		int num2 = 0;
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb4 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb5 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva2 = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb6 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva3 = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb7 = default(Anon_izyfb7);
		int num3 = 0;
		Anon_izyfb7 anon_izyfb8 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb9 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb10 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb11 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb12 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva4 = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb13 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva5 = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb14 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_DyadicFloat_jvghxm llvm_libc_20_1_2_fputil_DyadicFloat_jvghxm = default(Llvm_libc_20_1_2_fputil_DyadicFloat_jvghxm);
		Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva);
		Half result;
		unchecked
		{
			*(short*)(&llvm_libc_20_1_2_fputil_FPBits_2fahva) = -21846;
			FPBits_Float16_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva, X);
			if (Details_expects_bool_condition_bool.Invoke((Exp == 0L) ? true : ((!FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_zero.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_i7nz4h*)(&llvm_libc_20_1_2_fputil_FPBits_2fahva))) ? FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_is_inf_or_nan.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_7z3gh9*)(&llvm_libc_20_1_2_fputil_FPBits_2fahva)) : true), Expected: false))
			{
				result = X;
				goto IL_05c3;
			}
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = 42;
			if (Details_expects_bool_condition_bool.Invoke(Exp > 42L, Expected: false))
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num2);
				num2 = Fputil_quick_get_round.Invoke();
				Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb);
				*(sbyte*)(&anon_izyfb) = -86;
				anon_izyfb.Val = FPStorage_fputil_FPType_0_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, &anon_izyfb, 1L, isVolatile: false);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb3, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
				if (!Llvm_libc_20_1_2_Equals_fy8fvt.Invoke(anon_izyfb2.Val, anon_izyfb3.Val) || num2 != 1024)
				{
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb4, &anon_izyfb, 1L, isVolatile: false);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb5, Llvm_libc_20_1_2_Sign_NEG.Pointer, 1L, isVolatile: false);
					if ((!Llvm_libc_20_1_2_Equals_fy8fvt.Invoke(anon_izyfb4.Val, anon_izyfb5.Val) || num2 != 2048) && num2 != 3072)
					{
						Fputil_set_errno_if_required.Invoke(34);
						Fputil_raise_except_if_required.Invoke(8);
						Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva3);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb7, &anon_izyfb, 1L, isVolatile: false);
						short field_ = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_inf.Invoke(anon_izyfb7.Val);
						llvm_libc_20_1_2_fputil_FPBits_2fahva3.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
						result = FPBits_Float16_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva3);
						Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva3);
						goto IL_02f7;
					}
				}
				Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva2);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb6, &anon_izyfb, 1L, isVolatile: false);
				short field_2 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_max_normal.Invoke(anon_izyfb6.Val);
				llvm_libc_20_1_2_fputil_FPBits_2fahva2.FPRepImpl.FPRepSem.FPStorage.field_0 = field_2;
				result = FPBits_Float16_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva2);
				Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva2);
				goto IL_02f7;
			}
			if (Details_expects_bool_condition_bool.Invoke(Exp < -42L, Expected: false))
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = Fputil_quick_get_round.Invoke();
				Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb8);
				*(sbyte*)(&anon_izyfb8) = -86;
				anon_izyfb8.Val = FPStorage_fputil_FPType_0_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, &anon_izyfb8, 1L, isVolatile: false);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
				if (!Llvm_libc_20_1_2_Equals_fy8fvt.Invoke(anon_izyfb9.Val, anon_izyfb10.Val) || num3 != 2048)
				{
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb11, &anon_izyfb8, 1L, isVolatile: false);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb12, Llvm_libc_20_1_2_Sign_NEG.Pointer, 1L, isVolatile: false);
					if (!Llvm_libc_20_1_2_Equals_fy8fvt.Invoke(anon_izyfb11.Val, anon_izyfb12.Val) || num3 != 1024)
					{
						Fputil_set_errno_if_required.Invoke(34);
						Fputil_raise_except_if_required.Invoke(16);
						Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva5);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb14, &anon_izyfb8, 1L, isVolatile: false);
						short field_3 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_zero.Invoke(anon_izyfb14.Val);
						llvm_libc_20_1_2_fputil_FPBits_2fahva5.FPRepImpl.FPRepSem.FPStorage.field_0 = field_3;
						result = FPBits_Float16_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva5);
						Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva5);
						goto IL_04e4;
					}
				}
				Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva4);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb13, &anon_izyfb8, 1L, isVolatile: false);
				short field_4 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_min_subnormal.Invoke(anon_izyfb13.Val);
				llvm_libc_20_1_2_fputil_FPBits_2fahva4.FPRepImpl.FPRepSem.FPStorage.field_0 = field_4;
				result = FPBits_Float16_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva4);
				Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva4);
				goto IL_04e4;
			}
			Llvm_lifetime_start_p0.Invoke(12L, &llvm_libc_20_1_2_fputil_DyadicFloat_jvghxm);
			*(sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_jvghxm) = -86;
			sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_jvghxm) + 1;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			((int*)(&llvm_libc_20_1_2_fputil_DyadicFloat_jvghxm))[1] = -1431655766;
			((short*)(&llvm_libc_20_1_2_fputil_DyadicFloat_jvghxm))[4] = -21846;
			sbyte* ptr2 = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_jvghxm) + 10;
			*ptr2 = -86;
			ptr2[1] = -86;
			DyadicFloat_16ul_DyadicFloat_Float16_0.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_jvghxm, FPBits_Float16_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva));
		}
		llvm_libc_20_1_2_fputil_DyadicFloat_jvghxm.Exponent += unchecked((int)Exp);
		result = DyadicFloat_16ul_as_Float16_true_void.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_jvghxm);
		Llvm_lifetime_end_p0.Invoke(12L, &llvm_libc_20_1_2_fputil_DyadicFloat_jvghxm);
		goto IL_05b1;
		IL_02f7:
		Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb);
		Llvm_lifetime_end_p0.Invoke(4L, &num2);
		goto IL_05b1;
		IL_04e4:
		Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
		Llvm_lifetime_end_p0.Invoke(4L, &num3);
		goto IL_05b1;
		IL_05c3:
		Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva);
		return result;
		IL_05b1:
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		goto IL_05c3;
	}
}
