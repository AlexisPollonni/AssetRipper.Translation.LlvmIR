using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class NormalFloat_float_init_from_bits
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11NormalFloatIfE14init_from_bitsENS0_6FPBitsIfEE")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat<float>::init_from_bits(__llvm_libc_20_1_2_::fputil::FPBits<float>)")]
	public unsafe static void Invoke([MangledName("this")] Fputil_NormalFloat_phu2qv* This, [MangledName("bits.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::FPBits<float>")] int Bits)
	{
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs = default(Fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		int num = 0;
		fputil_FPBits_5nkvcs.FPRepImpl.FPRepSem.field_0.field_0 = Bits;
		Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb);
		anon_izyfb.Val = FPStorage_fputil_FPType_1_sign.Invoke(&fputil_FPBits_5nkvcs);
		Llvm_memcpy_p0_p0_i64.Invoke(&This->Sign, &anon_izyfb, 1L, isVolatile: false);
		Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb);
		unchecked
		{
			if (FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_inf_or_nan.Invoke((Fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs)) || FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_zero.Invoke(&fputil_FPBits_5nkvcs))
			{
				This->Exponent = 0;
				This->Mantissa = 0;
			}
			else if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_subnormal.Invoke(&fputil_FPBits_5nkvcs))
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num);
				num = NormalFloat_float_evaluate_normalization_shift.Invoke(This, FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_mantissa.Invoke((Fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs)));
				This->Mantissa = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_mantissa.Invoke((Fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs)) << num;
				This->Exponent = -126 - num;
				Llvm_lifetime_end_p0.Invoke(4L, &num);
			}
			else
			{
				checked
				{
					This->Exponent = unchecked((ushort)FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_biased_exponent.Invoke((Fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs))) - 127;
				}
				This->Mantissa = 0x800000 | FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_mantissa.Invoke((Fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs));
			}
		}
	}
}
