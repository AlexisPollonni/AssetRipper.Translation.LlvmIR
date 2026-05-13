using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal8FPRepSemILNS0_6FPTypeE4ENS0_6FPBitsIeEEE6is_nanEv")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepSem<(__llvm_libc_20_1_2_::fputil::FPType)4, __llvm_libc_20_1_2_::fputil::FPBits<long double>>::is_nan() const")]
internal static partial class fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_nan_const
{
	public unsafe static bool Invoke(void* @this)
	{
		Int128 @int = default(Int128);
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent3 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		Int128 y = default(Int128);
		Int128 int2 = default(Int128);
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent4 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent5 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		Int128 y2 = default(Int128);
		Int128 int3 = default(Int128);
		fputil_internal_FPRepSem_f94eua fputil_internal_FPRepSem_f94eua2 = default(fputil_internal_FPRepSem_f94eua);
		Int128 y3 = default(Int128);
		Struct_fiz2nb struct_fiz2nb = fputil_internal_FPStorage_fputil_FPType_4_exp_bits_const.Invoke(@this);
		Int128* num = &@int;
		Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
		unchecked
		{
			*(long*)num = struct_fiz2nb2.field_0;
			byte* num2 = (byte*)(&@int) + 8u;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			*(long*)num2 = struct_fiz2nb3.field_1;
			Int128 x = @int;
			int field_ = fputil_internal_FPStorage_fputil_FPType_4_Exponent_inf.Invoke();
			fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent3.field_0.field_0 = field_;
			fputil_internal_FPStorage_fputil_FPType_4_BiasedExponent_BiasedExponent_fputil_internal_FPStorage_fputil_FPType_4_Exponent.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2, fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent3.field_0.field_0);
			Struct_fiz2nb struct_fiz2nb4 = fputil_internal_FPStorage_fputil_FPType_4_encode_fputil_internal_FPStorage_fputil_FPType_4_BiasedExponent.Invoke(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2.field_0.field_0);
			Int128* num3 = &y;
			Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
			*(long*)num3 = struct_fiz2nb5.field_0;
			byte* num4 = (byte*)(&y) + 8u;
			Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
			*(long*)num4 = struct_fiz2nb6.field_1;
			if (NumericHelper.IntCmpEq(x, y))
			{
				return (byte)((fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_inf_const.Invoke(@this) ? 1u : 0u) ^ 0xFFFFFFFFu) != 0;
			}
			Struct_fiz2nb struct_fiz2nb7 = fputil_internal_FPStorage_fputil_FPType_4_exp_bits_const.Invoke(@this);
			Int128* num5 = &int2;
			Struct_fiz2nb struct_fiz2nb8 = struct_fiz2nb7;
			*(long*)num5 = struct_fiz2nb8.field_0;
			byte* num6 = (byte*)(&int2) + 8u;
			Struct_fiz2nb struct_fiz2nb9 = struct_fiz2nb7;
			*(long*)num6 = struct_fiz2nb9.field_1;
			Int128 x2 = int2;
			int field_2 = fputil_internal_FPStorage_fputil_FPType_4_Exponent_subnormal.Invoke();
			fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent5.field_0.field_0 = field_2;
			fputil_internal_FPStorage_fputil_FPType_4_BiasedExponent_BiasedExponent_fputil_internal_FPStorage_fputil_FPType_4_Exponent.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent4, fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent5.field_0.field_0);
			Struct_fiz2nb struct_fiz2nb10 = fputil_internal_FPStorage_fputil_FPType_4_encode_fputil_internal_FPStorage_fputil_FPType_4_BiasedExponent.Invoke(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent4.field_0.field_0);
			Int128* num7 = &y2;
			Struct_fiz2nb struct_fiz2nb11 = struct_fiz2nb10;
			*(long*)num7 = struct_fiz2nb11.field_0;
			byte* num8 = (byte*)(&y2) + 8u;
			Struct_fiz2nb struct_fiz2nb12 = struct_fiz2nb10;
			*(long*)num8 = struct_fiz2nb12.field_1;
			if (NumericHelper.IntCmpNe(x2, y2))
			{
				Struct_fiz2nb struct_fiz2nb13 = fputil_internal_FPStorage_fputil_FPType_4_sig_bits_const.Invoke(@this);
				Int128* num9 = &int3;
				Struct_fiz2nb struct_fiz2nb14 = struct_fiz2nb13;
				*(long*)num9 = struct_fiz2nb14.field_0;
				byte* num10 = (byte*)(&int3) + 8u;
				Struct_fiz2nb struct_fiz2nb15 = struct_fiz2nb13;
				*(long*)num10 = struct_fiz2nb15.field_1;
				Int128 x3 = int3;
				Struct_fiz2nb struct_fiz2nb16 = fputil_internal_FPStorage_fputil_FPType_4_Significand_msb.Invoke();
				Int128* ptr = &fputil_internal_FPRepSem_f94eua2.FPStorage.field_0;
				Struct_fiz2nb struct_fiz2nb17 = struct_fiz2nb16;
				((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb17.field_0;
				Struct_fiz2nb struct_fiz2nb18 = struct_fiz2nb16;
				((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb18.field_1;
				Struct_fiz2nb struct_fiz2nb19 = fputil_internal_FPStorage_fputil_FPType_4_encode_fputil_internal_FPStorage_fputil_FPType_4_Significand.Invoke(*(long*)(&fputil_internal_FPRepSem_f94eua2), ((long*)(&fputil_internal_FPRepSem_f94eua2))[1]);
				Int128* num11 = &y3;
				Struct_fiz2nb struct_fiz2nb20 = struct_fiz2nb19;
				*(long*)num11 = struct_fiz2nb20.field_0;
				byte* num12 = (byte*)(&y3) + 8u;
				Struct_fiz2nb struct_fiz2nb21 = struct_fiz2nb19;
				*(long*)num12 = struct_fiz2nb21.field_1;
				return NumericHelper.IntCmpEq(NumericHelper.BitwiseAnd(x3, y3), 0L);
			}
			return false;
		}
	}
}
