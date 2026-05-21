using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_ldexp_Float16_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil5ldexpIDF16_lEENS_3cpp9enable_ifIXaasr3cppE19is_floating_point_vIT_Esr3cppE13is_integral_vIT0_EES4_E4typeES4_S5_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16> && cpp::is_integral_v<long>, _Float16>::type __llvm_libc_20_1_2_::fputil::ldexp<_Float16, long>(_Float16, long)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16> && cpp::is_integral_v<long>, _Float16>::type")]
	public unsafe static Half Invoke([NativeType("_Float16")] Half x, [NativeType("long")] long exp)
	{
		fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(fputil_FPBits_2fahva);
		int num = 0;
		int num2 = 0;
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb11 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb12 = default(anon_izyfb7);
		fputil_FPBits_2fahva fputil_FPBits_2fahva3 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb13 = default(anon_izyfb7);
		fputil_FPBits_2fahva fputil_FPBits_2fahva4 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb14 = default(anon_izyfb7);
		int num3 = 0;
		anon_izyfb7 anon_izyfb15 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb16 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb17 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb18 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb19 = default(anon_izyfb7);
		fputil_FPBits_2fahva fputil_FPBits_2fahva5 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb20 = default(anon_izyfb7);
		fputil_FPBits_2fahva fputil_FPBits_2fahva6 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb21 = default(anon_izyfb7);
		fputil_DyadicFloat_jvghxm fputil_DyadicFloat_jvghxm2 = default(fputil_DyadicFloat_jvghxm);
		llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
		Half result;
		unchecked
		{
			*(short*)(&fputil_FPBits_2fahva2) = -21846;
			FPBits_Float16_Constructor.Invoke(&fputil_FPBits_2fahva2, x);
			if (details_expects_bool_condition_bool.Invoke((exp == 0L) ? true : ((!FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_zero.Invoke((fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva2))) ? FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_is_inf_or_nan.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva2)) : true), expected: false))
			{
				result = x;
				goto IL_05c3;
			}
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = 42;
			if (details_expects_bool_condition_bool.Invoke(exp > 42L, expected: false))
			{
				llvm_lifetime_start_p0.Invoke(4L, &num2);
				num2 = fputil_quick_get_round.Invoke();
				llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb8);
				*(sbyte*)(&anon_izyfb8) = -86;
				anon_izyfb8.val = FPStorage_fputil_FPType_0_sign.Invoke(&fputil_FPBits_2fahva2);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, &anon_izyfb8, 1L, isVolatile: false);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, Sign_POS.Pointer, 1L, isVolatile: false);
				if (!Equals_fy8fvt.Invoke(anon_izyfb9.val, anon_izyfb10.val) || num2 != 1024)
				{
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb11, &anon_izyfb8, 1L, isVolatile: false);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb12, Sign_NEG.Pointer, 1L, isVolatile: false);
					if ((!Equals_fy8fvt.Invoke(anon_izyfb11.val, anon_izyfb12.val) || num2 != 2048) && num2 != 3072)
					{
						fputil_set_errno_if_required.Invoke(34);
						fputil_raise_except_if_required.Invoke(8);
						llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva4);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb14, &anon_izyfb8, 1L, isVolatile: false);
						short field_ = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_inf.Invoke(anon_izyfb14.val);
						fputil_FPBits_2fahva4.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
						result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva4);
						llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva4);
						goto IL_02f7;
					}
				}
				llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva3);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb13, &anon_izyfb8, 1L, isVolatile: false);
				short field_2 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_max_normal.Invoke(anon_izyfb13.val);
				fputil_FPBits_2fahva3.FPRepImpl.FPRepSem.FPStorage.field_0 = field_2;
				result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva3);
				llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva3);
				goto IL_02f7;
			}
			if (details_expects_bool_condition_bool.Invoke(exp < -42L, expected: false))
			{
				llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = fputil_quick_get_round.Invoke();
				llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb15);
				*(sbyte*)(&anon_izyfb15) = -86;
				anon_izyfb15.val = FPStorage_fputil_FPType_0_sign.Invoke(&fputil_FPBits_2fahva2);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb16, &anon_izyfb15, 1L, isVolatile: false);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb17, Sign_POS.Pointer, 1L, isVolatile: false);
				if (!Equals_fy8fvt.Invoke(anon_izyfb16.val, anon_izyfb17.val) || num3 != 2048)
				{
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb18, &anon_izyfb15, 1L, isVolatile: false);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb19, Sign_NEG.Pointer, 1L, isVolatile: false);
					if (!Equals_fy8fvt.Invoke(anon_izyfb18.val, anon_izyfb19.val) || num3 != 1024)
					{
						fputil_set_errno_if_required.Invoke(34);
						fputil_raise_except_if_required.Invoke(16);
						llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva6);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb21, &anon_izyfb15, 1L, isVolatile: false);
						short field_3 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_zero.Invoke(anon_izyfb21.val);
						fputil_FPBits_2fahva6.FPRepImpl.FPRepSem.FPStorage.field_0 = field_3;
						result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva6);
						llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva6);
						goto IL_04e4;
					}
				}
				llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva5);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb20, &anon_izyfb15, 1L, isVolatile: false);
				short field_4 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_min_subnormal.Invoke(anon_izyfb20.val);
				fputil_FPBits_2fahva5.FPRepImpl.FPRepSem.FPStorage.field_0 = field_4;
				result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva5);
				llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva5);
				goto IL_04e4;
			}
			llvm_lifetime_start_p0.Invoke(12L, &fputil_DyadicFloat_jvghxm2);
			*(sbyte*)(&fputil_DyadicFloat_jvghxm2) = -86;
			sbyte* ptr = (sbyte*)(&fputil_DyadicFloat_jvghxm2) + 1;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			((int*)(&fputil_DyadicFloat_jvghxm2))[1] = -1431655766;
			((short*)(&fputil_DyadicFloat_jvghxm2))[4] = -21846;
			sbyte* ptr2 = (sbyte*)(&fputil_DyadicFloat_jvghxm2) + 10;
			*ptr2 = -86;
			ptr2[1] = -86;
			DyadicFloat_16ul_DyadicFloat_Float16_0.Invoke(&fputil_DyadicFloat_jvghxm2, FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva2));
		}
		fputil_DyadicFloat_jvghxm2.exponent += unchecked((int)exp);
		result = DyadicFloat_16ul_as_Float16_true_void.Invoke(&fputil_DyadicFloat_jvghxm2);
		llvm_lifetime_end_p0.Invoke(12L, &fputil_DyadicFloat_jvghxm2);
		goto IL_05b1;
		IL_02f7:
		llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
		llvm_lifetime_end_p0.Invoke(4L, &num2);
		goto IL_05b1;
		IL_04e4:
		llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb15);
		llvm_lifetime_end_p0.Invoke(4L, &num3);
		goto IL_05b1;
		IL_05c3:
		llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
		return result;
		IL_05b1:
		llvm_lifetime_end_p0.Invoke(4L, &num);
		goto IL_05c3;
	}
}
