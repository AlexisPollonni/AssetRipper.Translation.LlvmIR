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
	public unsafe static float Invoke([NativeType("float")] float x, [NativeType("float")] float y)
	{
		float result = 0f;
		float num = 0f;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs4 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs5 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs6 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb11 = default(anon_izyfb7);
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = float.NaN;
		int num2;
		if (details_expects_bool_condition_bool.Invoke(FMod_float_unsigned_long_fputil_generic_FModDivisionSimpleHelper_unsigned_long_pre_check.Invoke(x, y, &num), expected: false))
		{
			result = num;
			num2 = 1;
		}
		else
		{
			num2 = 0;
		}
		llvm_lifetime_end_p0.Invoke(4L, &num);
		unchecked
		{
			switch (num2)
			{
			case 0:
			{
				llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
				*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
				FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs2, x);
				llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
				*(int*)(&fputil_FPBits_5nkvcs3) = -1431655766;
				FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs3, y);
				llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb8);
				*(sbyte*)(&anon_izyfb8) = -86;
				anon_izyfb8.val = FPStorage_fputil_FPType_1_sign.Invoke(&fputil_FPBits_5nkvcs2);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, Sign_POS.Pointer, 1L, isVolatile: false);
				FPStorage_fputil_FPType_1_set_sign.Invoke(&fputil_FPBits_5nkvcs2, anon_izyfb9.val);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, Sign_POS.Pointer, 1L, isVolatile: false);
				FPStorage_fputil_FPType_1_set_sign.Invoke(&fputil_FPBits_5nkvcs3, anon_izyfb10.val);
				llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
				*(int*)(&fputil_FPBits_5nkvcs4) = -1431655766;
				llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_5nkvcs5, &fputil_FPBits_5nkvcs2, 4L, isVolatile: false);
				llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_5nkvcs6, &fputil_FPBits_5nkvcs3, 4L, isVolatile: false);
				int field_ = FMod_float_unsigned_long_fputil_generic_FModDivisionSimpleHelper_unsigned_long_eval_internal.Invoke(fputil_FPBits_5nkvcs5.FPRepImpl.FPRepSem.field_0.field_0, fputil_FPBits_5nkvcs6.FPRepImpl.FPRepSem.field_0.field_0);
				fputil_FPBits_5nkvcs4.FPRepImpl.FPRepSem.field_0.field_0 = field_;
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb11, &anon_izyfb8, 1L, isVolatile: false);
				FPStorage_fputil_FPType_1_set_sign.Invoke(&fputil_FPBits_5nkvcs4, anon_izyfb11.val);
				result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs4);
				llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
				llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
				llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
				llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
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
