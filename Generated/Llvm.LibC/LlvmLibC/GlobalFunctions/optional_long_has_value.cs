using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class optional_long_has_value
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp8optionalIlE9has_valueEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<long>::has_value() const")]
	public unsafe static bool Invoke(void* @this)
	{
		return (unchecked((cpp_optional_d6hvji*)@this)->storage.in_use & 1) == 1;
	}
}
