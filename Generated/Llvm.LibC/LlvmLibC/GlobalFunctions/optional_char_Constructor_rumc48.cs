using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class optional_char_Constructor_rumc48
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIPcEC2EOS2_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<char*>::optional(char*&&)")]
	[CleanName("optional_char_Constructor")]
	public unsafe static void Invoke(void* @this, [NativeType("char*&&")] void* t)
	{
		unchecked
		{
			OptionalStorage_char_false_OptionalStorage_char.Invoke(&((cpp_optional_77yu8f*)@this)->storage, cpp_move_char.Invoke(t));
			((cpp_optional_77yu8f*)@this)->storage.in_use = 1;
		}
	}
}
