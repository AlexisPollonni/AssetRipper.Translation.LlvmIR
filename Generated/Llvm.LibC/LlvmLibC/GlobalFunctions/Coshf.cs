using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Coshf
{
	[MangledName("coshf")]
	[DemangledName("coshf")]
	public unsafe static float Invoke([MangledName("x")] float X)
	{
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs = default(Fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		int num = 0;
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(Fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		int num2 = 0;
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(Fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs4 = default(Fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb4 = default(Anon_izyfb7);
		float x = X;
		Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs);
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs) = -1431655766;
			FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs, x);
			Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Sign_POS.Pointer, 1L, isVolatile: false);
			FPStorage_fputil_FPType_1_set_sign.Invoke(&fputil_FPBits_5nkvcs, anon_izyfb.Val);
			x = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs);
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs));
			float result;
			if (Details_expects_bool_condition_bool.Invoke((uint)num >= 1119092736u || (uint)num <= 847249408u, Expected: false))
			{
				if ((uint)num <= 847249408u)
				{
					result = 1f + x;
				}
				else if (FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_inf_or_nan.Invoke((Fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs)))
				{
					float num3 = x;
					Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, Sign_POS.Pointer, 1L, isVolatile: false);
					int field_ = FPRepSem_fputil_FPType_1_fputil_FPBits_float_inf.Invoke(anon_izyfb2.Val);
					fputil_FPBits_5nkvcs2.FPRepImpl.FPRepSem.field_0.field_0 = field_;
					result = num3 + FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs2);
					Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(4L, &num2);
					num2 = Fputil_quick_get_round.Invoke();
					if (Details_expects_bool_condition_bool.Invoke(num2 == 1024 || num2 == 3072, Expected: false))
					{
						Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb3, Sign_POS.Pointer, 1L, isVolatile: false);
						int field_2 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_max_normal.Invoke(anon_izyfb3.Val);
						fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0 = field_2;
						result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs3);
						Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
					}
					else
					{
						Fputil_set_errno_if_required.Invoke(34);
						Fputil_raise_except_if_required.Invoke(8);
						float num4 = x;
						Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb4, Sign_POS.Pointer, 1L, isVolatile: false);
						int field_3 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_inf.Invoke(anon_izyfb4.Val);
						fputil_FPBits_5nkvcs4.FPRepImpl.FPRepSem.field_0.field_0 = field_3;
						result = num4 + FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs4);
						Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
					}
					Llvm_lifetime_end_p0.Invoke(4L, &num2);
				}
			}
			else
			{
				result = (float)Exp_pm_eval_false.Invoke(x);
			}
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs);
			return result;
		}
	}
}
