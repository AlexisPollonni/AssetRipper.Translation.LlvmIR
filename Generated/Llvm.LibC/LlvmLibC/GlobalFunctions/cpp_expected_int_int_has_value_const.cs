using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp8expectedIiiE9has_valueEv")]
[DemangledName("__llvm_libc_20_1_2_::cpp::expected<int, int>::has_value() const")]
internal static partial class cpp_expected_int_int_has_value_const
{
	public unsafe static bool Invoke(void* @this)
	{
		return (unchecked((cpp_optional_int_OptionalStorage*)@this)->in_use & 1) == 1;
	}
}
