using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil11NormalFloatIgE4mul2Ei")]
[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat<__float128>::mul2(int) const")]
internal static partial class fputil_NormalFloat_float128_mul2_int_const
{
	public unsafe static void Invoke([MangledName("agg.result")] fputil_NormalFloat_wqb3ie* agg_result, fputil_NormalFloat_wqb3ie* @this, int e)
	{
		llvm_memset_p0_i64.Invoke(agg_result, -86, 48L, isVolatile: false);
		llvm_memcpy_p0_p0_i64.Invoke(agg_result, @this, 48L, isVolatile: false);
		agg_result->exponent += e;
	}
}
