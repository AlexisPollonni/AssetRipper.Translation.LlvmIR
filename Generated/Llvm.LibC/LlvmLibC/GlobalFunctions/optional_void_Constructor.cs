using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class optional_void_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIPvEC2EOS2_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<void*>::optional(void*&&)")]
	public unsafe static void Invoke(void* @this, [NativeType("void*&&")] void* t)
	{
		unchecked
		{
			OptionalStorage_void_false_OptionalStorage_void.Invoke(&((cpp_optional_77yu8f*)@this)->storage, cpp_move_void.Invoke(t));
			((cpp_optional_77yu8f*)@this)->storage.in_use = 1;
		}
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIPvEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<void*>::optional()")]
	public unsafe static void Invoke(void* @this)
	{
		OptionalStorage_void_false_Constructor.Invoke(&unchecked((cpp_optional_77yu8f*)@this)->storage);
	}
}
