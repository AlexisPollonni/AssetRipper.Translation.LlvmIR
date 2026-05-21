using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class NormalFloat_float128_init_from_bits
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11NormalFloatIgE14init_from_bitsENS0_6FPBitsIgEE")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat<__float128>::init_from_bits(__llvm_libc_20_1_2_::fputil::FPBits<__float128>)")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_fputil_NormalFloat_wqb3ie* This, [MangledName("bits.coerce0")] long Bits, [MangledName("bits.coerce1")] long Shift)
	{
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		int num = 0;
		Int128 @int = default(Int128);
		Int128 int2 = default(Int128);
		Int128 x = default(Int128);
		Int128 int3 = default(Int128);
		unchecked
		{
			*(long*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi) = Bits;
			((long*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi))[1] = Shift;
			Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb);
			anon_izyfb.Val = FPStorage_fputil_FPType_3_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
			Llvm_memcpy_p0_p0_i64.Invoke(&This->Sign, &anon_izyfb, 1L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb);
			if (FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_is_inf_or_nan.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi) || FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_zero.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi)))
			{
				This->Exponent = 0;
				This->Mantissa = 0L;
			}
			else if (FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_subnormal.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi)))
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num);
				Struct_fiz2nb struct_fiz2nb = FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_get_mantissa.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
				Int128* num2 = &@int;
				Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
				*(long*)num2 = struct_fiz2nb2.field_0;
				byte* num3 = (byte*)(&@int) + 8u;
				Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
				*(long*)num3 = struct_fiz2nb3.field_1;
				int2 = @int;
				num = NormalFloat_float128_evaluate_normalization_shift.Invoke(This, *(long*)(&int2), ((long*)(&int2))[1]);
				Struct_fiz2nb struct_fiz2nb4 = FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_get_mantissa.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
				Int128* num4 = &x;
				Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
				*(long*)num4 = struct_fiz2nb5.field_0;
				byte* num5 = (byte*)(&x) + 8u;
				Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
				*(long*)num5 = struct_fiz2nb6.field_1;
				This->Mantissa = NumericHelper.ShiftLeft(x, (Int128)(UInt128)(uint)num);
				This->Exponent = -16382 - num;
				Llvm_lifetime_end_p0.Invoke(4L, &num);
			}
			else
			{
				Struct_fiz2nb struct_fiz2nb7;
				Int128* num6;
				Struct_fiz2nb struct_fiz2nb8;
				checked
				{
					This->Exponent = unchecked((ushort)FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_get_biased_exponent.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi)) - 16383;
					struct_fiz2nb7 = FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_get_mantissa.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
					num6 = &int3;
					struct_fiz2nb8 = struct_fiz2nb7;
				}
				*(long*)num6 = struct_fiz2nb8.field_0;
				byte* num7 = (byte*)(&int3) + 8u;
				Struct_fiz2nb struct_fiz2nb9 = struct_fiz2nb7;
				*(long*)num7 = struct_fiz2nb9.field_1;
				This->Mantissa = NumericHelper.BitwiseOr(y: int3, x: 0L);
			}
		}
	}
}
