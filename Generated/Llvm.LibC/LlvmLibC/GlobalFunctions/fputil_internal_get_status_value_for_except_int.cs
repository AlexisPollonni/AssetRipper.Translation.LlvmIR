using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal27get_status_value_for_exceptEi")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::get_status_value_for_except(int)")]
internal static partial class fputil_internal_get_status_value_for_except_int
{
	public static short Invoke(int excepts)
	{
		return unchecked((short)(InstructionHelper.Select((excepts & 1) != 0, 1, 0) | InstructionHelper.Select((excepts & 4) != 0, 4, 0) | InstructionHelper.Select((excepts & 8) != 0, 8, 0) | InstructionHelper.Select((excepts & 0x10) != 0, 16, 0) | InstructionHelper.Select((excepts & 0x20) != 0, 32, 0)));
	}
}
