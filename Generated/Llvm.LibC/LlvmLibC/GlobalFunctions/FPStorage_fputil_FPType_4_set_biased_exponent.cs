using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPStorage_fputil_FPType_4_set_biased_exponent
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE4EE19set_biased_exponentENS4_14BiasedExponentE")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)4>::set_biased_exponent(__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)4>::BiasedExponent)")]
	public unsafe static void Invoke([MangledName("this")] void* This, [MangledName("biased.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)4>::BiasedExponent")] int Biased)
	{
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2 = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		Int128 @int = default(Int128);
		Int128 field_ = default(Int128);
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent.field_0.field_0 = Biased;
		unchecked
		{
			Int128 field_2 = ((Fputil_internal_FPStorage_w3h7gw*)This)->field_0;
			Llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2, &fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent, 4L, isVolatile: false);
			Struct_fiz2nb struct_fiz2nb = FPStorage_fputil_FPType_4_encode.Invoke(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2.field_0.field_0);
			Int128* num = &@int;
			Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
			*(long*)num = struct_fiz2nb2.field_0;
			byte* num2 = (byte*)(&@int) + 8u;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			*(long*)num2 = struct_fiz2nb3.field_1;
			Int128 int2 = @int;
			Int128 int3 = field_2;
			long a = *(long*)(&int3);
			long b = ((long*)(&int3))[1];
			Int128 int4 = int2;
			long mask = *(long*)(&int4);
			long b_coerce = ((long*)(&int4))[1];
			Int128 int5 = 0L;
			Struct_fiz2nb struct_fiz2nb4 = FPStorage_fputil_FPType_4_merge.Invoke(a, b, mask, b_coerce, *(long*)(&int5), ((long*)(&int5))[1]);
			Int128* num3 = &field_;
			Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
			*(long*)num3 = struct_fiz2nb5.field_0;
			byte* num4 = (byte*)(&field_) + 8u;
			Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
			*(long*)num4 = struct_fiz2nb6.field_1;
			((Fputil_internal_FPStorage_w3h7gw*)This)->field_0 = field_;
		}
	}
}
