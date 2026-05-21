using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class NormalFloat_double_init_from_bits
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11NormalFloatIdE14init_from_bitsENS0_6FPBitsIdEE")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat<double>::init_from_bits(__llvm_libc_20_1_2_::fputil::FPBits<double>)")]
	public unsafe static void Invoke(fputil_NormalFloat_vc4yvk* @this, [MangledName("bits.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::FPBits<double>")] long bits)
	{
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		int num = 0;
		fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.val = bits;
		llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb8);
		anon_izyfb8.val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm2);
		llvm_memcpy_p0_p0_i64.Invoke(&@this->sign, &anon_izyfb8, 1L, isVolatile: false);
		llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
		unchecked
		{
			if (FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_inf_or_nan.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2)) || FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)))
			{
				@this->exponent = 0;
				@this->mantissa = 0L;
			}
			else if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_subnormal.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)))
			{
				llvm_lifetime_start_p0.Invoke(4L, &num);
				num = NormalFloat_double_evaluate_normalization_shift.Invoke(@this, FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2)));
				@this->mantissa = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2)) << (int)(uint)num;
				@this->exponent = -1022 - num;
				llvm_lifetime_end_p0.Invoke(4L, &num);
			}
			else
			{
				checked
				{
					@this->exponent = unchecked((ushort)FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_biased_exponent.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2))) - 1023;
				}
				@this->mantissa = 0x10000000000000L | FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2));
			}
		}
	}
}
