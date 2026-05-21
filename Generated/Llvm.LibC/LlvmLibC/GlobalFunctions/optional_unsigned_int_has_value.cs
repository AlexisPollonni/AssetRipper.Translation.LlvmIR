using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class optional_unsigned_int_has_value
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp8optionalIjE9has_valueEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<unsigned int>::has_value() const")]
	public unsafe static bool Invoke(void* @this)
	{
		return (unchecked((cpp_optional_g66fk4*)@this)->storage.in_use & 1) == 1;
	}
}
