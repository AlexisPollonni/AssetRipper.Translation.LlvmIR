using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_16cmp_neq_uint64_tEmm")]
[DemangledName("__llvm_libc_20_1_2_::cmp_neq_uint64_t(unsigned long, unsigned long)")]
internal static partial class cmp_neq_uint64_t_unsigned_long_unsigned_long
{
	public unsafe static int Invoke(long a, long b)
	{
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		StrictIntegralType_int_StrictIntegralType_int_false_int.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2, InstructionHelper.Select(unchecked((ulong)a < (ulong)b), -5, 5));
		return fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0;
	}
}
