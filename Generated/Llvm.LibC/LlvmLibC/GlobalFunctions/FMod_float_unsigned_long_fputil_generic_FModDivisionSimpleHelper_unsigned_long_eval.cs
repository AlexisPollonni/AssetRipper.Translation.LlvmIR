using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FMod_float_unsigned_long_fputil_generic_FModDivisionSimpleHelper_unsigned_long_eval
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic4FModIfmNS1_24FModDivisionSimpleHelperImEEE4evalEff")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::generic::FMod<float, unsigned long, __llvm_libc_20_1_2_::fputil::generic::FModDivisionSimpleHelper<unsigned long>>::eval(float, float)")]
	public unsafe static float Invoke([MangledName("x")][NativeType("float")] float X, [MangledName("y")][NativeType("float")] float Y)
	{
		float result = 0f;
		float num = 0f;
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs2 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs3 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs4 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs5 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb4 = default(Anon_izyfb7);
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = float.NaN;
		int num2;
		if (Details_expects_bool_condition_bool.Invoke(FMod_float_unsigned_long_fputil_generic_FModDivisionSimpleHelper_unsigned_long_pre_check.Invoke(X, Y, &num), Expected: false))
		{
			result = num;
			num2 = 1;
		}
		else
		{
			num2 = 0;
		}
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		unchecked
		{
			switch (num2)
			{
			case 0:
			{
				Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
				*(int*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs) = -1431655766;
				FPBits_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs, X);
				Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
				*(int*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2) = -1431655766;
				FPBits_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2, Y);
				Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb);
				*(sbyte*)(&anon_izyfb) = -86;
				anon_izyfb.Val = FPStorage_fputil_FPType_1_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
				FPStorage_fputil_FPType_1_set_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs, anon_izyfb2.Val);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb3, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
				FPStorage_fputil_FPType_1_set_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2, anon_izyfb3.Val);
				Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs3);
				*(int*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs3) = -1431655766;
				Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs4, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs, 4L, isVolatile: false);
				Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs5, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2, 4L, isVolatile: false);
				int field_ = FMod_float_unsigned_long_fputil_generic_FModDivisionSimpleHelper_unsigned_long_eval_internal.Invoke(llvm_libc_20_1_2_fputil_FPBits_5nkvcs4.FPRepImpl.FPRepSem.field_0.field_0, llvm_libc_20_1_2_fputil_FPBits_5nkvcs5.FPRepImpl.FPRepSem.field_0.field_0);
				llvm_libc_20_1_2_fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0 = field_;
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb4, &anon_izyfb, 1L, isVolatile: false);
				FPStorage_fputil_FPType_1_set_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs3, anon_izyfb4.Val);
				result = FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs3);
				Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs3);
				Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb);
				Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
				Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
				goto case 1;
			}
			case 1:
				return result;
			default:
				throw new NotImplementedException("Reached LLVM unreachable instruction.");
			}
		}
	}
}
