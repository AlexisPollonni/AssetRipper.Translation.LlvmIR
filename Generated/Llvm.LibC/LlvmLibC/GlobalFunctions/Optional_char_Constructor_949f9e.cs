using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Optional_char_Constructor_949f9e
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIPcEC2ENS0_9nullopt_tE")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<char*>::optional(__llvm_libc_20_1_2_::cpp::nullopt_t)")]
	[CleanName("Optional_char_Constructor")]
	public unsafe static void Invoke([MangledName("this")][NativeType("__llvm_libc_20_1_2_::cpp::nullopt_t")] void* This)
	{
		OptionalStorage_char_false_Constructor.Invoke(&unchecked((Llvm_libc_20_1_2_cpp_optional_77yu8f*)This)->Storage);
	}
}
