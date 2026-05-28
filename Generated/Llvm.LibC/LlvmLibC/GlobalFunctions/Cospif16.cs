using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cospif16
{
	[MangledName("cospif16")]
	[DemangledName("cospif16")]
	public unsafe static Half Invoke([MangledName("x")] Half X)
	{
		Fputil_FPBits_2fahva fputil_FPBits_2fahva = default(Fputil_FPBits_2fahva);
		short num = 0;
		short num2 = 0;
		float xf = 0f;
		Fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		float num3 = 0f;
		float num4 = 0f;
		float num5 = 0f;
		float y = 0f;
		Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva);
		unchecked
		{
			*(short*)(&fputil_FPBits_2fahva) = -21846;
			FPBits_Float16_Constructor.Invoke(&fputil_FPBits_2fahva, X);
			Llvm_lifetime_start_p0.Invoke(2L, &num);
			num = FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_uintval.Invoke((Fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva));
			Llvm_lifetime_start_p0.Invoke(2L, &num2);
			num2 = (short)((ushort)num & 0x7FFF);
			Llvm_lifetime_start_p0.Invoke(4L, &xf);
			xf = (float)X;
			Half result;
			if (Details_expects_bool_condition_bool.Invoke((ushort)num2 == 0, Expected: false))
			{
				result = Fputil_cast_Float16_float.Invoke(1f);
			}
			else if (Details_expects_bool_condition_bool.Invoke((ushort)num2 >= 25600, Expected: false))
			{
				if (Details_expects_bool_condition_bool.Invoke((ushort)num2 <= 26623, Expected: false))
				{
					result = Fputil_cast_Float16_float.Invoke(InstructionHelper.Select(((ushort)num2 & 1) != 0, -1f, 1f));
				}
				else if (Details_expects_bool_condition_bool.Invoke((ushort)num2 >= 31744, Expected: false))
				{
					if ((ushort)num2 == 31744)
					{
						Fputil_set_errno_if_required.Invoke(33);
						Fputil_raise_except_if_required.Invoke(1);
					}
					float num6 = (float)X;
					Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Sign_POS.Pointer, 1L, isVolatile: false);
					short field_ = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan.Invoke(anon_izyfb.Val, 0);
					fputil_FPBits_2fahva2.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
					result = (Half)(num6 + (float)FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva2));
					Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
				}
				else
				{
					result = Fputil_cast_Float16_float.Invoke(1f);
				}
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = float.NaN;
				Llvm_lifetime_start_p0.Invoke(4L, &num4);
				num4 = float.NaN;
				Llvm_lifetime_start_p0.Invoke(4L, &num5);
				num5 = float.NaN;
				Llvm_lifetime_start_p0.Invoke(4L, &y);
				y = float.NaN;
				Sincospif16_eval.Invoke(xf, &num3, &num4, &num5, &y);
				result = ((!Details_expects_bool_condition_bool.Invoke(num5 == 0f && num4 == 0f, Expected: false)) ? Fputil_cast_Float16_float.Invoke(Fputil_multiply_add_float.Invoke(num4, y, Fputil_multiply_add_float.Invoke(0f - num3, num5, num4))) : Fputil_cast_Float16_float.Invoke(0f));
				Llvm_lifetime_end_p0.Invoke(4L, &y);
				Llvm_lifetime_end_p0.Invoke(4L, &num5);
				Llvm_lifetime_end_p0.Invoke(4L, &num4);
				Llvm_lifetime_end_p0.Invoke(4L, &num3);
			}
			Llvm_lifetime_end_p0.Invoke(4L, &xf);
			Llvm_lifetime_end_p0.Invoke(2L, &num2);
			Llvm_lifetime_end_p0.Invoke(2L, &num);
			Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva);
			return result;
		}
	}
}
