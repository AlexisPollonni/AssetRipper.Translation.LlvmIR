using System;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class cosf16
{
	public unsafe static Half Invoke(Half x)
	{
		Half result = default(Half);
		fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(fputil_FPBits_2fahva);
		short num = 0;
		short num2 = 0;
		float xf = 0f;
		cpp_optional_aq7wey cpp_optional_aq7wey2 = default(cpp_optional_aq7wey);
		fputil_FPBits_2fahva fputil_FPBits_2fahva3 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		float num3 = 0f;
		float num4 = 0f;
		float y = 0f;
		float y2 = 0f;
		llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
		unchecked
		{
			*(short*)(&fputil_FPBits_2fahva2) = -21846;
			FPBits_Float16_Constructor.Invoke(&fputil_FPBits_2fahva2, x);
			llvm_lifetime_start_p0.Invoke(2L, &num);
			num = FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_uintval.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva2));
			llvm_lifetime_start_p0.Invoke(2L, &num2);
			num2 = (short)((ushort)num & 0x7FFF);
			llvm_lifetime_start_p0.Invoke(4L, &xf);
			xf = (float)x;
			llvm_lifetime_start_p0.Invoke(4L, &cpp_optional_aq7wey2);
			sbyte* ptr = (sbyte*)(&cpp_optional_aq7wey2);
			*(Half*)ptr = default(Half);
			ptr[2] = -86;
			ptr[3] = -86;
			int storage = ExceptValues_Float16_4ul_lookup.Invoke(x_bits: num2, @this: COSF16_EXCEPTS.Pointer);
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
				if (details_expects_bool_condition_bool.Invoke((ushort)num2 == 0, expected: false))
				{
					result = fputil_cast_Float16_float.Invoke(1f);
				}
				else if (FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_is_inf_or_nan.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva2)))
				{
					if (FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_inf.Invoke((fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva2)))
					{
						fputil_set_errno_if_required.Invoke(33);
						fputil_raise_except_if_required.Invoke(1);
					}
					float num6 = (float)x;
					llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva3);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
					short field_ = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan.Invoke(anon_izyfb8.val, 0);
					fputil_FPBits_2fahva3.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
					result = (Half)(num6 + (float)FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva3));
					llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva3);
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(4L, &num3);
					num3 = float.NaN;
					llvm_lifetime_start_p0.Invoke(4L, &num4);
					num4 = float.NaN;
					llvm_lifetime_start_p0.Invoke(4L, &y);
					y = float.NaN;
					llvm_lifetime_start_p0.Invoke(4L, &y2);
					y2 = float.NaN;
					sincosf16_eval.Invoke(xf, &num3, &num4, &y, &y2);
					result = fputil_cast_Float16_float.Invoke(fputil_multiply_add_float.Invoke(num4, y2, fputil_multiply_add_float.Invoke(0f - num3, y, num4)));
					llvm_lifetime_end_p0.Invoke(4L, &y2);
					llvm_lifetime_end_p0.Invoke(4L, &y);
					llvm_lifetime_end_p0.Invoke(4L, &num4);
					llvm_lifetime_end_p0.Invoke(4L, &num3);
				}
				break;
			}
			llvm_lifetime_end_p0.Invoke(4L, &xf);
			llvm_lifetime_end_p0.Invoke(2L, &num2);
			llvm_lifetime_end_p0.Invoke(2L, &num);
			llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
			return result;
		}
	}
}
