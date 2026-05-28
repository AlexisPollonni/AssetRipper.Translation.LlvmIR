using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Acoshf
{
	[MangledName("acoshf")]
	[DemangledName("acoshf")]
	public unsafe static float Invoke([MangledName("x")] float X)
	{
		float result = 0f;
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs = default(Fputil_FPBits_5nkvcs);
		int num = 0;
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(Fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		double num2 = 0.0;
		Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs);
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs) = -1431655766;
			FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs, X);
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs));
			if (Details_expects_bool_condition_bool.Invoke(!(X > 1f), Expected: false))
			{
				if (X == 1f)
				{
					result = 0f;
				}
				else
				{
					Fputil_set_errno_if_required.Invoke(33);
					Fputil_raise_except_if_required.Invoke(1);
					Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Sign_POS.Pointer, 1L, isVolatile: false);
					int field_ = FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan.Invoke(anon_izyfb.Val, 0);
					fputil_FPBits_5nkvcs2.FPRepImpl.FPRepSem.field_0.field_0 = field_;
					result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs2);
					Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
				}
			}
			else
			{
				if (Details_expects_bool_condition_bool.Invoke((uint)num >= 1334835971u, Expected: false))
				{
					if (Details_expects_bool_condition_bool.Invoke(FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_inf_or_nan.Invoke((Fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs)), Expected: false))
					{
						result = X;
						goto IL_02a7;
					}
					Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb2);
					*(sbyte*)(&anon_izyfb2) = -86;
					Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb3);
					*(sbyte*)(&anon_izyfb3) = -86;
					int num3;
					switch (num)
					{
					case 1334835971:
						result = _1_Invoke_7jm4mu.Invoke(&anon_izyfb3, 22.991505f);
						num3 = 1;
						break;
					case 1549180552:
						result = _1_Invoke_7jm4mu.Invoke(&anon_izyfb3, 40.71937f);
						num3 = 1;
						break;
					case 1583913038:
						result = _1_Invoke_7jm4mu.Invoke(&anon_izyfb3, 43.57239f);
						num3 = 1;
						break;
					case 1700303059:
						result = _0_Invoke_8invrw.Invoke(&anon_izyfb2, 53.20505f);
						num3 = 1;
						break;
					case 1857136876:
						result = _0_Invoke_8invrw.Invoke(&anon_izyfb2, 66.17683f);
						num3 = 1;
						break;
					case 2040001290:
						result = _1_Invoke_7jm4mu.Invoke(&anon_izyfb3, 81.26974f);
						num3 = 1;
						break;
					default:
						num3 = 0;
						break;
					}
					Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb3);
					Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb2);
					switch (num3)
					{
					case 0:
						break;
					default:
						goto IL_02a7;
					}
				}
				Llvm_lifetime_start_p0.Invoke(8L, &num2);
				num2 = X;
				result = (float)Log_eval_jhvdqg.Invoke(num2 + Fputil_sqrt_double_double.Invoke(Fputil_multiply_add_double.Invoke(num2, num2, -1.0)));
				Llvm_lifetime_end_p0.Invoke(8L, &num2);
			}
			goto IL_02a7;
		}
		IL_02a7:
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs);
		return result;
	}
}
