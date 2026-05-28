using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FMod_Float16_unsigned_int_fputil_generic_FModDivisionSimpleHelper_unsigned_int_eval
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic4FModIDF16_jNS1_24FModDivisionSimpleHelperIjEEE4evalEDF16_DF16_")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::generic::FMod<_Float16, unsigned int, __llvm_libc_20_1_2_::fputil::generic::FModDivisionSimpleHelper<unsigned int>>::eval(_Float16, _Float16)")]
	public unsafe static Half Invoke([MangledName("x")][NativeType("_Float16")] Half X, [MangledName("y")][NativeType("_Float16")] Half Y)
	{
		Half result = default(Half);
		Half half = default(Half);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva = default(Fputil_FPBits_2fahva);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva3 = default(Fputil_FPBits_2fahva);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva4 = default(Fputil_FPBits_2fahva);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva5 = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb4 = default(Anon_izyfb7);
		Llvm_lifetime_start_p0.Invoke(2L, &half);
		half = default(Half);
		int num;
		if (Details_expects_bool_condition_bool.Invoke(FMod_Float16_unsigned_int_fputil_generic_FModDivisionSimpleHelper_unsigned_int_pre_check.Invoke(X, Y, &half), Expected: false))
		{
			result = half;
			num = 1;
		}
		else
		{
			num = 0;
		}
		Llvm_lifetime_end_p0.Invoke(2L, &half);
		unchecked
		{
			switch (num)
			{
			case 0:
			{
				Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva);
				*(short*)(&fputil_FPBits_2fahva) = -21846;
				FPBits_Float16_Constructor.Invoke(&fputil_FPBits_2fahva, X);
				Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
				*(short*)(&fputil_FPBits_2fahva2) = -21846;
				FPBits_Float16_Constructor.Invoke(&fputil_FPBits_2fahva2, Y);
				Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb);
				*(sbyte*)(&anon_izyfb) = -86;
				anon_izyfb.Val = FPStorage_fputil_FPType_0_sign.Invoke(&fputil_FPBits_2fahva);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, Sign_POS.Pointer, 1L, isVolatile: false);
				FPStorage_fputil_FPType_0_set_sign.Invoke(&fputil_FPBits_2fahva, anon_izyfb2.Val);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb3, Sign_POS.Pointer, 1L, isVolatile: false);
				FPStorage_fputil_FPType_0_set_sign.Invoke(&fputil_FPBits_2fahva2, anon_izyfb3.Val);
				Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva3);
				*(short*)(&fputil_FPBits_2fahva3) = -21846;
				Llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_2fahva4, &fputil_FPBits_2fahva, 2L, isVolatile: false);
				Llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_2fahva5, &fputil_FPBits_2fahva2, 2L, isVolatile: false);
				short field_ = FMod_Float16_unsigned_int_fputil_generic_FModDivisionSimpleHelper_unsigned_int_eval_internal.Invoke(fputil_FPBits_2fahva4.FPRepImpl.FPRepSem.FPStorage.field_0, fputil_FPBits_2fahva5.FPRepImpl.FPRepSem.FPStorage.field_0);
				fputil_FPBits_2fahva3.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb4, &anon_izyfb, 1L, isVolatile: false);
				FPStorage_fputil_FPType_0_set_sign.Invoke(&fputil_FPBits_2fahva3, anon_izyfb4.Val);
				result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva3);
				Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva3);
				Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb);
				Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
				Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva);
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
