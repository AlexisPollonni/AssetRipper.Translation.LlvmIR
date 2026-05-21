using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FModDivisionSimpleHelper_unsigned_long_execute
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic24FModDivisionSimpleHelperImE7executeEiimm")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::generic::FModDivisionSimpleHelper<unsigned long>::execute(int, int, unsigned long, unsigned long)")]
	public static long Invoke([MangledName("exp_diff")][NativeType("int")] int Exp_diff, [MangledName("sides_zeroes_count")][NativeType("int")] int Sides_zeroes_count, [MangledName("m_x")][NativeType("unsigned long")] long M_x, [MangledName("m_y")][NativeType("unsigned long")] long M_y)
	{
		int num = Exp_diff;
		long num2 = M_x;
		while (num > Sides_zeroes_count)
		{
			num -= Sides_zeroes_count;
			num2 = unchecked((long)((ulong)(num2 << (int)(uint)Sides_zeroes_count) % (ulong)M_y));
		}
		return unchecked((long)((ulong)(num2 << (int)(uint)num) % (ulong)M_y));
	}
}
