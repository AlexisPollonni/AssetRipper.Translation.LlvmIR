using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cospif
{
	[MangledName("cospif")]
	[DemangledName("cospif")]
	public unsafe static float Invoke([MangledName("x")] float X)
	{
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs = default(Fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		int num = 0;
		double num2 = 0.0;
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(Fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		double num3 = 0.0;
		double num4 = 0.0;
		double num5 = 0.0;
		double x = 0.0;
		Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs);
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs) = -1431655766;
			FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs, X);
			Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Sign_POS.Pointer, 1L, isVolatile: false);
			FPStorage_fputil_FPType_1_set_sign.Invoke(&fputil_FPBits_5nkvcs, anon_izyfb.Val);
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs));
			Llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs);
			float result;
			if (Details_expects_bool_condition_bool.Invoke((uint)num < 950204804u, Expected: false))
			{
				result = (float)Fputil_multiply_add_double.Invoke(num2, -2.980232238769531E-08, 1.0);
			}
			else if (Details_expects_bool_condition_bool.Invoke((uint)num >= 1258291200u, Expected: false))
			{
				if (Details_expects_bool_condition_bool.Invoke((uint)num < 1266679808u, Expected: false))
				{
					result = InstructionHelper.Select((num & 1) != 0, -1f, 1f);
				}
				else if (Details_expects_bool_condition_bool.Invoke((uint)num >= 2139095040u, Expected: false))
				{
					if (num == 2139095040)
					{
						Fputil_set_errno_if_required.Invoke(33);
						Fputil_raise_except_if_required.Invoke(1);
					}
					Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, Sign_POS.Pointer, 1L, isVolatile: false);
					int field_ = FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan.Invoke(anon_izyfb2.Val, 0);
					fputil_FPBits_5nkvcs2.FPRepImpl.FPRepSem.field_0.field_0 = field_;
					result = X + FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs2);
					Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
				}
				else
				{
					result = 1f;
				}
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(8L, &num3);
				num3 = double.NaN;
				Llvm_lifetime_start_p0.Invoke(8L, &num4);
				num4 = double.NaN;
				Llvm_lifetime_start_p0.Invoke(8L, &num5);
				num5 = double.NaN;
				Llvm_lifetime_start_p0.Invoke(8L, &x);
				x = double.NaN;
				Sincospif_eval.Invoke(num2, &num3, &num4, &num5, &x);
				result = ((!Details_expects_bool_condition_bool.Invoke(num5 == 0.0 && num4 == 0.0, Expected: false)) ? ((float)Fputil_multiply_add_double.Invoke(num5, 0.0 - num3, Fputil_multiply_add_double.Invoke(x, num4, num4))) : 0f);
				Llvm_lifetime_end_p0.Invoke(8L, &x);
				Llvm_lifetime_end_p0.Invoke(8L, &num5);
				Llvm_lifetime_end_p0.Invoke(8L, &num4);
				Llvm_lifetime_end_p0.Invoke(8L, &num3);
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num2);
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs);
			return result;
		}
	}
}
