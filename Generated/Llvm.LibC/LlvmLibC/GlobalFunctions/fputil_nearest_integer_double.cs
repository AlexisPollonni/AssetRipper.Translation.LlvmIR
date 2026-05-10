using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Intrinsics.Unimplemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil15nearest_integerEd")]
[DemangledName("__llvm_libc_20_1_2_::fputil::nearest_integer(double)")]
internal static partial class fputil_nearest_integer_double
{
	public unsafe static double Invoke(double x)
	{
		InlineArray2_Double inlineArray2_Double = default(InlineArray2_Double);
		InlineArray2_Double buffer = default(InlineArray2_Double);
		llvm_lifetime_start_p0.Invoke(16L, &inlineArray2_Double);
		inlineArray2_Double = InlineArrayHelper.Create<InlineArray2_Double, double>(new double[2]
		{
			double.NaN,
			double.NaN
		});
		inlineArray2_Double = mm_set_sd_double.Invoke(x);
		llvm_lifetime_start_p0.Invoke(16L, &buffer);
		buffer = InlineArrayHelper.Create<InlineArray2_Double, double>(new double[2]
		{
			double.NaN,
			double.NaN
		});
		buffer = llvm_x86_sse41_round_sd.Invoke(inlineArray2_Double, inlineArray2_Double, 8);
		double result = buffer.ExtractElement<InlineArray2_Double, double>(0);
		llvm_lifetime_end_p0.Invoke(16L, &buffer);
		llvm_lifetime_end_p0.Invoke(16L, &inlineArray2_Double);
		return result;
	}
}
