using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp8optionalIDF16_E9has_valueEv")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<_Float16>::has_value() const")]
internal static partial class cpp_optional_Float16_has_value_const
{
	public unsafe static bool Invoke(void* @this)
	{
		return (unchecked((cpp_optional_aq7wey*)@this)->storage.in_use & 1) == 1;
	}
}
