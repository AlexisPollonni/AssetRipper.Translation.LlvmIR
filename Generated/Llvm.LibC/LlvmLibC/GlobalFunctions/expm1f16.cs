using System;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class expm1f16
{
	public unsafe static Half Invoke(Half x)
	{
		Half result = default(Half);
		fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(fputil_FPBits_2fahva);
		short num = 0;
		short num2 = 0;
		fputil_FPBits_2fahva fputil_FPBits_2fahva3 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		fputil_FPBits_2fahva fputil_FPBits_2fahva4 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		fputil_FPBits_2fahva fputil_FPBits_2fahva5 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		fputil_FPBits_2fahva fputil_FPBits_2fahva6 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb11 = default(anon_izyfb7);
		fputil_FPBits_2fahva fputil_FPBits_2fahva7 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb12 = default(anon_izyfb7);
		fputil_FPBits_2fahva fputil_FPBits_2fahva8 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb13 = default(anon_izyfb7);
		cpp_optional_aq7wey cpp_optional_aq7wey2 = default(cpp_optional_aq7wey);
		float num3 = 0f;
		cpp_optional_aq7wey cpp_optional_aq7wey3 = default(cpp_optional_aq7wey);
		ExpRangeReduction expRangeReduction = default(ExpRangeReduction);
		llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
		unchecked
		{
			*(short*)(&fputil_FPBits_2fahva2) = -21846;
			FPBits_Float16_Constructor.Invoke(&fputil_FPBits_2fahva2, x);
			llvm_lifetime_start_p0.Invoke(2L, &num);
			num = FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_uintval.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva2));
			llvm_lifetime_start_p0.Invoke(2L, &num2);
			num2 = (short)((ushort)num & 0x7FFF);
			if (!details_expects_bool_condition_bool.Invoke(((uint)(ushort)num2 > 12288u) ? ((uint)(ushort)num2 >= 18336u) : true, expected: false))
			{
				goto IL_05a1;
			}
			if (FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_nan.Invoke((fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva2)))
			{
				if (FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_signaling_nan.Invoke((fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva2)))
				{
					fputil_raise_except_if_required.Invoke(1);
					llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva3);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
					short field_ = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan.Invoke(anon_izyfb8.val, 0);
					fputil_FPBits_2fahva3.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
					result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva3);
					llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva3);
				}
				else
				{
					result = x;
				}
			}
			else if ((ushort)num2 == 0)
			{
				result = x;
			}
			else if (FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_is_pos.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva2)) && (uint)(ushort)num2 >= 18828u)
			{
				if (FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_inf.Invoke((fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva2)))
				{
					llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva4);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, Sign_POS.Pointer, 1L, isVolatile: false);
					short field_2 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_inf.Invoke(anon_izyfb9.val);
					fputil_FPBits_2fahva4.FPRepImpl.FPRepSem.FPStorage.field_0 = field_2;
					result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva4);
					llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva4);
				}
				else
				{
					int num4 = fputil_quick_get_round.Invoke();
					if (num4 == 0 || num4 == 2048)
					{
						fputil_set_errno_if_required.Invoke(34);
						fputil_raise_except_if_required.Invoke(40);
						llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva5);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, Sign_POS.Pointer, 1L, isVolatile: false);
						short field_3 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_inf.Invoke(anon_izyfb10.val);
						fputil_FPBits_2fahva5.FPRepImpl.FPRepSem.FPStorage.field_0 = field_3;
						result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva5);
						llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva5);
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva6);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb11, Sign_POS.Pointer, 1L, isVolatile: false);
						short field_4 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_max_normal.Invoke(anon_izyfb11.val);
						fputil_FPBits_2fahva6.FPRepImpl.FPRepSem.FPStorage.field_0 = field_4;
						result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva6);
						llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva6);
					}
				}
			}
			else if ((uint)(ushort)num >= 51104u)
			{
				if (FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_inf.Invoke((fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva2)))
				{
					llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva7);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb12, Sign_NEG.Pointer, 1L, isVolatile: false);
					short field_5 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_one.Invoke(anon_izyfb12.val);
					fputil_FPBits_2fahva7.FPRepImpl.FPRepSem.FPStorage.field_0 = field_5;
					result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva7);
					llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva7);
				}
				else if ((uint)(ushort)num > 51240u)
				{
					llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva8);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb13, Sign_NEG.Pointer, 1L, isVolatile: false);
					short field_6 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_one.Invoke(anon_izyfb13.val);
					fputil_FPBits_2fahva8.FPRepImpl.FPRepSem.FPStorage.field_0 = field_6;
					result = fputil_round_result_slightly_up_Float16.Invoke(FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva8));
					llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva8);
				}
				else
				{
					result = fputil_round_result_slightly_down_Float16.Invoke(fputil_cast_Float16_double.Invoke(-0.99951171875));
				}
			}
			else
			{
				if ((uint)(ushort)num2 > 12288u || FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_zero.Invoke((fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva2)))
				{
					goto IL_05a1;
				}
				llvm_lifetime_start_p0.Invoke(4L, &cpp_optional_aq7wey2);
				sbyte* ptr = (sbyte*)(&cpp_optional_aq7wey2);
				*(Half*)ptr = default(Half);
				ptr[2] = -86;
				ptr[3] = -86;
				int storage = ExceptValues_Float16_1ul_lookup.Invoke(x_bits: num, @this: EXPM1F16_EXCEPTS_LO.Pointer);
				*(int*)(&cpp_optional_aq7wey2.storage) = storage;
				int num5;
				if (details_expects_bool_condition_bool.Invoke(optional_Float16_has_value.Invoke(&cpp_optional_aq7wey2), expected: false))
				{
					result = *(Half*)optional_Float16_value.Invoke(&cpp_optional_aq7wey2);
					num5 = 1;
				}
				else
				{
					num5 = 0;
				}
				llvm_lifetime_end_p0.Invoke(4L, &cpp_optional_aq7wey2);
				switch (num5)
				{
				case 0:
					llvm_lifetime_start_p0.Invoke(4L, &num3);
					num3 = (float)x;
					result = fputil_cast_Float16_float.Invoke(num3 * fputil_polyeval_float_float_float_float_float.Invoke(num3, 1f, 0.49999988f, 1f / 6f, 0.041694816f, 0.008335681f));
					llvm_lifetime_end_p0.Invoke(4L, &num3);
					break;
				}
			}
			goto IL_06a1;
		}
		IL_06a1:
		llvm_lifetime_end_p0.Invoke(2L, &num2);
		llvm_lifetime_end_p0.Invoke(2L, &num);
		llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
		return result;
		IL_05a1:
		llvm_lifetime_start_p0.Invoke(4L, &cpp_optional_aq7wey3);
		unchecked
		{
			sbyte* ptr2 = (sbyte*)(&cpp_optional_aq7wey3);
			*(Half*)ptr2 = default(Half);
			ptr2[2] = -86;
			ptr2[3] = -86;
			int storage2 = ExceptValues_Float16_3ul_lookup.Invoke(x_bits: num, @this: EXPM1F16_EXCEPTS_HI.Pointer);
			*(int*)(&cpp_optional_aq7wey3.storage) = storage2;
			int num5;
			if (details_expects_bool_condition_bool.Invoke(optional_Float16_has_value.Invoke(&cpp_optional_aq7wey3), expected: false))
			{
				result = *(Half*)optional_Float16_value.Invoke(&cpp_optional_aq7wey3);
				num5 = 1;
			}
			else
			{
				num5 = 0;
			}
			llvm_lifetime_end_p0.Invoke(4L, &cpp_optional_aq7wey3);
			switch (num5)
			{
			case 0:
				llvm_lifetime_start_p0.Invoke(8L, &expRangeReduction);
				*(float*)(&expRangeReduction) = float.NaN;
				((float*)(&expRangeReduction))[1] = float.NaN;
				*(InlineArray2_Single*)(&expRangeReduction) = exp_range_reduction.Invoke(x);
				result = fputil_cast_Float16_float.Invoke(fputil_multiply_add_float.Invoke(expRangeReduction.exp_hi_mid, expRangeReduction.exp_lo, -1f));
				llvm_lifetime_end_p0.Invoke(8L, &expRangeReduction);
				break;
			}
			goto IL_06a1;
		}
	}
}
