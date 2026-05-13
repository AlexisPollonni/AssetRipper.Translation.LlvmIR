using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNR19__llvm_libc_20_1_2_3cpp8optionalIPcEdeEv")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<char*>::operator*() &")]
internal static partial class cpp_optional_char_operator
{
	public unsafe static void* Invoke(void* @this)
	{
		return &unchecked((cpp_optional_e5s7qx*)@this)->storage.field;
	}
}
