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
	public unsafe static double Invoke([MangledName("x")][NativeType("double")] double X, [MangledName("y")][NativeType("double")] double Y)
	{
		double result = 0.0;
		double num = 0.0;
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm = default(Fputil_FPBits_wjhbrm);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(Fputil_FPBits_wjhbrm);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm4 = default(Fputil_FPBits_wjhbrm);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm5 = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb4 = default(Anon_izyfb7);
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = double.NaN;
		int num2;
		if (Details_expects_bool_condition_bool.Invoke(FMod_double_unsigned_long_fputil_generic_FModDivisionSimpleHelper_unsigned_long_pre_check.Invoke(X, Y, &num), Expected: false))
		{
			result = num;
			num2 = 1;
		}
		else
		{
			num2 = 0;
		}
		Llvm_lifetime_end_p0.Invoke(8L, &num);
		unchecked
		{
			switch (num2)
			{
			case 0:
			{
				Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
				*(long*)(&fputil_FPBits_wjhbrm) = -6148914691236517206L;
				FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm, X);
				Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
				*(long*)(&fputil_FPBits_wjhbrm2) = -6148914691236517206L;
				FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm2, Y);
				Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb);
				*(sbyte*)(&anon_izyfb) = -86;
				anon_izyfb.Val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, Sign_POS.Pointer, 1L, isVolatile: false);
				FPStorage_fputil_FPType_2_set_sign.Invoke(&fputil_FPBits_wjhbrm, anon_izyfb2.Val);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb3, Sign_POS.Pointer, 1L, isVolatile: false);
				FPStorage_fputil_FPType_2_set_sign.Invoke(&fputil_FPBits_wjhbrm2, anon_izyfb3.Val);
				Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
				*(long*)(&fputil_FPBits_wjhbrm3) = -6148914691236517206L;
				Llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_wjhbrm4, &fputil_FPBits_wjhbrm, 8L, isVolatile: false);
				Llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_wjhbrm5, &fputil_FPBits_wjhbrm2, 8L, isVolatile: false);
				long val = FMod_double_unsigned_long_fputil_generic_FModDivisionSimpleHelper_unsigned_long_eval_internal.Invoke(fputil_FPBits_wjhbrm4.FPRepImpl.FPRepSem.FPStorage.Val, fputil_FPBits_wjhbrm5.FPRepImpl.FPRepSem.FPStorage.Val);
				fputil_FPBits_wjhbrm3.FPRepImpl.FPRepSem.FPStorage.Val = val;
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb4, &anon_izyfb, 1L, isVolatile: false);
				FPStorage_fputil_FPType_2_set_sign.Invoke(&fputil_FPBits_wjhbrm3, anon_izyfb4.Val);
				result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm3);
				Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
				Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb);
				Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
				Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
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
