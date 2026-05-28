using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_nextafter_double_double_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil9nextafterIddTnNS_3cpp9enable_ifIXaaaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_ElestS4_stS5_EiE4typeELi0EEES4_S4_S5_")]
	[DemangledName("double __llvm_libc_20_1_2_::fputil::nextafter<double, double, 0>(double, double)")]
	[return: NativeType("double")]
	public unsafe static double Invoke([MangledName("from")][NativeType("double")] double From, [MangledName("to")][NativeType("double")] double To)
	{
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm = default(Fputil_FPBits_wjhbrm);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(Fputil_FPBits_wjhbrm);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(Fputil_FPBits_wjhbrm);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm4 = default(Fputil_FPBits_wjhbrm);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm5 = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm, From);
			double result;
			if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm)))
			{
				result = From;
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
				*(long*)(&fputil_FPBits_wjhbrm2) = -6148914691236517206L;
				FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm2, To);
				if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)))
				{
					result = Fputil_cast_double_double.Invoke(To);
				}
				else if (Fputil_cast_double_double.Invoke(From) == To)
				{
					result = Fputil_cast_double_double.Invoke(To);
				}
				else
				{
					if (NumericHelper.IsUnorderedOrNotEquals(From, 0.0))
					{
						if (Fputil_cast_double_double.Invoke(From) < To == From > 0.0)
						{
							Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
							FPBits_double_FPBits_unsigned_long.Invoke(&fputil_FPBits_wjhbrm3, FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm)) + 1L);
							Llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_wjhbrm, &fputil_FPBits_wjhbrm3, 8L, isVolatile: false);
							Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
						}
						else
						{
							Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
							FPBits_double_FPBits_unsigned_long.Invoke(&fputil_FPBits_wjhbrm4, FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm)) - 1L);
							Llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_wjhbrm, &fputil_FPBits_wjhbrm4, 8L, isVolatile: false);
							Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
						}
					}
					else
					{
						Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
						anon_izyfb.Val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm2);
						long val = FPRepSem_fputil_FPType_2_fputil_FPBits_double_min_subnormal.Invoke(anon_izyfb.Val);
						fputil_FPBits_wjhbrm5.FPRepImpl.FPRepSem.FPStorage.Val = val;
						Llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_wjhbrm, &fputil_FPBits_wjhbrm5, 8L, isVolatile: false);
						Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
					}
					if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_subnormal.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm)))
					{
						Fputil_raise_except_if_required.Invoke(48);
					}
					else if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_inf.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm)))
					{
						Fputil_raise_except_if_required.Invoke(40);
					}
					result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm);
				}
				Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			}
			Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
			return result;
		}
	}
}
