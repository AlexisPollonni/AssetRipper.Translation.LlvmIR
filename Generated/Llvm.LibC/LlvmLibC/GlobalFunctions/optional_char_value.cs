using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class optional_char_value
{
	[MangledName("_ZNR19__llvm_libc_20_1_2_3cpp8optionalIPcE5valueEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<char*>::value() &")]
	public unsafe static void* Invoke(void* @this)
	{
		return &unchecked((cpp_optional_77yu8f*)@this)->storage.field;
	}
}
