using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class NormalFloat_Float16_init_from_bits
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11NormalFloatIDF16_E14init_from_bitsENS0_6FPBitsIDF16_EE")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat<_Float16>::init_from_bits(__llvm_libc_20_1_2_::fputil::FPBits<_Float16>)")]
	public unsafe static void Invoke(fputil_NormalFloat_epbrnk* @this, [MangledName("bits.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::FPBits<_Float16>")] short bits)
	{
		fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		int num = 0;
		fputil_FPBits_2fahva2.FPRepImpl.FPRepSem.FPStorage.field_0 = bits;
		llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb8);
		anon_izyfb8.val = FPStorage_fputil_FPType_0_sign.Invoke(&fputil_FPBits_2fahva2);
		llvm_memcpy_p0_p0_i64.Invoke(&@this->sign, &anon_izyfb8, 1L, isVolatile: false);
		llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
		unchecked
		{
			if (FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_is_inf_or_nan.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva2)) || FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_zero.Invoke((fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva2)))
			{
				@this->exponent = 0;
				@this->mantissa = 0;
			}
			else if (FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_subnormal.Invoke((fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva2)))
			{
				llvm_lifetime_start_p0.Invoke(4L, &num);
				num = NormalFloat_Float16_evaluate_normalization_shift.Invoke(@this, FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_get_mantissa.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva2)));
				@this->mantissa = (short)((ushort)FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_get_mantissa.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva2)) << num);
				@this->exponent = -14 - num;
				llvm_lifetime_end_p0.Invoke(4L, &num);
			}
			else
			{
				checked
				{
					@this->exponent = unchecked((ushort)FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_get_biased_exponent.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva2))) - 15;
				}
				@this->mantissa = (short)(0x400 | (ushort)FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_get_mantissa.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva2)));
			}
		}
	}
}
