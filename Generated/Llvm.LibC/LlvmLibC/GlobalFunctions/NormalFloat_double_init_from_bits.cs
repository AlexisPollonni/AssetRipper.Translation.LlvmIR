using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class NormalFloat_double_init_from_bits
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11NormalFloatIdE14init_from_bitsENS0_6FPBitsIdEE")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat<double>::init_from_bits(__llvm_libc_20_1_2_::fputil::FPBits<double>)")]
	public unsafe static void Invoke([MangledName("this")] Fputil_NormalFloat_vc4yvk* This, [MangledName("bits.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::FPBits<double>")] long Bits)
	{
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		int num = 0;
		fputil_FPBits_wjhbrm.FPRepImpl.FPRepSem.FPStorage.Val = Bits;
		Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb);
		anon_izyfb.Val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm);
		Llvm_memcpy_p0_p0_i64.Invoke(&This->Sign, &anon_izyfb, 1L, isVolatile: false);
		Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb);
		unchecked
		{
			if (FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_inf_or_nan.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm)) || FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm)))
			{
				This->Exponent = 0;
				This->Mantissa = 0L;
			}
			else if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_subnormal.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm)))
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num);
				num = NormalFloat_double_evaluate_normalization_shift.Invoke(This, FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm)));
				This->Mantissa = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm)) << (int)(uint)num;
				This->Exponent = -1022 - num;
				Llvm_lifetime_end_p0.Invoke(4L, &num);
			}
			else
			{
				checked
				{
					This->Exponent = unchecked((ushort)FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_biased_exponent.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm))) - 1023;
				}
				This->Mantissa = 0x10000000000000L | FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm));
			}
		}
	}
}
