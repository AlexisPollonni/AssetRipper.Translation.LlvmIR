using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Optional_Float16_value
{
	[MangledName("_ZNR19__llvm_libc_20_1_2_3cpp8optionalIDF16_E5valueEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<_Float16>::value() &")]
	public unsafe static void* Invoke([MangledName("this")] Llvm_libc_20_1_2_cpp_optional_aq7wey* This)
	{
		return &This->Storage.field;
	}
}
