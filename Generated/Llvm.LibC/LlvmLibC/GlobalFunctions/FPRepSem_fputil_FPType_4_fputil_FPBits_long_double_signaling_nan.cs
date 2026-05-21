using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_signaling_nan
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal8FPRepSemILNS0_6FPTypeE4ENS0_6FPBitsIeEEE13signaling_nanENS_4SignEo")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepSem<(__llvm_libc_20_1_2_::fputil::FPType)4, __llvm_libc_20_1_2_::fputil::FPBits<long double>>::signaling_nan(__llvm_libc_20_1_2_::Sign, unsigned __int128)")]
	public unsafe static Struct_fiz2nb Invoke([MangledName("sign.coerce")] sbyte Sign, [MangledName("v.coerce0")][NativeType("__llvm_libc_20_1_2_::Sign")] long V, [MangledName("v.coerce1")][NativeType("unsigned __int128")] long V_coerce1)
	{
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Int128 @int = default(Int128);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent = default(Llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		Llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2 = default(Llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		Llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua = default(Llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua);
		Llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua2 = default(Llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua);
		Llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua3 = default(Llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua);
		Int128 int2 = default(Int128);
		Llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua4 = default(Llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua);
		Int128 int3 = default(Int128);
		Int128 int4 = default(Int128);
		anon_izyfb.Val = Sign;
		unchecked
		{
			*(long*)(&@int) = V;
			((long*)(&@int))[1] = V_coerce1;
			Int128 int5 = @int;
			Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, &anon_izyfb, 1L, isVolatile: false);
			int field_ = Exponent_inf_588mpc.Invoke();
			llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2.field_0.field_0 = field_;
			BiasedExponent_Constructor_w6s8mj.Invoke(&llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent, llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2.field_0.field_0);
			Struct_fiz2nb struct_fiz2nb = Significand_msb_disqcp.Invoke();
			Int128* ptr = &llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua2.FPStorage.field_0;
			Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
			((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb2.field_0;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb3.field_1;
			if (NumericHelper.IntCmpNe(int5, 0L))
			{
				int2 = int5;
				Significand_Constructor_j3ersh.Invoke(&llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua3, *(long*)(&int2), ((long*)(&int2))[1]);
			}
			else
			{
				Struct_fiz2nb struct_fiz2nb4 = Significand_msb_disqcp.Invoke();
				Int128* ptr2 = &llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua4.FPStorage.field_0;
				Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
				((Struct_fiz2nb*)ptr2)->field_0 = struct_fiz2nb5.field_0;
				Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
				((Struct_fiz2nb*)ptr2)->field_1 = struct_fiz2nb6.field_1;
				Struct_fiz2nb struct_fiz2nb7 = Internal_RightShift_7akpcn.Invoke(*(long*)(&llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua4), ((long*)(&llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua4))[1], 2);
				Int128* ptr3 = &llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua3.FPStorage.field_0;
				Struct_fiz2nb struct_fiz2nb8 = struct_fiz2nb7;
				((Struct_fiz2nb*)ptr3)->field_0 = struct_fiz2nb8.field_0;
				Struct_fiz2nb struct_fiz2nb9 = struct_fiz2nb7;
				((Struct_fiz2nb*)ptr3)->field_1 = struct_fiz2nb9.field_1;
			}
			Struct_fiz2nb struct_fiz2nb10 = Internal_BitwiseOr_qsntgr.Invoke(*(long*)(&llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua2), ((long*)(&llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua2))[1], *(long*)(&llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua3), ((long*)(&llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua3))[1]);
			Int128* ptr4 = &llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua.FPStorage.field_0;
			Struct_fiz2nb struct_fiz2nb11 = struct_fiz2nb10;
			((Struct_fiz2nb*)ptr4)->field_0 = struct_fiz2nb11.field_0;
			Struct_fiz2nb struct_fiz2nb12 = struct_fiz2nb10;
			((Struct_fiz2nb*)ptr4)->field_1 = struct_fiz2nb12.field_1;
			Struct_fiz2nb struct_fiz2nb13 = FPStorage_fputil_FPType_4_encode.Invoke(anon_izyfb2.Val, llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent.field_0.field_0, *(long*)(&llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua), ((long*)(&llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua))[1]);
			Int128* num = &int3;
			Struct_fiz2nb struct_fiz2nb14 = struct_fiz2nb13;
			*(long*)num = struct_fiz2nb14.field_0;
			byte* num2 = (byte*)(&int3) + 8u;
			Struct_fiz2nb struct_fiz2nb15 = struct_fiz2nb13;
			*(long*)num2 = struct_fiz2nb15.field_1;
			int4 = int3;
			FPBits_long_double_FPBits_unsigned_int128.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi, *(long*)(&int4), ((long*)(&int4))[1]);
			return *(Struct_fiz2nb*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi.Val.Data.FPStorage.field_0);
		}
	}
}
