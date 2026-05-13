using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internaleqENS1_9FPStorageILNS0_6FPTypeE0EE8TypedIntIiEES6_")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::operator==(__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)0>::TypedInt<int>, __llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)0>::TypedInt<int>)")]
internal static partial class fputil_internal_operator_fputil_internal_FPStorage_fputil_FPType_0_TypedInt_int_fputil_internal_FPStorage_fputil_FPType_0_TypedInt_int
{
	public static bool Invoke([MangledName("a.coerce")] int a, [MangledName("b.coerce")] int b)
	{
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt3 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0 = a;
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt3.field_0 = b;
		return fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0 == fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt3.field_0;
	}
}
