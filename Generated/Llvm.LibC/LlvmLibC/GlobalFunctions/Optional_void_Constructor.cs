using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Optional_void_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIPvEC2EOS2_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<void*>::optional(void*&&)")]
	public unsafe static void Invoke([MangledName("this")] void* This, [MangledName("t")][NativeType("void*&&")] void* T)
	{
		unchecked
		{
			OptionalStorage_void_false_OptionalStorage_void.Invoke(&((Llvm_libc_20_1_2_cpp_optional_77yu8f*)This)->Storage, Cpp_move_void.Invoke(T));
			((Llvm_libc_20_1_2_cpp_optional_77yu8f*)This)->Storage.In_use = 1;
		}
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIPvEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<void*>::optional()")]
	public unsafe static void Invoke([MangledName("this")] void* This)
	{
		OptionalStorage_void_false_Constructor.Invoke(&unchecked((Llvm_libc_20_1_2_cpp_optional_77yu8f*)This)->Storage);
	}
}
