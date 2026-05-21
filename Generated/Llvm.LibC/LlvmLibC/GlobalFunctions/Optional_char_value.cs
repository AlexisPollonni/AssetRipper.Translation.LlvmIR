using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Optional_char_value
{
	[MangledName("_ZNR19__llvm_libc_20_1_2_3cpp8optionalIPcE5valueEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<char*>::value() &")]
	public unsafe static void* Invoke([MangledName("this")] void* This)
	{
		return &unchecked((Llvm_libc_20_1_2_cpp_optional_77yu8f*)This)->Storage.field;
	}
}
