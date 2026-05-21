using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FMod_double_unsigned_long_fputil_generic_FModDivisionSimpleHelper_unsigned_long_eval
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic4FModIdmNS1_24FModDivisionSimpleHelperImEEE4evalEdd")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::generic::FMod<double, unsigned long, __llvm_libc_20_1_2_::fputil::generic::FModDivisionSimpleHelper<unsigned long>>::eval(double, double)")]
	public unsafe static double Invoke([NativeType("double")] double x, [NativeType("double")] double y)
	{
		double result = 0.0;
		double num = 0.0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm4 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm5 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm6 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb11 = default(anon_izyfb7);
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = double.NaN;
		int num2;
		if (details_expects_bool_condition_bool.Invoke(FMod_double_unsigned_long_fputil_generic_FModDivisionSimpleHelper_unsigned_long_pre_check.Invoke(x, y, &num), expected: false))
		{
			result = num;
			num2 = 1;
		}
		else
		{
			num2 = 0;
		}
		llvm_lifetime_end_p0.Invoke(8L, &num);
		unchecked
		{
			switch (num2)
			{
			case 0:
			{
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
				*(long*)(&fputil_FPBits_wjhbrm2) = -6148914691236517206L;
				FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm2, x);
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
				*(long*)(&fputil_FPBits_wjhbrm3) = -6148914691236517206L;
				FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm3, y);
				llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb8);
				*(sbyte*)(&anon_izyfb8) = -86;
				anon_izyfb8.val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm2);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, Sign_POS.Pointer, 1L, isVolatile: false);
				FPStorage_fputil_FPType_2_set_sign.Invoke(&fputil_FPBits_wjhbrm2, anon_izyfb9.val);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, Sign_POS.Pointer, 1L, isVolatile: false);
				FPStorage_fputil_FPType_2_set_sign.Invoke(&fputil_FPBits_wjhbrm3, anon_izyfb10.val);
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
				*(long*)(&fputil_FPBits_wjhbrm4) = -6148914691236517206L;
				llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_wjhbrm5, &fputil_FPBits_wjhbrm2, 8L, isVolatile: false);
				llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_wjhbrm6, &fputil_FPBits_wjhbrm3, 8L, isVolatile: false);
				long val = FMod_double_unsigned_long_fputil_generic_FModDivisionSimpleHelper_unsigned_long_eval_internal.Invoke(fputil_FPBits_wjhbrm5.FPRepImpl.FPRepSem.FPStorage.val, fputil_FPBits_wjhbrm6.FPRepImpl.FPRepSem.FPStorage.val);
				fputil_FPBits_wjhbrm4.FPRepImpl.FPRepSem.FPStorage.val = val;
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb11, &anon_izyfb8, 1L, isVolatile: false);
				FPStorage_fputil_FPType_2_set_sign.Invoke(&fputil_FPBits_wjhbrm4, anon_izyfb11.val);
				result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm4);
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
				llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
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
