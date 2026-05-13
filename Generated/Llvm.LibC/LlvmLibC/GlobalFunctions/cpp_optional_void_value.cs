using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNR19__llvm_libc_20_1_2_3cpp8optionalIPvE5valueEv")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<void*>::value() &")]
internal static partial class cpp_optional_void_value
{
	public unsafe static void* Invoke(void* @this)
	{
		return &unchecked((cpp_optional_e5s7qx*)@this)->storage.field;
	}
}
