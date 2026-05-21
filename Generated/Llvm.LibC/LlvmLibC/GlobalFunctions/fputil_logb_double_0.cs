using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_logb_double_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil4logbIdTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_")]
	[DemangledName("double __llvm_libc_20_1_2_::fputil::logb<double, 0>(double)")]
	[return: NativeType("double")]
	public unsafe static double Invoke([NativeType("double")] double x)
	{
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm4 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		fputil_DyadicFloat_syracv fputil_DyadicFloat_syracv2 = default(fputil_DyadicFloat_syracv);
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm2) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm2, x);
			double result;
			if (details_expects_bool_condition_bool.Invoke((!FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2))) ? FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_inf_or_nan.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2)) : true, expected: false))
			{
				if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)))
				{
					result = x;
				}
				else
				{
					fputil_raise_except_if_required.Invoke(4);
					if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)))
					{
						fputil_set_errno_if_required.Invoke(34);
						llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_NEG.Pointer, 1L, isVolatile: false);
						long val = FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf.Invoke(anon_izyfb8.val);
						fputil_FPBits_wjhbrm3.FPRepImpl.FPRepSem.FPStorage.val = val;
						result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm3);
						llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, Sign_POS.Pointer, 1L, isVolatile: false);
						long val2 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf.Invoke(anon_izyfb9.val);
						fputil_FPBits_wjhbrm4.FPRepImpl.FPRepSem.FPStorage.val = val2;
						result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm4);
						llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
					}
				}
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(16L, &fputil_DyadicFloat_syracv2);
				*(sbyte*)(&fputil_DyadicFloat_syracv2) = -86;
				sbyte* ptr = (sbyte*)(&fputil_DyadicFloat_syracv2) + 1;
				*ptr = -86;
				ptr[1] = -86;
				ptr[2] = -86;
				((int*)(&fputil_DyadicFloat_syracv2))[1] = -1431655766;
				((long*)(&fputil_DyadicFloat_syracv2))[1] = -6148914691236517206L;
				DyadicFloat_64ul_DyadicFloat_double_0.Invoke(&fputil_DyadicFloat_syracv2, FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm2));
				result = DyadicFloat_64ul_get_unbiased_exponent.Invoke(&fputil_DyadicFloat_syracv2);
				llvm_lifetime_end_p0.Invoke(16L, &fputil_DyadicFloat_syracv2);
			}
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			return result;
		}
	}
}
