using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Optional_unsigned_long_has_value
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp8optionalImE9has_valueEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<unsigned long>::has_value() const")]
	public unsafe static bool Invoke([MangledName("this")] void* This)
	{
		return (unchecked((Cpp_optional_d6hvji*)This)->Storage.In_use & 1) == 1;
	}
}
