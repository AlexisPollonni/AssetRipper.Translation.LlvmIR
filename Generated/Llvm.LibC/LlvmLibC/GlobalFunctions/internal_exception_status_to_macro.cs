using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_exception_status_to_macro
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal25exception_status_to_macroEt")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::exception_status_to_macro(unsigned short)")]
	public static int Invoke([NativeType("unsigned short")] short status)
	{
		short num = status;
		return unchecked(InstructionHelper.Select(((ushort)num & 1) != 0, 1, 0) | InstructionHelper.Select(((ushort)num & 4) != 0, 4, 0) | InstructionHelper.Select(((ushort)num & 8) != 0, 8, 0) | InstructionHelper.Select(((ushort)num & 0x10) != 0, 16, 0) | InstructionHelper.Select(((ushort)num & 0x20) != 0, 32, 0));
	}
}
