using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class tanpif16
{
	public unsafe static Half Invoke(Half x)
	{
		Half result = default(Half);
		fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(fputil_FPBits_2fahva);
		short num = 0;
		short num2 = 0;
		sbyte b = 0;
		cpp_optional_aq7wey cpp_optional_aq7wey2 = default(cpp_optional_aq7wey);
		fputil_FPBits_2fahva fputil_FPBits_2fahva3 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		fputil_FPBits_2fahva fputil_FPBits_2fahva4 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		float xf = 0f;
		float num3 = 0f;
		float num4 = 0f;
		float num5 = 0f;
		float x2 = 0f;
		short num6 = 0;
		fputil_FPBits_2fahva fputil_FPBits_2fahva5 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
		unchecked
		{
			*(short*)(&fputil_FPBits_2fahva2) = -21846;
			FPBits_Float16_Constructor.Invoke(&fputil_FPBits_2fahva2, x);
			llvm_lifetime_start_p0.Invoke(2L, &num);
			num = FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_uintval.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva2));
			llvm_lifetime_start_p0.Invoke(2L, &num2);
			num2 = (short)((ushort)num & 0x7FFF);
			if (details_expects_bool_condition_bool.Invoke((ushort)num2 <= 17205, expected: false))
			{
				if (details_expects_bool_condition_bool.Invoke((ushort)num2 == 0, expected: false))
				{
					result = x;
					goto IL_0536;
				}
				llvm_lifetime_start_p0.Invoke(1L, &b);
				b = (((ushort)num >> 15 != 0) ? ((sbyte)1) : ((sbyte)0));
				llvm_lifetime_start_p0.Invoke(4L, &cpp_optional_aq7wey2);
				sbyte* ptr = (sbyte*)(&cpp_optional_aq7wey2);
				*(Half*)ptr = default(Half);
				ptr[2] = -86;
				ptr[3] = -86;
				int storage = ExceptValues_Float16_21ul_lookup_odd.Invoke(x_abs: num2, sign: (b & 1) == 1, @this: TANPIF16_EXCEPTS.Pointer);
				*(int*)(&cpp_optional_aq7wey2.storage) = storage;
				int num7;
				if (details_expects_bool_condition_bool.Invoke(optional_Float16_has_value.Invoke(&cpp_optional_aq7wey2), expected: false))
				{
					result = *(Half*)optional_Float16_value.Invoke(&cpp_optional_aq7wey2);
					num7 = 1;
				}
				else
				{
					num7 = 0;
				}
				llvm_lifetime_end_p0.Invoke(4L, &cpp_optional_aq7wey2);
				switch (num7)
				{
				case 0:
					num7 = 0;
					break;
				}
				llvm_lifetime_end_p0.Invoke(1L, &b);
				switch (num7)
				{
				case 0:
					break;
				default:
					goto IL_0536;
				}
			}
			if (details_expects_bool_condition_bool.Invoke((ushort)num2 >= 25600, expected: false))
			{
				if (details_expects_bool_condition_bool.Invoke((ushort)num2 >= 31744, expected: false))
				{
					if ((ushort)num2 == 31744)
					{
						fputil_set_errno_if_required.Invoke(33);
						fputil_raise_except_if_required.Invoke(1);
					}
					float num8 = (float)x;
					llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva3);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
					short field_ = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan.Invoke(anon_izyfb8.val, 0);
					fputil_FPBits_2fahva3.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
					result = (Half)(num8 + (float)FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva3));
					llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva3);
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva4);
					anon_izyfb9.val = FPStorage_fputil_FPType_0_sign.Invoke(&fputil_FPBits_2fahva2);
					short field_2 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_zero.Invoke(anon_izyfb9.val);
					fputil_FPBits_2fahva4.FPRepImpl.FPRepSem.FPStorage.field_0 = field_2;
					result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva4);
					llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva4);
				}
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(4L, &xf);
				xf = (float)x;
				llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = float.NaN;
				llvm_lifetime_start_p0.Invoke(4L, &num4);
				num4 = float.NaN;
				llvm_lifetime_start_p0.Invoke(4L, &num5);
				num5 = float.NaN;
				llvm_lifetime_start_p0.Invoke(4L, &x2);
				x2 = float.NaN;
				sincospif16_eval.Invoke(xf, &num3, &num4, &num5, &x2);
				if (details_expects_bool_condition_bool.Invoke(num5 == 0f && num4 == 0f, expected: false))
				{
					fputil_set_errno_if_required.Invoke(33);
					fputil_raise_except_if_required.Invoke(4);
					llvm_lifetime_start_p0.Invoke(2L, &num6);
					num6 = (short)((double)x - 0.5);
					float num9 = (float)(Half)InstructionHelper.Select((num6 & 1) != 0, -1, 1);
					llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva5);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, Sign_POS.Pointer, 1L, isVolatile: false);
					short field_3 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_inf.Invoke(anon_izyfb10.val);
					fputil_FPBits_2fahva5.FPRepImpl.FPRepSem.FPStorage.field_0 = field_3;
					result = (Half)(num9 * (float)FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva5));
					llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva5);
					llvm_lifetime_end_p0.Invoke(2L, &num6);
				}
				else
				{
					result = fputil_cast_Float16_float.Invoke(fputil_multiply_add_float.Invoke(num5, num4, fputil_multiply_add_float.Invoke(x2, num3, num3)) / fputil_multiply_add_float.Invoke(num5, 0f - num3, fputil_multiply_add_float.Invoke(x2, num4, num4)));
				}
				llvm_lifetime_end_p0.Invoke(4L, &x2);
				llvm_lifetime_end_p0.Invoke(4L, &num5);
				llvm_lifetime_end_p0.Invoke(4L, &num4);
				llvm_lifetime_end_p0.Invoke(4L, &num3);
				llvm_lifetime_end_p0.Invoke(4L, &xf);
			}
			goto IL_0536;
		}
		IL_0536:
		llvm_lifetime_end_p0.Invoke(2L, &num2);
		llvm_lifetime_end_p0.Invoke(2L, &num);
		llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
		return result;
	}
}
