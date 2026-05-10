using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8expectedIiiE5valueEv")]
[DemangledName("__llvm_libc_20_1_2_::cpp::expected<int, int>::value()")]
internal static partial class cpp_expected_int_int_value
{
	public unsafe static void* Invoke(void* @this)
	{
		return &unchecked((cpp_optional_int_OptionalStorage*)@this)->field;
	}
}
