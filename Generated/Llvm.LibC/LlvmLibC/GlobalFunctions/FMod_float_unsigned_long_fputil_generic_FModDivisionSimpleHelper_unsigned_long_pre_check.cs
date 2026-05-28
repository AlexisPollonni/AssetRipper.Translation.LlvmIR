using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FMod_float_unsigned_long_fputil_generic_FModDivisionSimpleHelper_unsigned_long_pre_check
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic4FModIfmNS1_24FModDivisionSimpleHelperImEEE9pre_checkEffRf")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::generic::FMod<float, unsigned long, __llvm_libc_20_1_2_::fputil::generic::FModDivisionSimpleHelper<unsigned long>>::pre_check(float, float, float&)")]
	public unsafe static bool Invoke([MangledName("x")][NativeType("float")] float X, [MangledName("y")][NativeType("float")] float Y, [MangledName("out")][NativeType("float&")] void* Out)
	{
		float num = 0f;
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs = default(Fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(Fputil_FPBits_5nkvcs);
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(Fputil_FPBits_5nkvcs);
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs);
		Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Sign_POS.Pointer, 1L, isVolatile: false);
		int field_ = FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan.Invoke(anon_izyfb.Val, 0);
		fputil_FPBits_5nkvcs.FPRepImpl.FPRepSem.field_0.field_0 = field_;
		float num2 = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs);
		Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs);
		num = num2;
		Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
			FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs2, X);
			Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
			*(int*)(&fputil_FPBits_5nkvcs3) = -1431655766;
			FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs3, Y);
			bool result;
			if (Details_expects_bool_condition_bool.Invoke(!FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_zero.Invoke(&fputil_FPBits_5nkvcs3) && !FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_inf_or_nan.Invoke((Fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs3)) && InstructionHelper.BooleanXor(FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_inf_or_nan.Invoke((Fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2)), right: true), Expected: true))
			{
				result = false;
			}
			else if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan.Invoke(&fputil_FPBits_5nkvcs2) || FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan.Invoke(&fputil_FPBits_5nkvcs3))
			{
				if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_signaling_nan.Invoke(&fputil_FPBits_5nkvcs2) || FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_signaling_nan.Invoke(&fputil_FPBits_5nkvcs3))
				{
					Fputil_raise_except_if_required.Invoke(1);
				}
				*(float*)Out = float.NaN;
				result = true;
			}
			else if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_inf.Invoke(&fputil_FPBits_5nkvcs2) || FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_zero.Invoke(&fputil_FPBits_5nkvcs3))
			{
				Fputil_raise_except_if_required.Invoke(1);
				Fputil_set_errno_if_required.Invoke(33);
				*(float*)Out = float.NaN;
				result = true;
			}
			else
			{
				*(float*)Out = X;
				result = true;
			}
			Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
			Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
