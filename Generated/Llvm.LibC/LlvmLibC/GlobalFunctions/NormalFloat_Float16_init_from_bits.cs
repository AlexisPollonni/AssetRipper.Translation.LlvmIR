using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class NormalFloat_Float16_init_from_bits
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11NormalFloatIDF16_E14init_from_bitsENS0_6FPBitsIDF16_EE")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat<_Float16>::init_from_bits(__llvm_libc_20_1_2_::fputil::FPBits<_Float16>)")]
	public unsafe static void Invoke([MangledName("this")] Fputil_NormalFloat_epbrnk* This, [MangledName("bits.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::FPBits<_Float16>")] short Bits)
	{
		Fputil_FPBits_2fahva fputil_FPBits_2fahva = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		int num = 0;
		fputil_FPBits_2fahva.FPRepImpl.FPRepSem.FPStorage.field_0 = Bits;
		Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb);
		anon_izyfb.Val = FPStorage_fputil_FPType_0_sign.Invoke(&fputil_FPBits_2fahva);
		Llvm_memcpy_p0_p0_i64.Invoke(&This->Sign, &anon_izyfb, 1L, isVolatile: false);
		Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb);
		unchecked
		{
			if (FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_is_inf_or_nan.Invoke((Fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva)) || FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_zero.Invoke((Fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva)))
			{
				This->Exponent = 0;
				This->Mantissa = 0;
			}
			else if (FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_subnormal.Invoke((Fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva)))
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num);
				num = NormalFloat_Float16_evaluate_normalization_shift.Invoke(This, FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_get_mantissa.Invoke((Fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva)));
				This->Mantissa = (short)((ushort)FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_get_mantissa.Invoke((Fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva)) << num);
				This->Exponent = -14 - num;
				Llvm_lifetime_end_p0.Invoke(4L, &num);
			}
			else
			{
				checked
				{
					This->Exponent = unchecked((ushort)FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_get_biased_exponent.Invoke((Fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva))) - 15;
				}
				This->Mantissa = (short)(0x400 | (ushort)FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_get_mantissa.Invoke((Fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva)));
			}
		}
	}
}
