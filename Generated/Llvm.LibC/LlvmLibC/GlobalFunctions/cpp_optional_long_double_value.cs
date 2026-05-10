using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNR19__llvm_libc_20_1_2_3cpp8optionalIeE5valueEv")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<long double>::value() &")]
internal static partial class cpp_optional_long_double_value
{
	public unsafe static void* Invoke(void* @this)
	{
		return &unchecked((cpp_optional_59q3zq*)@this)->storage.field;
	}
}
