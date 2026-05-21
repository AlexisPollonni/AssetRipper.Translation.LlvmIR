using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FMod_double_unsigned_long_fputil_generic_FModDivisionSimpleHelper_unsigned_long_pre_check
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic4FModIdmNS1_24FModDivisionSimpleHelperImEEE9pre_checkEddRd")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::generic::FMod<double, unsigned long, __llvm_libc_20_1_2_::fputil::generic::FModDivisionSimpleHelper<unsigned long>>::pre_check(double, double, double&)")]
	public unsafe static bool Invoke([NativeType("double")] double x, [NativeType("double")] double y, [NativeType("double&")] void* @out)
	{
		double num = 0.0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm4 = default(fputil_FPBits_wjhbrm);
		llvm_lifetime_start_p0.Invoke(8L, &num);
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
		long val = FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan.Invoke(anon_izyfb8.val, 0L);
		fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.val = val;
		double num2 = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm2);
		llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		num = num2;
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm3) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm3, x);
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
			*(long*)(&fputil_FPBits_wjhbrm4) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm4, y);
			bool result;
			if (details_expects_bool_condition_bool.Invoke(!FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm4)) && ((!FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_inf_or_nan.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm4))) ? ((byte)((FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_inf_or_nan.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm3)) ? 1u : 0u) ^ 0xFFFFFFFFu) != 0) : false), expected: true))
			{
				result = false;
			}
			else if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm3)) || FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm4)))
			{
				if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_signaling_nan.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm3)) || FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_signaling_nan.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm4)))
				{
					fputil_raise_except_if_required.Invoke(1);
				}
				*(double*)@out = double.NaN;
				result = true;
			}
			else if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_inf.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm3)) || FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm4)))
			{
				fputil_raise_except_if_required.Invoke(1);
				fputil_set_errno_if_required.Invoke(33);
				*(double*)@out = double.NaN;
				result = true;
			}
			else
			{
				*(double*)@out = x;
				result = true;
			}
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
