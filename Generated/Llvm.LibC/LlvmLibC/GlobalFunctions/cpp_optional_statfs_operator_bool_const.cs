using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp8optionalI6statfsEcvbEv")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<statfs>::operator bool() const")]
internal static partial class cpp_optional_statfs_operator_bool_const
{
	public unsafe static bool Invoke(void* @this)
	{
		return (unchecked((cpp_optional_hij69m*)@this)->storage.in_use & 1) == 1;
	}
}
