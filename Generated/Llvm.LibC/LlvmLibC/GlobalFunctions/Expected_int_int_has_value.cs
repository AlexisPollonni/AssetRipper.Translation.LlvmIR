using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Expected_int_int_has_value
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp8expectedIiiE9has_valueEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::expected<int, int>::has_value() const")]
	public unsafe static bool Invoke([MangledName("this")] void* This)
	{
		return (unchecked((Cpp_optional_int_OptionalStorage*)This)->In_use & 1) == 1;
	}
}
