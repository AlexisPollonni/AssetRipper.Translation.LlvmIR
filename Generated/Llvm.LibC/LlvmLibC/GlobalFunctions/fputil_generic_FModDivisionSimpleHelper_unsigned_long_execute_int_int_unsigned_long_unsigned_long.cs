using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic24FModDivisionSimpleHelperImE7executeEiimm")]
[DemangledName("__llvm_libc_20_1_2_::fputil::generic::FModDivisionSimpleHelper<unsigned long>::execute(int, int, unsigned long, unsigned long)")]
internal static partial class fputil_generic_FModDivisionSimpleHelper_unsigned_long_execute_int_int_unsigned_long_unsigned_long
{
	public static long Invoke(int exp_diff, int sides_zeroes_count, long m_x, long m_y)
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
