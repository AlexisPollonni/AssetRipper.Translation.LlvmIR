using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_nextafter_double_double_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil9nextafterIddTnNS_3cpp9enable_ifIXaaaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_ElestS4_stS5_EiE4typeELi0EEES4_S4_S5_")]
	[DemangledName("double __llvm_libc_20_1_2_::fputil::nextafter<double, double, 0>(double, double)")]
	[return: NativeType("double")]
	public unsafe static double Invoke([NativeType("double")] double from, [NativeType("double")] double to)
	{
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm4 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm5 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm6 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm2) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm2, from);
			double result;
			if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)))
			{
				result = from;
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
				*(long*)(&fputil_FPBits_wjhbrm3) = -6148914691236517206L;
				FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm3, to);
				if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm3)))
				{
					result = fputil_cast_double_double.Invoke(to);
				}
				else if (fputil_cast_double_double.Invoke(from) == to)
				{
					result = fputil_cast_double_double.Invoke(to);
				}
				else
				{
					if (NumericHelper.IsUnorderedOrNotEquals(from, 0.0))
					{
						if (fputil_cast_double_double.Invoke(from) < to == from > 0.0)
						{
							llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
							FPBits_double_FPBits_unsigned_long.Invoke(&fputil_FPBits_wjhbrm4, FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2)) + 1L);
							llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_wjhbrm2, &fputil_FPBits_wjhbrm4, 8L, isVolatile: false);
							llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
						}
						else
						{
							llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
							FPBits_double_FPBits_unsigned_long.Invoke(&fputil_FPBits_wjhbrm5, FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2)) - 1L);
							llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_wjhbrm2, &fputil_FPBits_wjhbrm5, 8L, isVolatile: false);
							llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
						}
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm6);
						anon_izyfb8.val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm3);
						long val = FPRepSem_fputil_FPType_2_fputil_FPBits_double_min_subnormal.Invoke(anon_izyfb8.val);
						fputil_FPBits_wjhbrm6.FPRepImpl.FPRepSem.FPStorage.val = val;
						llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_wjhbrm2, &fputil_FPBits_wjhbrm6, 8L, isVolatile: false);
						llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm6);
					}
					if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_subnormal.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)))
					{
						fputil_raise_except_if_required.Invoke(48);
					}
					else if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_inf.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)))
					{
						fputil_raise_except_if_required.Invoke(40);
					}
					result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm2);
				}
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
			}
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			return result;
		}
	}
}
