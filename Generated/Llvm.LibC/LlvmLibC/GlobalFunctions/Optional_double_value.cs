using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Optional_double_value
{
	[MangledName("_ZNR19__llvm_libc_20_1_2_3cpp8optionalIdE5valueEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<double>::value() &")]
	public unsafe static void* Invoke([MangledName("this")] Llvm_libc_20_1_2_cpp_optional_vhbvq7* This)
	{
		return &This->Storage.field;
	}
}
