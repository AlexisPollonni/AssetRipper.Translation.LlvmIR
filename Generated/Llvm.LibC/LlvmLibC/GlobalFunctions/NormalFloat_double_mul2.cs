using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class NormalFloat_double_mul2
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil11NormalFloatIdE4mul2Ei")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat<double>::mul2(int) const")]
	public unsafe static void Invoke([MangledName("agg.result")] Fputil_NormalFloat_vc4yvk* Agg_result, [MangledName("this")] Fputil_NormalFloat_vc4yvk* This, [MangledName("e")] int E)
	{
		unchecked
		{
			*(int*)Agg_result = -1431655766;
			sbyte* ptr = (sbyte*)Agg_result + 4;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			ptr[3] = -86;
			((long*)Agg_result)[1] = -6148914691236517206L;
			((sbyte*)Agg_result)[16] = -86;
			sbyte* ptr2 = (sbyte*)Agg_result + 17;
			*ptr2 = -86;
			ptr2[1] = -86;
			ptr2[2] = -86;
			ptr2[3] = -86;
			ptr2[4] = -86;
			ptr2[5] = -86;
			ptr2[6] = -86;
			Llvm_memcpy_p0_p0_i64.Invoke(Agg_result, This, 24L, isVolatile: false);
		}
		Agg_result->Exponent += E;
	}
}
