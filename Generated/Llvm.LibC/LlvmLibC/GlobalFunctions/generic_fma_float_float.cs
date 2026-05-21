using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class generic_fma_float_float
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic3fmaIffEENS_3cpp9enable_ifIXaaaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_ElestS5_stS6_ES5_E4typeES6_S6_S6_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<float> && cpp::is_floating_point_v<float> && sizeof (float) <= sizeof (float), float>::type __llvm_libc_20_1_2_::fputil::generic::fma<float, float>(float, float, float)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<float> && cpp::is_floating_point_v<float> && sizeof (float) <= sizeof (float), float>::type")]
	public unsafe static float Invoke([NativeType("float")] float x, [NativeType("float")] float y, [NativeType("float")] float z)
	{
		double num = 0.0;
		double num2 = 0.0;
		double x2 = 0.0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm4 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm5 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = (double)x * (double)y;
		llvm_lifetime_start_p0.Invoke(8L, &num2);
		num2 = z;
		llvm_lifetime_start_p0.Invoke(8L, &x2);
		x2 = num + num2;
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm2) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm2, num);
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
			*(long*)(&fputil_FPBits_wjhbrm3) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm3, num2);
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
			*(long*)(&fputil_FPBits_wjhbrm4) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm4, x2);
			if (!FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_inf_or_nan.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm4)) && !FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm4)))
			{
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
				*(long*)(&fputil_FPBits_wjhbrm5) = -6148914691236517206L;
				FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm5, ((ushort)FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_biased_exponent.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2)) < (ushort)FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_biased_exponent.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm3))) ? (FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm4) - FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm3) - FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm2)) : (FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm4) - FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm2) - FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm3)));
				if (!FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm5)) && (FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm4)) & 0xFFFFFFFL) == 0L)
				{
					anon_izyfb8.val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm4);
					anon_izyfb9.val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm5);
					if (NotEquals_rpctvi.Invoke(anon_izyfb8.val, anon_izyfb9.val))
					{
						FPRepImpl_fputil_FPType_2_fputil_FPBits_double_set_mantissa.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm4), FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm4)) + 1L);
					}
					else if (FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm4)) != 0L)
					{
						FPRepImpl_fputil_FPType_2_fputil_FPBits_double_set_mantissa.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm4), FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm4)) - 1L);
					}
				}
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
			}
			float result = (float)FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm4);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			llvm_lifetime_end_p0.Invoke(8L, &x2);
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
