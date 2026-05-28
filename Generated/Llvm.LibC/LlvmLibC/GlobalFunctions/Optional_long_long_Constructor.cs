using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Optional_long_long_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIxEC2EOx")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<long long>::optional(long long&&)")]
	public unsafe static void Invoke([MangledName("this")] void* This, [MangledName("t")][NativeType("long long&&")] void* T)
	{
		unchecked
		{
			OptionalStorage_long_long_false_OptionalStorage_long_long.Invoke(&((Cpp_optional_d6hvji*)This)->Storage, Cpp_move_long_long.Invoke(T));
			((Cpp_optional_d6hvji*)This)->Storage.In_use = 1;
		}
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIxEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<long long>::optional()")]
	public unsafe static void Invoke([MangledName("this")] void* This)
	{
		OptionalStorage_long_long_false_OptionalStorage.Invoke(&unchecked((Cpp_optional_d6hvji*)This)->Storage);
	}
}
