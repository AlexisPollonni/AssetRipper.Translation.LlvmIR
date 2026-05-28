using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_BitwiseOr_ii4m73
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internalorENS1_9FPStorageILNS0_6FPTypeE1EE11SignificandES5_")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::operator|(__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)1>::Significand, __llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)1>::Significand)")]
	[CleanName("Internal_BitwiseOr")]
	public unsafe static int Invoke([MangledName("a.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)1>::Significand")] int A, [MangledName("b.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)1>::Significand")] int B)
	{
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2 = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent3 = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2.field_0.field_0 = A;
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent3.field_0.field_0 = B;
		Significand_Constructor_vz3zem.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent, TypedInt_unsigned_int_to_storage_type_c8hg2g.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2) | TypedInt_unsigned_int_to_storage_type_c8hg2g.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent3));
		return fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent.field_0.field_0;
	}
}
