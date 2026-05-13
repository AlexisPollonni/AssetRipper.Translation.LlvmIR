using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic24FModDivisionSimpleHelperIjE7executeEiijj")]
[DemangledName("__llvm_libc_20_1_2_::fputil::generic::FModDivisionSimpleHelper<unsigned int>::execute(int, int, unsigned int, unsigned int)")]
internal static partial class fputil_generic_FModDivisionSimpleHelper_unsigned_int_execute_int_int_unsigned_int_unsigned_int
{
	public static int Invoke(int exp_diff, int sides_zeroes_count, int m_x, int m_y)
	{
		int num = exp_diff;
		int num2 = m_x;
		while (num > sides_zeroes_count)
		{
			num -= sides_zeroes_count;
			num2 = unchecked((int)((uint)(num2 << sides_zeroes_count) % (uint)m_y));
		}
		return unchecked((int)((uint)(num2 << num) % (uint)m_y));
	}
}
