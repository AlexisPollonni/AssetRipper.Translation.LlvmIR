using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Optional_double_Constructor_ye5f4u
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIdEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<double>::optional()")]
	[CleanName("Optional_double_Constructor")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_cpp_optional_vhbvq7* This)
	{
		OptionalStorage_double_false_OptionalStorage.Invoke(&This->Storage);
	}
}
