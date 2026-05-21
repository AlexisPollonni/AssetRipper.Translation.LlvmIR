using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class NormalFloat_long_double_init_from_bits
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11NormalFloatIeE14init_from_bitsENS0_6FPBitsIeEE")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat<long double>::init_from_bits(__llvm_libc_20_1_2_::fputil::FPBits<long double>)")]
	public unsafe static void Invoke([MangledName("this")] void* This, [MangledName("bits.coerce0")] long Bits, [MangledName("bits.coerce1")] long Normalization_shift)
	{
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		int num = 0;
		Int128 @int = default(Int128);
		Int128 int2 = default(Int128);
		Int128 x = default(Int128);
		Int128 int3 = default(Int128);
		Int128 int4 = default(Int128);
		unchecked
		{
			*(long*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi) = Bits;
			((long*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi))[1] = Normalization_shift;
			Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb);
			anon_izyfb.Val = FPStorage_fputil_FPType_4_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
			Llvm_memcpy_p0_p0_i64.Invoke(&((Llvm_libc_20_1_2_fputil_NormalFloat_wqb3ie*)This)->Sign, &anon_izyfb, 1L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb);
			if (FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_is_inf_or_nan.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi) || FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_zero.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi))
			{
				((Llvm_libc_20_1_2_fputil_NormalFloat_wqb3ie*)This)->Exponent = 0;
				((Llvm_libc_20_1_2_fputil_NormalFloat_wqb3ie*)This)->Mantissa = 0L;
			}
			else if (FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_subnormal.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi))
			{
				if (!FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_get_implicit_bit.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi))
				{
					Llvm_lifetime_start_p0.Invoke(4L, &num);
					Struct_fiz2nb struct_fiz2nb = FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_mantissa.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
					Int128* num2 = &@int;
					Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
					*(long*)num2 = struct_fiz2nb2.field_0;
					byte* num3 = (byte*)(&@int) + 8u;
					Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
					*(long*)num3 = struct_fiz2nb3.field_1;
					int2 = @int;
					num = NormalFloat_long_double_evaluate_normalization_shift.Invoke(This, *(long*)(&int2), ((long*)(&int2))[1]);
					((Llvm_libc_20_1_2_fputil_NormalFloat_wqb3ie*)This)->Exponent = checked(-16382 - num);
					Struct_fiz2nb struct_fiz2nb4 = FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_mantissa.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
					Int128* num4 = &x;
					Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
					*(long*)num4 = struct_fiz2nb5.field_0;
					byte* num5 = (byte*)(&x) + 8u;
					Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
					*(long*)num5 = struct_fiz2nb6.field_1;
					((Llvm_libc_20_1_2_fputil_NormalFloat_wqb3ie*)This)->Mantissa = NumericHelper.ShiftLeft(x, (Int128)(UInt128)(uint)num);
					Llvm_lifetime_end_p0.Invoke(4L, &num);
				}
				else
				{
					((Llvm_libc_20_1_2_fputil_NormalFloat_wqb3ie*)This)->Exponent = -16382;
					Struct_fiz2nb struct_fiz2nb7 = FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_mantissa.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
					Int128* num6 = &int3;
					Struct_fiz2nb struct_fiz2nb8 = struct_fiz2nb7;
					*(long*)num6 = struct_fiz2nb8.field_0;
					byte* num7 = (byte*)(&int3) + 8u;
					Struct_fiz2nb struct_fiz2nb9 = struct_fiz2nb7;
					*(long*)num7 = struct_fiz2nb9.field_1;
					((Llvm_libc_20_1_2_fputil_NormalFloat_wqb3ie*)This)->Mantissa = NumericHelper.BitwiseOr(y: int3, x: long.MinValue);
				}
			}
			else if (!FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_get_implicit_bit.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi))
			{
				((Llvm_libc_20_1_2_fputil_NormalFloat_wqb3ie*)This)->Exponent = 0;
				((Llvm_libc_20_1_2_fputil_NormalFloat_wqb3ie*)This)->Mantissa = 0L;
			}
			else
			{
				((Llvm_libc_20_1_2_fputil_NormalFloat_wqb3ie*)This)->Exponent = checked(unchecked((ushort)FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_biased_exponent.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi)) - 16383);
				Struct_fiz2nb struct_fiz2nb10 = FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_mantissa.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
				Int128* num8 = &int4;
				Struct_fiz2nb struct_fiz2nb11 = struct_fiz2nb10;
				*(long*)num8 = struct_fiz2nb11.field_0;
				byte* num9 = (byte*)(&int4) + 8u;
				Struct_fiz2nb struct_fiz2nb12 = struct_fiz2nb10;
				*(long*)num9 = struct_fiz2nb12.field_1;
				((Llvm_libc_20_1_2_fputil_NormalFloat_wqb3ie*)This)->Mantissa = NumericHelper.BitwiseOr(y: int4, x: long.MinValue);
			}
		}
	}
}
