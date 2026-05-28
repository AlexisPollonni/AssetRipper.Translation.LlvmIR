using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Optional_void_value
{
	[MangledName("_ZNR19__llvm_libc_20_1_2_3cpp8optionalIPvE5valueEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<void*>::value() &")]
	public unsafe static void* Invoke([MangledName("this")] void* This)
	{
		return &unchecked((Cpp_optional_77yu8f*)This)->Storage.field;
	}
}
