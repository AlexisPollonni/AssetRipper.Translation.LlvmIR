using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Optional_char_has_value
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp8optionalIPcE9has_valueEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<char*>::has_value() const")]
	public unsafe static bool Invoke([MangledName("this")] void* This)
	{
		return (unchecked((Llvm_libc_20_1_2_cpp_optional_77yu8f*)This)->Storage.In_use & 1) == 1;
	}
}
