using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Intrinsics.Unimplemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil15nearest_integerEf")]
[DemangledName("__llvm_libc_20_1_2_::fputil::nearest_integer(float)")]
internal static partial class fputil_nearest_integer_float
{
	public unsafe static float Invoke(float x)
	{
		InlineArray4_Single inlineArray4_Single = default(InlineArray4_Single);
		InlineArray4_Single buffer = default(InlineArray4_Single);
		llvm_lifetime_start_p0.Invoke(16L, &inlineArray4_Single);
		inlineArray4_Single = InlineArrayHelper.Create<InlineArray4_Single, float>(new float[4]
		{
			float.NaN,
			float.NaN,
			float.NaN,
			float.NaN
		});
		inlineArray4_Single = mm_set_ss_float.Invoke(x);
		llvm_lifetime_start_p0.Invoke(16L, &buffer);
		buffer = InlineArrayHelper.Create<InlineArray4_Single, float>(new float[4]
		{
			float.NaN,
			float.NaN,
			float.NaN,
			float.NaN
		});
		buffer = llvm_x86_sse41_round_ss.Invoke(inlineArray4_Single, inlineArray4_Single, 8);
		float result = buffer.ExtractElement<InlineArray4_Single, float>(0);
		llvm_lifetime_end_p0.Invoke(16L, &buffer);
		llvm_lifetime_end_p0.Invoke(16L, &inlineArray4_Single);
		return result;
	}
}
