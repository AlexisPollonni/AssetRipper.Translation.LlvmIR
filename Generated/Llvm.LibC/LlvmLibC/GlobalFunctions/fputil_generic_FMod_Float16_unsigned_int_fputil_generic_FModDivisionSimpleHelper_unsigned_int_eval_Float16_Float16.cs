using System;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic4FModIDF16_jNS1_24FModDivisionSimpleHelperIjEEE4evalEDF16_DF16_")]
[DemangledName("__llvm_libc_20_1_2_::fputil::generic::FMod<_Float16, unsigned int, __llvm_libc_20_1_2_::fputil::generic::FModDivisionSimpleHelper<unsigned int>>::eval(_Float16, _Float16)")]
internal static partial class fputil_generic_FMod_Float16_unsigned_int_fputil_generic_FModDivisionSimpleHelper_unsigned_int_eval_Float16_Float16
{
	public unsafe static Half Invoke(Half x, Half y)
	{
		Half result = default(Half);
		Half half = default(Half);
		fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(fputil_FPBits_2fahva);
		fputil_FPBits_2fahva fputil_FPBits_2fahva3 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		fputil_FPBits_2fahva fputil_FPBits_2fahva4 = default(fputil_FPBits_2fahva);
		fputil_FPBits_2fahva fputil_FPBits_2fahva5 = default(fputil_FPBits_2fahva);
		fputil_FPBits_2fahva fputil_FPBits_2fahva6 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb11 = default(anon_izyfb7);
		llvm_lifetime_start_p0.Invoke(2L, &half);
		half = default(Half);
		int num;
		if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(fputil_generic_FMod_Float16_unsigned_int_fputil_generic_FModDivisionSimpleHelper_unsigned_int_pre_check_Float16_Float16_Float16.Invoke(x, y, &half), expected: false))
		{
			result = half;
			num = 1;
		}
		else
		{
			num = 0;
		}
		llvm_lifetime_end_p0.Invoke(2L, &half);
		unchecked
		{
			switch (num)
			{
			case 0:
			{
				llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
				*(short*)(&fputil_FPBits_2fahva2) = -21846;
				fputil_FPBits_Float16_FPBits_Float16_Float16.Invoke(&fputil_FPBits_2fahva2, x);
				llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva3);
				*(short*)(&fputil_FPBits_2fahva3) = -21846;
				fputil_FPBits_Float16_FPBits_Float16_Float16.Invoke(&fputil_FPBits_2fahva3, y);
				llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb8);
				*(sbyte*)(&anon_izyfb8) = -86;
				anon_izyfb8.val = fputil_internal_FPStorage_fputil_FPType_0_sign_const.Invoke(&fputil_FPBits_2fahva2);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, Sign_POS.Pointer, 1L, isVolatile: false);
				fputil_internal_FPStorage_fputil_FPType_0_set_sign_Sign.Invoke(&fputil_FPBits_2fahva2, anon_izyfb9.val);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, Sign_POS.Pointer, 1L, isVolatile: false);
				fputil_internal_FPStorage_fputil_FPType_0_set_sign_Sign.Invoke(&fputil_FPBits_2fahva3, anon_izyfb10.val);
				llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva4);
				*(short*)(&fputil_FPBits_2fahva4) = -21846;
				llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_2fahva5, &fputil_FPBits_2fahva2, 2L, isVolatile: false);
				llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_2fahva6, &fputil_FPBits_2fahva3, 2L, isVolatile: false);
				short field_ = fputil_generic_FMod_Float16_unsigned_int_fputil_generic_FModDivisionSimpleHelper_unsigned_int_eval_internal_fputil_FPBits_Float16_fputil_FPBits_Float16.Invoke(fputil_FPBits_2fahva5.FPRepImpl.FPRepSem.FPStorage.field_0, fputil_FPBits_2fahva6.FPRepImpl.FPRepSem.FPStorage.field_0);
				fputil_FPBits_2fahva4.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb11, &anon_izyfb8, 1L, isVolatile: false);
				fputil_internal_FPStorage_fputil_FPType_0_set_sign_Sign.Invoke(&fputil_FPBits_2fahva4, anon_izyfb11.val);
				result = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva4);
				llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva4);
				llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
				llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva3);
				llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
				goto case 1;
			}
			case 1:
				return result;
			default:
				throw null;
			}
		}
	}
}
