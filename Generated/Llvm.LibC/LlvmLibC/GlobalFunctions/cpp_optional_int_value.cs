using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNR19__llvm_libc_20_1_2_3cpp8optionalIiE5valueEv")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<int>::value() &")]
internal static partial class cpp_optional_int_value
{
	public unsafe static void* Invoke(void* @this)
	{
		return &unchecked((cpp_optional_39hkks*)@this)->storage.field;
	}
}
