using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil6fromfpILb1EDF16_EENS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT0_EES4_E4typeES4_ij")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16>, _Float16>::type __llvm_libc_20_1_2_::fputil::fromfp<true, _Float16>(_Float16, int, unsigned int)")]
internal static partial class cpp_enable_if_cpp_is_floating_point_v_Float16_Float16_type_fputil_fromfp_true_Float16_Float16_int_unsigned_int
{
	public unsafe static Half Invoke(Half x, int rnd, int width)
	{
		short num = 0;
		fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		fputil_FPBits_2fahva fputil_FPBits_2fahva3 = default(fputil_FPBits_2fahva);
		fputil_FPBits_2fahva fputil_FPBits_2fahva4 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		Half half = default(Half);
		short num2 = 0;
		Half y = default(Half);
		fputil_FPBits_2fahva fputil_FPBits_2fahva5 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		fputil_FPBits_2fahva fputil_FPBits_2fahva6 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb11 = default(anon_izyfb7);
		Half y2 = default(Half);
		fputil_FPBits_2fahva fputil_FPBits_2fahva7 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb12 = default(anon_izyfb7);
		fputil_FPBits_2fahva fputil_FPBits_2fahva8 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb13 = default(anon_izyfb7);
		llvm_lifetime_start_p0.Invoke(2L, &num);
		num = 0;
		unchecked
		{
			Half result;
			if (width == 0)
			{
				fputil_raise_except_if_required_int.Invoke(1);
				llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
				short field_ = fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan_Sign_unsigned_short.Invoke(anon_izyfb8.val, 0);
				fputil_FPBits_2fahva2.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
				result = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva2);
				llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva3);
				*(short*)(&fputil_FPBits_2fahva3) = -21846;
				fputil_FPBits_Float16_FPBits_Float16_Float16.Invoke(&fputil_FPBits_2fahva3, x);
				if (fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_is_inf_or_nan_const.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva3)))
				{
					fputil_raise_except_if_required_int.Invoke(1);
					llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva4);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, Sign_POS.Pointer, 1L, isVolatile: false);
					short field_2 = fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan_Sign_unsigned_short.Invoke(anon_izyfb9.val, 0);
					fputil_FPBits_2fahva4.FPRepImpl.FPRepSem.FPStorage.field_0 = field_2;
					result = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva4);
					llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva4);
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(2L, &half);
					half = cpp_enable_if_cpp_is_floating_point_v_Float16_Float16_type_fputil_round_using_specific_rounding_mode_Float16_Float16_int.Invoke(x, rnd);
					if ((uint)(width - 1) > 15u)
					{
						result = half;
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(2L, &num2);
						num2 = (short)(width - 1 + 15);
						llvm_lifetime_start_p0.Invoke(2L, &y);
						llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva5);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, Sign_NEG.Pointer, 1L, isVolatile: false);
						short field_3 = fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_create_value_Sign_unsigned_short_unsigned_short.Invoke(biased_exp: num2, sign: anon_izyfb10.val, mantissa: 0);
						fputil_FPBits_2fahva5.FPRepImpl.FPRepSem.FPStorage.field_0 = field_3;
						Half half2 = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva5);
						llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva5);
						y = half2;
						if (NumericHelper.FcmpOlt(half, y))
						{
							fputil_raise_except_if_required_int.Invoke(1);
							llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva6);
							llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb11, Sign_POS.Pointer, 1L, isVolatile: false);
							short field_4 = fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan_Sign_unsigned_short.Invoke(anon_izyfb11.val, 0);
							fputil_FPBits_2fahva6.FPRepImpl.FPRepSem.FPStorage.field_0 = field_4;
							result = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva6);
							llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva6);
						}
						else
						{
							llvm_lifetime_start_p0.Invoke(2L, &y2);
							llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva7);
							llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb12, Sign_POS.Pointer, 1L, isVolatile: false);
							short field_5 = fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_create_value_Sign_unsigned_short_unsigned_short.Invoke(biased_exp: num2, sign: anon_izyfb12.val, mantissa: 0);
							fputil_FPBits_2fahva7.FPRepImpl.FPRepSem.FPStorage.field_0 = field_5;
							Half half3 = (Half)((float)fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva7) - 1f);
							llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva7);
							y2 = half3;
							if (NumericHelper.FcmpOgt(half, y2))
							{
								fputil_raise_except_if_required_int.Invoke(1);
								llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva8);
								llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb13, Sign_POS.Pointer, 1L, isVolatile: false);
								short field_6 = fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan_Sign_unsigned_short.Invoke(anon_izyfb13.val, 0);
								fputil_FPBits_2fahva8.FPRepImpl.FPRepSem.FPStorage.field_0 = field_6;
								result = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva8);
								llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva8);
							}
							else
							{
								result = half;
							}
							llvm_lifetime_end_p0.Invoke(2L, &y2);
						}
						llvm_lifetime_end_p0.Invoke(2L, &y);
						llvm_lifetime_end_p0.Invoke(2L, &num2);
					}
					llvm_lifetime_end_p0.Invoke(2L, &half);
				}
				llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva3);
			}
			llvm_lifetime_end_p0.Invoke(2L, &num);
			return result;
		}
	}
}
