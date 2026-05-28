using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Optional_char_Constructor_rumc48
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIPcEC2EOS2_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<char*>::optional(char*&&)")]
	[CleanName("Optional_char_Constructor")]
	public unsafe static void Invoke([MangledName("this")] void* This, [MangledName("t")][NativeType("char*&&")] void* T)
	{
		unchecked
		{
			OptionalStorage_char_false_OptionalStorage_char.Invoke(&((Cpp_optional_77yu8f*)This)->Storage, Cpp_move_char.Invoke(T));
			((Cpp_optional_77yu8f*)This)->Storage.In_use = 1;
		}
	}
}
