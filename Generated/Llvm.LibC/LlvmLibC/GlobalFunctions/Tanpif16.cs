using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Tanpif16
{
	[MangledName("tanpif16")]
	[DemangledName("tanpif16")]
	public unsafe static Half Invoke([MangledName("x")] Half X)
	{
		Half result = default(Half);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva = default(Fputil_FPBits_2fahva);
		short num = 0;
		short num2 = 0;
		sbyte b = 0;
		Cpp_optional_aq7wey cpp_optional_aq7wey = default(Cpp_optional_aq7wey);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva3 = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		float xf = 0f;
		float num3 = 0f;
		float num4 = 0f;
		float num5 = 0f;
		float x = 0f;
		short num6 = 0;
		Fputil_FPBits_2fahva fputil_FPBits_2fahva4 = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva);
		unchecked
		{
			*(short*)(&fputil_FPBits_2fahva) = -21846;
			FPBits_Float16_Constructor.Invoke(&fputil_FPBits_2fahva, X);
			Llvm_lifetime_start_p0.Invoke(2L, &num);
			num = FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_uintval.Invoke((Fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva));
			Llvm_lifetime_start_p0.Invoke(2L, &num2);
			num2 = (short)((ushort)num & 0x7FFF);
			if (Details_expects_bool_condition_bool.Invoke((ushort)num2 <= 17205, Expected: false))
			{
				if (Details_expects_bool_condition_bool.Invoke((ushort)num2 == 0, Expected: false))
				{
					result = X;
					goto IL_0536;
				}
				Llvm_lifetime_start_p0.Invoke(1L, &b);
				b = (((ushort)num >> 15 != 0) ? ((sbyte)1) : ((sbyte)0));
				Llvm_lifetime_start_p0.Invoke(4L, &cpp_optional_aq7wey);
				sbyte* ptr = (sbyte*)(&cpp_optional_aq7wey);
				*(Half*)ptr = default(Half);
				ptr[2] = -86;
				ptr[3] = -86;
				int storage = ExceptValues_Float16_21ul_lookup_odd.Invoke(X_abs: num2, Sign: (b & 1) == 1, This: TANPIF16_EXCEPTS.Pointer);
				*(int*)(&cpp_optional_aq7wey.Storage) = storage;
				int num7;
				if (Details_expects_bool_condition_bool.Invoke(Optional_Float16_has_value.Invoke(&cpp_optional_aq7wey), Expected: false))
				{
					result = *(Half*)Optional_Float16_value.Invoke(&cpp_optional_aq7wey);
					num7 = 1;
				}
				else
				{
					num7 = 0;
				}
				Llvm_lifetime_end_p0.Invoke(4L, &cpp_optional_aq7wey);
				switch (num7)
				{
				case 0:
					num7 = 0;
					break;
				}
				Llvm_lifetime_end_p0.Invoke(1L, &b);
				switch (num7)
				{
				case 0:
					break;
				default:
					goto IL_0536;
				}
			}
			if (Details_expects_bool_condition_bool.Invoke((ushort)num2 >= 25600, Expected: false))
			{
				if (Details_expects_bool_condition_bool.Invoke((ushort)num2 >= 31744, Expected: false))
				{
					if ((ushort)num2 == 31744)
					{
						Fputil_set_errno_if_required.Invoke(33);
						Fputil_raise_except_if_required.Invoke(1);
					}
					float num8 = (float)X;
					Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Sign_POS.Pointer, 1L, isVolatile: false);
					short field_ = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan.Invoke(anon_izyfb.Val, 0);
					fputil_FPBits_2fahva2.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
					result = (Half)(num8 + (float)FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva2));
					Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva3);
					anon_izyfb2.Val = FPStorage_fputil_FPType_0_sign.Invoke(&fputil_FPBits_2fahva);
					short field_2 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_zero.Invoke(anon_izyfb2.Val);
					fputil_FPBits_2fahva3.FPRepImpl.FPRepSem.FPStorage.field_0 = field_2;
					result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva3);
					Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva3);
				}
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(4L, &xf);
				xf = (float)X;
				Llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = float.NaN;
				Llvm_lifetime_start_p0.Invoke(4L, &num4);
				num4 = float.NaN;
				Llvm_lifetime_start_p0.Invoke(4L, &num5);
				num5 = float.NaN;
				Llvm_lifetime_start_p0.Invoke(4L, &x);
				x = float.NaN;
				Sincospif16_eval.Invoke(xf, &num3, &num4, &num5, &x);
				if (Details_expects_bool_condition_bool.Invoke(num5 == 0f && num4 == 0f, Expected: false))
				{
					Fputil_set_errno_if_required.Invoke(33);
					Fputil_raise_except_if_required.Invoke(4);
					Llvm_lifetime_start_p0.Invoke(2L, &num6);
					num6 = (short)((double)X - 0.5);
					float num9 = (float)(Half)InstructionHelper.Select((num6 & 1) != 0, -1, 1);
					Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva4);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb3, Sign_POS.Pointer, 1L, isVolatile: false);
					short field_3 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_inf.Invoke(anon_izyfb3.Val);
					fputil_FPBits_2fahva4.FPRepImpl.FPRepSem.FPStorage.field_0 = field_3;
					result = (Half)(num9 * (float)FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva4));
					Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva4);
					Llvm_lifetime_end_p0.Invoke(2L, &num6);
				}
				else
				{
					result = Fputil_cast_Float16_float.Invoke(Fputil_multiply_add_float.Invoke(num5, num4, Fputil_multiply_add_float.Invoke(x, num3, num3)) / Fputil_multiply_add_float.Invoke(num5, 0f - num3, Fputil_multiply_add_float.Invoke(x, num4, num4)));
				}
				Llvm_lifetime_end_p0.Invoke(4L, &x);
				Llvm_lifetime_end_p0.Invoke(4L, &num5);
				Llvm_lifetime_end_p0.Invoke(4L, &num4);
				Llvm_lifetime_end_p0.Invoke(4L, &num3);
				Llvm_lifetime_end_p0.Invoke(4L, &xf);
			}
			goto IL_0536;
		}
		IL_0536:
		Llvm_lifetime_end_p0.Invoke(2L, &num2);
		Llvm_lifetime_end_p0.Invoke(2L, &num);
		Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva);
		return result;
	}
}
