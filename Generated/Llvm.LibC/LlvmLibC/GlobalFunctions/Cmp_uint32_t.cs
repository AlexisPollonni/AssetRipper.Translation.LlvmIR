using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cmp_uint32_t
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12cmp_uint32_tEjj")]
	[DemangledName("__llvm_libc_20_1_2_::cmp_uint32_t(unsigned int, unsigned int)")]
	public unsafe static int Invoke([MangledName("a")][NativeType("unsigned int")] int A, [MangledName("b")][NativeType("unsigned int")] int B)
	{
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		long num = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = unchecked((long)(uint)A) - unchecked((long)(uint)B);
		StrictIntegralType_int_StrictIntegralType_int_false.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt, unchecked((int)((num >> 1) | (num & 0xFFFFL))));
		Llvm_lifetime_end_p0.Invoke(8L, &num);
		return fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt.field_0;
	}
}
