using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class NormalFloat_long_double_mul2
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil11NormalFloatIeE4mul2Ei")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat<long double>::mul2(int) const")]
	public unsafe static void Invoke([MangledName("agg.result")] Fputil_NormalFloat_wqb3ie* Agg_result, [MangledName("this")] void* This, [MangledName("e")] int E)
	{
		Llvm_memset_p0_i64.Invoke(Agg_result, -86, 48L, isVolatile: false);
		Llvm_memcpy_p0_p0_i64.Invoke(Agg_result, This, 48L, isVolatile: false);
		Agg_result->Exponent += E;
	}
}
