using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_Equals_hd8jru
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internaleqENS1_9FPStorageILNS0_6FPTypeE4EE8TypedIntIiEES6_")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::operator==(__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)4>::TypedInt<int>, __llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)4>::TypedInt<int>)")]
	[CleanName("Internal_Equals")]
	public static bool Invoke([MangledName("a.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)4>::TypedInt<int>")] int A, [MangledName("b.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)4>::TypedInt<int>")] int B)
	{
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2 = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt.field_0 = A;
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0 = B;
		return fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt.field_0 == fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0;
	}
}
