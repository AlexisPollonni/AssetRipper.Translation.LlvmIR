using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_get_status_value_for_except
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal27get_status_value_for_exceptEi")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::get_status_value_for_except(int)")]
	public static short Invoke([MangledName("excepts")][NativeType("int")] int Excepts)
	{
		return unchecked((short)(InstructionHelper.Select((Excepts & 1) != 0, 1, 0) | InstructionHelper.Select((Excepts & 4) != 0, 4, 0) | InstructionHelper.Select((Excepts & 8) != 0, 8, 0) | InstructionHelper.Select((Excepts & 0x10) != 0, 16, 0) | InstructionHelper.Select((Excepts & 0x20) != 0, 32, 0)));
	}
}
