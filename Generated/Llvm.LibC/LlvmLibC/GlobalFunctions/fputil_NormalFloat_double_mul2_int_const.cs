using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil11NormalFloatIdE4mul2Ei")]
[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat<double>::mul2(int) const")]
internal static partial class fputil_NormalFloat_double_mul2_int_const
{
	public unsafe static void Invoke([MangledName("agg.result")] fputil_NormalFloat_vc4yvk* agg_result, fputil_NormalFloat_vc4yvk* @this, int e)
	{
		unchecked
		{
			*(int*)agg_result = -1431655766;
			sbyte* ptr = (sbyte*)agg_result + 4;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			ptr[3] = -86;
			((long*)agg_result)[1] = -6148914691236517206L;
			((sbyte*)agg_result)[16] = -86;
			sbyte* ptr2 = (sbyte*)agg_result + 17;
			*ptr2 = -86;
			ptr2[1] = -86;
			ptr2[2] = -86;
			ptr2[3] = -86;
			ptr2[4] = -86;
			ptr2[5] = -86;
			ptr2[6] = -86;
			llvm_memcpy_p0_p0_i64.Invoke(agg_result, @this, 24L, isVolatile: false);
		}
		agg_result->exponent += e;
	}
}
