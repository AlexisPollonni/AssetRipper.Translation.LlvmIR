using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Optional_unsigned_int_has_value
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp8optionalIjE9has_valueEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<unsigned int>::has_value() const")]
	public unsafe static bool Invoke([MangledName("this")] void* This)
	{
		return (unchecked((Cpp_optional_g66fk4*)This)->Storage.In_use & 1) == 1;
	}
}
