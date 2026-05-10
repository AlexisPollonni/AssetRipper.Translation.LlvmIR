using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNR19__llvm_libc_20_1_2_3cpp8optionalIdE5valueEv")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<double>::value() &")]
internal static partial class cpp_optional_double_value
{
	public unsafe static void* Invoke(void* @this)
	{
		return &unchecked((cpp_optional_s4iqgj*)@this)->storage.field;
	}
}
