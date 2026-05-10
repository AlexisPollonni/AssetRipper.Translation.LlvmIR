using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNR19__llvm_libc_20_1_2_3cpp8optionalIxE5valueEv")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<long long>::value() &")]
internal static partial class cpp_optional_long_long_value
{
	public unsafe static void* Invoke(void* @this)
	{
		return &unchecked((cpp_optional_d6hvji*)@this)->storage.field;
	}
}
