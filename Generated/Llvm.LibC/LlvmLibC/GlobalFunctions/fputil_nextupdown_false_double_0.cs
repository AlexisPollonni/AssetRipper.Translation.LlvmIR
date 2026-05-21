using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_nextupdown_false_double_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil10nextupdownILb0EdTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT0_EEiE4typeELi0EEES4_S4_")]
	[DemangledName("double __llvm_libc_20_1_2_::fputil::nextupdown<false, double, 0>(double)")]
	[return: NativeType("double")]
	public unsafe static double Invoke([NativeType("double")] double x)
	{
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		fputil_internal_FPRepImpl_ucubaq fputil_internal_FPRepImpl_ucubaq2 = default(fputil_internal_FPRepImpl_ucubaq);
		fputil_internal_FPRepImpl_ucubaq fputil_internal_FPRepImpl_ucubaq3 = default(fputil_internal_FPRepImpl_ucubaq);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		fputil_internal_FPRepImpl_ucubaq fputil_internal_FPRepImpl_ucubaq4 = default(fputil_internal_FPRepImpl_ucubaq);
		fputil_internal_FPRepImpl_ucubaq fputil_internal_FPRepImpl_ucubaq5 = default(fputil_internal_FPRepImpl_ucubaq);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm4 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb11 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb12 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm5 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm6 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm7 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb13 = default(anon_izyfb7);
		llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb8);
		llvm_memset_p0_i64.Invoke(&anon_izyfb8, 0, 1L, isVolatile: false);
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm2) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm2, x);
			bool num = FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2));
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
			int num2;
			if (num)
			{
				num2 = -1;
			}
			else
			{
				llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepImpl_ucubaq2, &fputil_FPBits_wjhbrm2, 8L, isVolatile: false);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, &anon_izyfb8, 1L, isVolatile: false);
				long val = FPRepSem_fputil_FPType_2_fputil_FPBits_double_max_normal.Invoke(anon_izyfb9.val);
				fputil_FPBits_wjhbrm3.FPRepImpl.FPRepSem.FPStorage.val = val;
				llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepImpl_ucubaq3, &fputil_FPBits_wjhbrm3, 8L, isVolatile: false);
				if (internal_Equals_r4buia.Invoke(fputil_internal_FPRepImpl_ucubaq2.FPRepSem.FPStorage.val, fputil_internal_FPRepImpl_ucubaq3.FPRepSem.FPStorage.val))
				{
					num2 = -1;
				}
				else
				{
					llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepImpl_ucubaq4, &fputil_FPBits_wjhbrm2, 8L, isVolatile: false);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, &anon_izyfb8, 1L, isVolatile: false);
					long val2 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf.Invoke(anon_izyfb10.val);
					fputil_FPBits_wjhbrm4.FPRepImpl.FPRepSem.FPStorage.val = val2;
					llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepImpl_ucubaq5, &fputil_FPBits_wjhbrm4, 8L, isVolatile: false);
					num2 = (internal_Equals_r4buia.Invoke(fputil_internal_FPRepImpl_ucubaq4.FPRepSem.FPStorage.val, fputil_internal_FPRepImpl_ucubaq5.FPRepSem.FPStorage.val) ? 1 : 0);
				}
			}
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
			double result;
			if (num2 != 0)
			{
				result = x;
			}
			else
			{
				if (NumericHelper.IsUnorderedOrNotEquals(x, 0.0))
				{
					anon_izyfb11.val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm2);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb12, &anon_izyfb8, 1L, isVolatile: false);
					if (Equals_fy8fvt.Invoke(anon_izyfb11.val, anon_izyfb12.val))
					{
						llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
						FPBits_double_FPBits_unsigned_long.Invoke(&fputil_FPBits_wjhbrm5, FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2)) + 1L);
						llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_wjhbrm2, &fputil_FPBits_wjhbrm5, 8L, isVolatile: false);
						llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm6);
						FPBits_double_FPBits_unsigned_long.Invoke(&fputil_FPBits_wjhbrm6, FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2)) - 1L);
						llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_wjhbrm2, &fputil_FPBits_wjhbrm6, 8L, isVolatile: false);
						llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm6);
					}
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm7);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb13, &anon_izyfb8, 1L, isVolatile: false);
					long val3 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_min_subnormal.Invoke(anon_izyfb13.val);
					fputil_FPBits_wjhbrm7.FPRepImpl.FPRepSem.FPStorage.val = val3;
					llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_wjhbrm2, &fputil_FPBits_wjhbrm7, 8L, isVolatile: false);
					llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm7);
				}
				result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm2);
			}
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
			return result;
		}
	}
}
