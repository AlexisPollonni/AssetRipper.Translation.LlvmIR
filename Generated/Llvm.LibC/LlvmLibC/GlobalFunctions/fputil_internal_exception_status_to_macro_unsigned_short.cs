using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal25exception_status_to_macroEt")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::exception_status_to_macro(unsigned short)")]
internal static partial class fputil_internal_exception_status_to_macro_unsigned_short
{
	public static int Invoke(short status)
	{
		short num = status;
		return unchecked(InstructionHelper.Select(((ushort)num & 1) != 0, 1, 0) | InstructionHelper.Select(((ushort)num & 4) != 0, 4, 0) | InstructionHelper.Select(((ushort)num & 8) != 0, 8, 0) | InstructionHelper.Select(((ushort)num & 0x10) != 0, 16, 0) | InstructionHelper.Select(((ushort)num & 0x20) != 0, 32, 0));
	}
}
