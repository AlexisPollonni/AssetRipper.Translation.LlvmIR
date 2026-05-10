using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIeEC2Ev")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<long double>::optional()")]
internal static partial class cpp_optional_long_double_optional
{
	public unsafe static void Invoke(void* @this)
	{
		cpp_optional_long_double_OptionalStorage_long_double_false_OptionalStorage.Invoke(&unchecked((cpp_optional_59q3zq*)@this)->storage);
	}
}
