using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class optional_char_Constructor_e46sab
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIPcEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<char*>::optional()")]
	[CleanName("optional_char_Constructor")]
	public unsafe static void Invoke(void* @this)
	{
		OptionalStorage_char_false_Constructor.Invoke(&unchecked((cpp_optional_77yu8f*)@this)->storage);
	}
}
