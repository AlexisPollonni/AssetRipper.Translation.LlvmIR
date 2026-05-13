using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIxEC2EOx")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<long long>::optional(long long&&)")]
internal static partial class cpp_optional_long_long_optional_long_long
{
	public unsafe static void Invoke(void* @this, void* t)
	{
		unchecked
		{
			cpp_optional_long_long_OptionalStorage_long_long_false_OptionalStorage_long_long_cpp_in_place_t_long_long.Invoke(&((cpp_optional_d6hvji*)@this)->storage, cpp_remove_reference_long_long_type_cpp_move_long_long_long_long.Invoke(t));
			((cpp_optional_d6hvji*)@this)->storage.in_use = 1;
		}
	}
}
