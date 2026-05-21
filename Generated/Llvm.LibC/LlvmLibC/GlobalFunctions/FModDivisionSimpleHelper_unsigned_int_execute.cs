using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FModDivisionSimpleHelper_unsigned_int_execute
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic24FModDivisionSimpleHelperIjE7executeEiijj")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::generic::FModDivisionSimpleHelper<unsigned int>::execute(int, int, unsigned int, unsigned int)")]
	public static int Invoke([NativeType("int")] int exp_diff, [NativeType("int")] int sides_zeroes_count, [NativeType("unsigned int")] int m_x, [NativeType("unsigned int")] int m_y)
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
