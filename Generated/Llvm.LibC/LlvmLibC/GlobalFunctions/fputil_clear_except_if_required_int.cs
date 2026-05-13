using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil24clear_except_if_requiredEi")]
[DemangledName("__llvm_libc_20_1_2_::fputil::clear_except_if_required(int)")]
internal static partial class fputil_clear_except_if_required_int
{
	public static int Invoke(int excepts)
	{
		return fputil_clear_except_int.Invoke(excepts);
	}
}
