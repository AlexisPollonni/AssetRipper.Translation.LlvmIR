using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalImEC2Ev")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<unsigned long>::optional()")]
internal static partial class cpp_optional_unsigned_long_optional
{
	public unsafe static void Invoke(void* @this)
	{
		cpp_optional_unsigned_long_OptionalStorage_unsigned_long_false_OptionalStorage.Invoke(&unchecked((cpp_optional_d6hvji*)@this)->storage);
	}
}
