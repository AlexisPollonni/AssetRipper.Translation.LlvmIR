using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FModDivisionSimpleHelper_unsigned_long_execute
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic24FModDivisionSimpleHelperImE7executeEiimm")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::generic::FModDivisionSimpleHelper<unsigned long>::execute(int, int, unsigned long, unsigned long)")]
	public static long Invoke([NativeType("int")] int exp_diff, [NativeType("int")] int sides_zeroes_count, [NativeType("unsigned long")] long m_x, [NativeType("unsigned long")] long m_y)
	{
		int num = exp_diff;
		long num2 = m_x;
		while (num > sides_zeroes_count)
		{
			num -= sides_zeroes_count;
			num2 = unchecked((long)((ulong)(num2 << (int)(uint)sides_zeroes_count) % (ulong)m_y));
		}
		return unchecked((long)((ulong)(num2 << (int)(uint)num) % (ulong)m_y));
	}
}
