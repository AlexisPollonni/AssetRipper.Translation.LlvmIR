using System;
using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal8FPRepSemILNS0_6FPTypeE3ENS0_6FPBitsIgEEE12is_quiet_nanEv")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepSem<(__llvm_libc_20_1_2_::fputil::FPType)3, __llvm_libc_20_1_2_::fputil::FPBits<__float128>>::is_quiet_nan() const")]
internal static partial class fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_quiet_nan_const
{
	public unsafe static bool Invoke(void* @this)
	{
		Int128 @int = default(Int128);
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent3 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		fputil_internal_FPRepSem_f94eua fputil_internal_FPRepSem_f94eua2 = default(fputil_internal_FPRepSem_f94eua);
		Int128 y = default(Int128);
		Struct_fiz2nb struct_fiz2nb = fputil_internal_FPStorage_fputil_FPType_3_exp_sig_bits_const.Invoke(@this);
		Int128* num = &@int;
		Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
		unchecked
		{
			*(long*)num = struct_fiz2nb2.field_0;
			byte* num2 = (byte*)(&@int) + 8u;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			*(long*)num2 = struct_fiz2nb3.field_1;
			Int128 x = @int;
			int field_ = fputil_internal_FPStorage_fputil_FPType_3_Exponent_inf.Invoke();
			fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent3.field_0.field_0 = field_;
			fputil_internal_FPStorage_fputil_FPType_3_BiasedExponent_BiasedExponent_fputil_internal_FPStorage_fputil_FPType_3_Exponent.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2, fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent3.field_0.field_0);
			Struct_fiz2nb struct_fiz2nb4 = fputil_internal_FPStorage_fputil_FPType_3_Significand_msb.Invoke();
			Int128* ptr = &fputil_internal_FPRepSem_f94eua2.FPStorage.field_0;
			Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
			((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb5.field_0;
			Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
			((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb6.field_1;
			Struct_fiz2nb struct_fiz2nb7 = fputil_internal_FPStorage_fputil_FPType_3_encode_fputil_internal_FPStorage_fputil_FPType_3_BiasedExponent_fputil_internal_FPStorage_fputil_FPType_3_Significand.Invoke(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2.field_0.field_0, *(long*)(&fputil_internal_FPRepSem_f94eua2), ((long*)(&fputil_internal_FPRepSem_f94eua2))[1]);
			Int128* num3 = &y;
			Struct_fiz2nb struct_fiz2nb8 = struct_fiz2nb7;
			*(long*)num3 = struct_fiz2nb8.field_0;
			byte* num4 = (byte*)(&y) + 8u;
			Struct_fiz2nb struct_fiz2nb9 = struct_fiz2nb7;
			*(long*)num4 = struct_fiz2nb9.field_1;
			return NumericHelper.IntCmpUge(x, y);
		}
	}
}
