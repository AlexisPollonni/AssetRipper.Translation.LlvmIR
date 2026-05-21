using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_quiet_nan
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal8FPRepSemILNS0_6FPTypeE4ENS0_6FPBitsIeEEE12is_quiet_nanEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepSem<(__llvm_libc_20_1_2_::fputil::FPType)4, __llvm_libc_20_1_2_::fputil::FPBits<long double>>::is_quiet_nan() const")]
	public unsafe static bool Invoke(void* @this)
	{
		Int128 @int = default(Int128);
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent3 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		fputil_internal_FPRepSem_f94eua fputil_internal_FPRepSem_f94eua2 = default(fputil_internal_FPRepSem_f94eua);
		fputil_internal_FPRepSem_f94eua fputil_internal_FPRepSem_f94eua3 = default(fputil_internal_FPRepSem_f94eua);
		fputil_internal_FPRepSem_f94eua fputil_internal_FPRepSem_f94eua4 = default(fputil_internal_FPRepSem_f94eua);
		fputil_internal_FPRepSem_f94eua fputil_internal_FPRepSem_f94eua5 = default(fputil_internal_FPRepSem_f94eua);
		Int128 y = default(Int128);
		Struct_fiz2nb struct_fiz2nb = FPStorage_fputil_FPType_4_exp_sig_bits.Invoke(@this);
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
			fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent3.field_0.field_0 = field_;
			BiasedExponent_Constructor_w6s8mj.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2, fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent3.field_0.field_0);
			Struct_fiz2nb struct_fiz2nb4 = Significand_msb_disqcp.Invoke();
			Int128* ptr = &fputil_internal_FPRepSem_f94eua3.FPStorage.field_0;
			Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
			((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb5.field_0;
			Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
			((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb6.field_1;
			Struct_fiz2nb struct_fiz2nb7 = Significand_msb_disqcp.Invoke();
			Int128* ptr2 = &fputil_internal_FPRepSem_f94eua5.FPStorage.field_0;
			Struct_fiz2nb struct_fiz2nb8 = struct_fiz2nb7;
			((Struct_fiz2nb*)ptr2)->field_0 = struct_fiz2nb8.field_0;
			Struct_fiz2nb struct_fiz2nb9 = struct_fiz2nb7;
			((Struct_fiz2nb*)ptr2)->field_1 = struct_fiz2nb9.field_1;
			Struct_fiz2nb struct_fiz2nb10 = internal_RightShift_7akpcn.Invoke(*(long*)(&fputil_internal_FPRepSem_f94eua5), ((long*)(&fputil_internal_FPRepSem_f94eua5))[1], 1);
			Int128* ptr3 = &fputil_internal_FPRepSem_f94eua4.FPStorage.field_0;
			Struct_fiz2nb struct_fiz2nb11 = struct_fiz2nb10;
			((Struct_fiz2nb*)ptr3)->field_0 = struct_fiz2nb11.field_0;
			Struct_fiz2nb struct_fiz2nb12 = struct_fiz2nb10;
			((Struct_fiz2nb*)ptr3)->field_1 = struct_fiz2nb12.field_1;
			Struct_fiz2nb struct_fiz2nb13 = internal_BitwiseOr_qsntgr.Invoke(*(long*)(&fputil_internal_FPRepSem_f94eua3), ((long*)(&fputil_internal_FPRepSem_f94eua3))[1], *(long*)(&fputil_internal_FPRepSem_f94eua4), ((long*)(&fputil_internal_FPRepSem_f94eua4))[1]);
			Int128* ptr4 = &fputil_internal_FPRepSem_f94eua2.FPStorage.field_0;
			Struct_fiz2nb struct_fiz2nb14 = struct_fiz2nb13;
			((Struct_fiz2nb*)ptr4)->field_0 = struct_fiz2nb14.field_0;
			Struct_fiz2nb struct_fiz2nb15 = struct_fiz2nb13;
			((Struct_fiz2nb*)ptr4)->field_1 = struct_fiz2nb15.field_1;
			Struct_fiz2nb struct_fiz2nb16 = FPStorage_fputil_FPType_4_encode.Invoke(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2.field_0.field_0, *(long*)(&fputil_internal_FPRepSem_f94eua2), ((long*)(&fputil_internal_FPRepSem_f94eua2))[1]);
			Int128* num3 = &y;
			Struct_fiz2nb struct_fiz2nb17 = struct_fiz2nb16;
			*(long*)num3 = struct_fiz2nb17.field_0;
			byte* num4 = (byte*)(&y) + 8u;
			Struct_fiz2nb struct_fiz2nb18 = struct_fiz2nb16;
			*(long*)num4 = struct_fiz2nb18.field_1;
			return NumericHelper.IntCmpUge(x, y);
		}
	}
}
