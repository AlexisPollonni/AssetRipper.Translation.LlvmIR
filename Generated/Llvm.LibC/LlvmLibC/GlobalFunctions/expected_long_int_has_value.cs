using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class expected_long_int_has_value
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp8expectedIliE9has_valueEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::expected<long, int>::has_value() const")]
	public unsafe static bool Invoke(void* @this)
	{
		return (unchecked((cpp_expected*)@this)->in_use & 1) == 1;
	}
}
