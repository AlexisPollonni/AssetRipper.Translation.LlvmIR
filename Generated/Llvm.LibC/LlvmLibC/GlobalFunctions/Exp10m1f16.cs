using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Exp10m1f16
{
	[MangledName("exp10m1f16")]
	[DemangledName("exp10m1f16")]
	public unsafe static Half Invoke([MangledName("x")] Half X)
	{
		Half result = default(Half);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva = default(Fputil_FPBits_2fahva);
		short num = 0;
		short num2 = 0;
		Fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva3 = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva4 = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva5 = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb4 = default(Anon_izyfb7);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva6 = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb5 = default(Anon_izyfb7);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva7 = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb6 = default(Anon_izyfb7);
		Cpp_optional_aq7wey cpp_optional_aq7wey = default(Cpp_optional_aq7wey);
		float num3 = 0f;
		Cpp_optional_aq7wey cpp_optional_aq7wey2 = default(Cpp_optional_aq7wey);
		ExpRangeReduction expRangeReduction = default(ExpRangeReduction);
		Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva);
		unchecked
		{
			*(short*)(&fputil_FPBits_2fahva) = -21846;
			FPBits_Float16_Constructor.Invoke(&fputil_FPBits_2fahva, X);
			Llvm_lifetime_start_p0.Invoke(2L, &num);
			num = FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_uintval.Invoke((Fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva));
			Llvm_lifetime_start_p0.Invoke(2L, &num2);
			num2 = (short)((ushort)num & 0x7FFF);
			if (!Details_expects_bool_condition_bool.Invoke((uint)(ushort)num2 <= 12288u || (uint)(ushort)num2 >= 17055u, Expected: false))
			{
				goto IL_05c2;
			}
			if (FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_nan.Invoke((Fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva)))
			{
				if (FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_signaling_nan.Invoke((Fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva)))
				{
					Fputil_raise_except_if_required.Invoke(1);
					Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Sign_POS.Pointer, 1L, isVolatile: false);
					short field_ = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan.Invoke(anon_izyfb.Val, 0);
					fputil_FPBits_2fahva2.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
					result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva2);
					Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
				}
				else
				{
					result = X;
				}
			}
			else if ((uint)(ushort)num >= 17617u && FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_is_pos.Invoke((Fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva)))
			{
				if (FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_inf.Invoke((Fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva)))
				{
					Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva3);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, Sign_POS.Pointer, 1L, isVolatile: false);
					short field_2 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_inf.Invoke(anon_izyfb2.Val);
					fputil_FPBits_2fahva3.FPRepImpl.FPRepSem.FPStorage.field_0 = field_2;
					result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva3);
					Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva3);
				}
				else
				{
					int num4 = Fputil_quick_get_round.Invoke();
					if (num4 == 0 || num4 == 2048)
					{
						Fputil_set_errno_if_required.Invoke(34);
						Fputil_raise_except_if_required.Invoke(40);
						Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva4);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb3, Sign_POS.Pointer, 1L, isVolatile: false);
						short field_3 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_inf.Invoke(anon_izyfb3.Val);
						fputil_FPBits_2fahva4.FPRepImpl.FPRepSem.FPStorage.field_0 = field_3;
						result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva4);
						Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva4);
					}
					else
					{
						Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva5);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb4, Sign_POS.Pointer, 1L, isVolatile: false);
						short field_4 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_max_normal.Invoke(anon_izyfb4.Val);
						fputil_FPBits_2fahva5.FPRepImpl.FPRepSem.FPStorage.field_0 = field_4;
						result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva5);
						Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva5);
					}
				}
			}
			else if ((uint)(ushort)num > 49823u)
			{
				if (FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_inf.Invoke((Fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva)))
				{
					Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva6);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb5, Sign_NEG.Pointer, 1L, isVolatile: false);
					short field_5 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_one.Invoke(anon_izyfb5.Val);
					fputil_FPBits_2fahva6.FPRepImpl.FPRepSem.FPStorage.field_0 = field_5;
					result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva6);
					Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva6);
				}
				else if ((uint)(ushort)num <= 49977u)
				{
					result = Fputil_round_result_slightly_down_Float16.Invoke(Fputil_cast_Float16_double.Invoke(-0.99951171875));
				}
				else
				{
					int num5 = Fputil_quick_get_round.Invoke();
					if (num5 == 0 || num5 == 1024)
					{
						Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva7);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb6, Sign_NEG.Pointer, 1L, isVolatile: false);
						short field_6 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_one.Invoke(anon_izyfb6.Val);
						fputil_FPBits_2fahva7.FPRepImpl.FPRepSem.FPStorage.field_0 = field_6;
						result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva7);
						Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva7);
					}
					else
					{
						result = Fputil_cast_Float16_double.Invoke(-0.99951171875);
					}
				}
			}
			else
			{
				if ((uint)(ushort)num2 > 12288u)
				{
					goto IL_05c2;
				}
				if (Details_expects_bool_condition_bool.Invoke((ushort)num2 == 0, Expected: false))
				{
					result = X;
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(4L, &cpp_optional_aq7wey);
					sbyte* ptr = (sbyte*)(&cpp_optional_aq7wey);
					*(Half*)ptr = default(Half);
					ptr[2] = -86;
					ptr[3] = -86;
					int storage = ExceptValues_Float16_3ul_lookup.Invoke(X_bits: num, This: EXP10M1F16_EXCEPTS_LO.Pointer);
					*(int*)(&cpp_optional_aq7wey.Storage) = storage;
					int num6;
					if (Details_expects_bool_condition_bool.Invoke(Optional_Float16_has_value.Invoke(&cpp_optional_aq7wey), Expected: false))
					{
						result = *(Half*)Optional_Float16_value.Invoke(&cpp_optional_aq7wey);
						num6 = 1;
					}
					else
					{
						num6 = 0;
					}
					Llvm_lifetime_end_p0.Invoke(4L, &cpp_optional_aq7wey);
					switch (num6)
					{
					case 0:
						Llvm_lifetime_start_p0.Invoke(4L, &num3);
						num3 = (float)X;
						result = Fputil_cast_Float16_float.Invoke(num3 * Fputil_polyeval_float_float_float_float_float.Invoke(num3, 2.3025851f, 2.6509333f, 2.0346756f, 1.1753008f, 0.54033464f));
						Llvm_lifetime_end_p0.Invoke(4L, &num3);
						break;
					}
				}
			}
			goto IL_0741;
		}
		IL_0641:
		Llvm_lifetime_start_p0.Invoke(4L, &cpp_optional_aq7wey2);
		unchecked
		{
			sbyte* ptr2 = (sbyte*)(&cpp_optional_aq7wey2);
			*(Half*)ptr2 = default(Half);
			ptr2[2] = -86;
			ptr2[3] = -86;
			int storage2 = ExceptValues_Float16_6ul_lookup.Invoke(X_bits: num, This: EXP10M1F16_EXCEPTS_HI.Pointer);
			*(int*)(&cpp_optional_aq7wey2.Storage) = storage2;
			int num6;
			if (Details_expects_bool_condition_bool.Invoke(Optional_Float16_has_value.Invoke(&cpp_optional_aq7wey2), Expected: false))
			{
				result = *(Half*)Optional_Float16_value.Invoke(&cpp_optional_aq7wey2);
				num6 = 1;
			}
			else
			{
				num6 = 0;
			}
			Llvm_lifetime_end_p0.Invoke(4L, &cpp_optional_aq7wey2);
			switch (num6)
			{
			case 0:
				Llvm_lifetime_start_p0.Invoke(8L, &expRangeReduction);
				*(float*)(&expRangeReduction) = float.NaN;
				((float*)(&expRangeReduction))[1] = float.NaN;
				*(InlineArray2_Single*)(&expRangeReduction) = Exp10_range_reduction.Invoke(X);
				result = Fputil_cast_Float16_float.Invoke(Fputil_multiply_add_float.Invoke(expRangeReduction.Exp_hi_mid, expRangeReduction.Exp_lo, -1f));
				Llvm_lifetime_end_p0.Invoke(8L, &expRangeReduction);
				break;
			}
			goto IL_0741;
		}
		IL_0741:
		Llvm_lifetime_end_p0.Invoke(2L, &num2);
		Llvm_lifetime_end_p0.Invoke(2L, &num);
		Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva);
		return result;
		IL_05c2:
		unchecked
		{
			if (!Details_expects_bool_condition_bool.Invoke(((ushort)num & -32257) == 0, Expected: false))
			{
				goto IL_0641;
			}
			int num7 = (ushort)num;
			if (num7 != 15360)
			{
				if (num7 != 16384)
				{
					if (num7 != 16896)
					{
						goto IL_0641;
					}
					result = Fputil_cast_Float16_double.Invoke(999.0);
				}
				else
				{
					result = Fputil_cast_Float16_double.Invoke(99.0);
				}
			}
			else
			{
				result = Fputil_cast_Float16_double.Invoke(9.0);
			}
			goto IL_0741;
		}
	}
}
