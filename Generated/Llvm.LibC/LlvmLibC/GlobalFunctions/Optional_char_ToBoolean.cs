using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Optional_char_ToBoolean
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp8optionalIPcEcvbEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<char*>::operator bool() const")]
	public unsafe static bool Invoke([MangledName("this")] void* This)
	{
		return (unchecked((Cpp_optional_77yu8f*)This)->Storage.In_use & 1) == 1;
	}
}
