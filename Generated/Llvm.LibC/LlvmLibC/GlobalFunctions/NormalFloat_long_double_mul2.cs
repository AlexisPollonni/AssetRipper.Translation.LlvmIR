using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class NormalFloat_long_double_mul2
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil11NormalFloatIeE4mul2Ei")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat<long double>::mul2(int) const")]
	public unsafe static void Invoke([MangledName("agg.result")] fputil_NormalFloat_wqb3ie* agg_result, void* @this, int e)
	{
		llvm_memset_p0_i64.Invoke(agg_result, -86, 48L, isVolatile: false);
		llvm_memcpy_p0_p0_i64.Invoke(agg_result, @this, 48L, isVolatile: false);
		agg_result->exponent += e;
	}
}
