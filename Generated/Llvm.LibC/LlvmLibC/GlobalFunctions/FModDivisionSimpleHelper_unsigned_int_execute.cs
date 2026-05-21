using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FModDivisionSimpleHelper_unsigned_int_execute
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic24FModDivisionSimpleHelperIjE7executeEiijj")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::generic::FModDivisionSimpleHelper<unsigned int>::execute(int, int, unsigned int, unsigned int)")]
	public static int Invoke([MangledName("exp_diff")][NativeType("int")] int Exp_diff, [MangledName("sides_zeroes_count")][NativeType("int")] int Sides_zeroes_count, [MangledName("m_x")][NativeType("unsigned int")] int M_x, [MangledName("m_y")][NativeType("unsigned int")] int M_y)
	{
		int num = Exp_diff;
		int num2 = M_x;
		while (num > Sides_zeroes_count)
		{
			num -= Sides_zeroes_count;
			num2 = unchecked((int)((uint)(num2 << Sides_zeroes_count) % (uint)M_y));
		}
		return unchecked((int)((uint)(num2 << num) % (uint)M_y));
	}
}
