using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Optional_Float16_has_value
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp8optionalIDF16_E9has_valueEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<_Float16>::has_value() const")]
	public unsafe static bool Invoke([MangledName("this")] Llvm_libc_20_1_2_cpp_optional_aq7wey* This)
	{
		return (This->Storage.In_use & 1) == 1;
	}
}
