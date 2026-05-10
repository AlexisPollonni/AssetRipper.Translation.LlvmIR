using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp8optionalImE9has_valueEv")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<unsigned long>::has_value() const")]
internal static partial class cpp_optional_unsigned_long_has_value_const
{
	public unsafe static bool Invoke(void* @this)
	{
		return (unchecked((cpp_optional_d6hvji*)@this)->storage.in_use & 1) == 1;
	}
}
