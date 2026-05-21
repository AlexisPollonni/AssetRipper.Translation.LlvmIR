using System;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class sinpif16
{
	public unsafe static Half Invoke(Half x)
	{
		fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(fputil_FPBits_2fahva);
		short num = 0;
		short num2 = 0;
		float xf = 0f;
		fputil_FPBits_2fahva fputil_FPBits_2fahva3 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		fputil_FPBits_2fahva fputil_FPBits_2fahva4 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		float num3 = 0f;
		float y = 0f;
		float num4 = 0f;
		float x2 = 0f;
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
			llvm_lifetime_start_p0.Invoke(4L, &xf);
			xf = (float)x;
			Half result;
			if (details_expects_bool_condition_bool.Invoke((ushort)num2 == 0, expected: false))
			{
				result = x;
			}
			else if (details_expects_bool_condition_bool.Invoke((ushort)num2 >= 25600, expected: false))
			{
				if (details_expects_bool_condition_bool.Invoke((ushort)num2 >= 31744, expected: false))
				{
					if ((ushort)num2 == 31744)
					{
						fputil_set_errno_if_required.Invoke(33);
						fputil_raise_except_if_required.Invoke(1);
					}
					float num5 = (float)x;
					llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva3);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
					short field_ = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan.Invoke(anon_izyfb8.val, 0);
					fputil_FPBits_2fahva3.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
					result = (Half)(num5 + (float)FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva3));
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
				llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = float.NaN;
				llvm_lifetime_start_p0.Invoke(4L, &y);
				y = float.NaN;
				llvm_lifetime_start_p0.Invoke(4L, &num4);
				num4 = float.NaN;
				llvm_lifetime_start_p0.Invoke(4L, &x2);
				x2 = float.NaN;
				sincospif16_eval.Invoke(xf, &num3, &y, &num4, &x2);
				if (details_expects_bool_condition_bool.Invoke(num4 == 0f && num3 == 0f, expected: false))
				{
					llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva5);
					anon_izyfb10.val = FPStorage_fputil_FPType_0_sign.Invoke(&fputil_FPBits_2fahva2);
					short field_3 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_zero.Invoke(anon_izyfb10.val);
					fputil_FPBits_2fahva5.FPRepImpl.FPRepSem.FPStorage.field_0 = field_3;
					result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva5);
					llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva5);
				}
				else
				{
					result = fputil_cast_Float16_float.Invoke(fputil_multiply_add_float.Invoke(num4, y, fputil_multiply_add_float.Invoke(x2, num3, num3)));
				}
				llvm_lifetime_end_p0.Invoke(4L, &x2);
				llvm_lifetime_end_p0.Invoke(4L, &num4);
				llvm_lifetime_end_p0.Invoke(4L, &y);
				llvm_lifetime_end_p0.Invoke(4L, &num3);
			}
			llvm_lifetime_end_p0.Invoke(4L, &xf);
			llvm_lifetime_end_p0.Invoke(2L, &num2);
			llvm_lifetime_end_p0.Invoke(2L, &num);
			llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
			return result;
		}
	}
}
