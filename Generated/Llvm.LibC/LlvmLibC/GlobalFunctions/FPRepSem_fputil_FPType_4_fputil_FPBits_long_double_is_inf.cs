using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_inf
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal8FPRepSemILNS0_6FPTypeE4ENS0_6FPBitsIeEEE6is_infEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepSem<(__llvm_libc_20_1_2_::fputil::FPType)4, __llvm_libc_20_1_2_::fputil::FPBits<long double>>::is_inf() const")]
	public unsafe static bool Invoke([MangledName("this")] void* This)
	{
		Int128 @int = default(Int128);
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2 = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		Fputil_internal_FPRepSem_f94eua fputil_internal_FPRepSem_f94eua = default(Fputil_internal_FPRepSem_f94eua);
		Int128 y = default(Int128);
		Struct_fiz2nb struct_fiz2nb = FPStorage_fputil_FPType_4_exp_sig_bits.Invoke(This);
		Int128* num = &@int;
		Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
		unchecked
		{
			*(long*)num = struct_fiz2nb2.field_0;
			byte* num2 = (byte*)(&@int) + 8u;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			*(long*)num2 = struct_fiz2nb3.field_1;
			Int128 x = @int;
			int field_ = Exponent_inf_588mpc.Invoke();
			fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2.field_0.field_0 = field_;
			BiasedExponent_Constructor_w6s8mj.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent, fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2.field_0.field_0);
			Struct_fiz2nb struct_fiz2nb4 = Significand_msb_disqcp.Invoke();
			Int128* ptr = &fputil_internal_FPRepSem_f94eua.FPStorage.field_0;
			Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
			((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb5.field_0;
			Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
			((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb6.field_1;
			Struct_fiz2nb struct_fiz2nb7 = FPStorage_fputil_FPType_4_encode.Invoke(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent.field_0.field_0, *(long*)(&fputil_internal_FPRepSem_f94eua), ((long*)(&fputil_internal_FPRepSem_f94eua))[1]);
			Int128* num3 = &y;
			Struct_fiz2nb struct_fiz2nb8 = struct_fiz2nb7;
			*(long*)num3 = struct_fiz2nb8.field_0;
			byte* num4 = (byte*)(&y) + 8u;
			Struct_fiz2nb struct_fiz2nb9 = struct_fiz2nb7;
			*(long*)num4 = struct_fiz2nb9.field_1;
			return NumericHelper.IntCmpEq(x, y);
		}
	}
}
