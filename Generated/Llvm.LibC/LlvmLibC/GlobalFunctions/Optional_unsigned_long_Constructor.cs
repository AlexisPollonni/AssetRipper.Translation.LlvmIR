using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Optional_unsigned_long_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalImEC2EOm")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<unsigned long>::optional(unsigned long&&)")]
	public unsafe static void Invoke([MangledName("this")] void* This, [MangledName("t")][NativeType("unsigned long&&")] void* T)
	{
		unchecked
		{
			OptionalStorage_unsigned_long_false_OptionalStorage_unsigned_long.Invoke(&((Llvm_libc_20_1_2_cpp_optional_d6hvji*)This)->Storage, Cpp_move_unsigned_long.Invoke(T));
			((Llvm_libc_20_1_2_cpp_optional_d6hvji*)This)->Storage.In_use = 1;
		}
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalImEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<unsigned long>::optional()")]
	public unsafe static void Invoke([MangledName("this")] void* This)
	{
		OptionalStorage_unsigned_long_false_OptionalStorage.Invoke(&unchecked((Llvm_libc_20_1_2_cpp_optional_d6hvji*)This)->Storage);
	}
}
