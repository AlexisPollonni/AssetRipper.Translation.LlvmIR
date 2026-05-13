using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_12cmp_uint32_tEjj")]
[DemangledName("__llvm_libc_20_1_2_::cmp_uint32_t(unsigned int, unsigned int)")]
internal static partial class cmp_uint32_t_unsigned_int_unsigned_int
{
	public unsafe static int Invoke(int a, int b)
	{
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = unchecked((long)(uint)a) - unchecked((long)(uint)b);
		StrictIntegralType_int_StrictIntegralType_int_false_int.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2, unchecked((int)((num >> 1) | (num & 0xFFFFL))));
		llvm_lifetime_end_p0.Invoke(8L, &num);
		return fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0;
	}
}
