using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11NormalFloatIgE14init_from_bitsENS0_6FPBitsIgEE")]
[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat<__float128>::init_from_bits(__llvm_libc_20_1_2_::fputil::FPBits<__float128>)")]
internal static partial class fputil_NormalFloat_float128_init_from_bits_fputil_FPBits_float128
{
	public unsafe static void Invoke(fputil_NormalFloat_wqb3ie* @this, [MangledName("bits.coerce0")] long bits, [MangledName("bits.coerce1")] long shift)
	{
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		int num = 0;
		Int128 @int = default(Int128);
		Int128 int2 = default(Int128);
		Int128 x = default(Int128);
		Int128 int3 = default(Int128);
		unchecked
		{
			*(long*)(&fputil_FPBits_ubgsi3) = bits;
			((long*)(&fputil_FPBits_ubgsi3))[1] = shift;
			llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb8);
			anon_izyfb8.val = fputil_internal_FPStorage_fputil_FPType_3_sign_const.Invoke(&fputil_FPBits_ubgsi3);
			llvm_memcpy_p0_p0_i64.Invoke(&@this->sign, &anon_izyfb8, 1L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
			if (fputil_internal_FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_is_inf_or_nan_const.Invoke(&fputil_FPBits_ubgsi3) || fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_zero_const.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi3)))
			{
				@this->exponent = 0;
				@this->mantissa = 0L;
			}
			else if (fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_subnormal_const.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi3)))
			{
				llvm_lifetime_start_p0.Invoke(4L, &num);
				Struct_fiz2nb struct_fiz2nb = fputil_internal_FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_get_mantissa_const.Invoke(&fputil_FPBits_ubgsi3);
				Int128* num2 = &@int;
				Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
				*(long*)num2 = struct_fiz2nb2.field_0;
				byte* num3 = (byte*)(&@int) + 8u;
				Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
				*(long*)num3 = struct_fiz2nb3.field_1;
				int2 = @int;
				num = fputil_NormalFloat_float128_evaluate_normalization_shift_unsigned_int128.Invoke(@this, *(long*)(&int2), ((long*)(&int2))[1]);
				Struct_fiz2nb struct_fiz2nb4 = fputil_internal_FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_get_mantissa_const.Invoke(&fputil_FPBits_ubgsi3);
				Int128* num4 = &x;
				Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
				*(long*)num4 = struct_fiz2nb5.field_0;
				byte* num5 = (byte*)(&x) + 8u;
				Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
				*(long*)num5 = struct_fiz2nb6.field_1;
				@this->mantissa = NumericHelper.ShiftLeft(x, (Int128)(UInt128)(uint)num);
				@this->exponent = -16382 - num;
				llvm_lifetime_end_p0.Invoke(4L, &num);
			}
			else
			{
				Struct_fiz2nb struct_fiz2nb7;
				Int128* num6;
				Struct_fiz2nb struct_fiz2nb8;
				checked
				{
					@this->exponent = unchecked((ushort)fputil_internal_FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_get_biased_exponent_const.Invoke(&fputil_FPBits_ubgsi3)) - 16383;
					struct_fiz2nb7 = fputil_internal_FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_get_mantissa_const.Invoke(&fputil_FPBits_ubgsi3);
					num6 = &int3;
					struct_fiz2nb8 = struct_fiz2nb7;
				}
				*(long*)num6 = struct_fiz2nb8.field_0;
				byte* num7 = (byte*)(&int3) + 8u;
				Struct_fiz2nb struct_fiz2nb9 = struct_fiz2nb7;
				*(long*)num7 = struct_fiz2nb9.field_1;
				@this->mantissa = NumericHelper.BitwiseOr(y: int3, x: 0L);
			}
		}
	}
}
