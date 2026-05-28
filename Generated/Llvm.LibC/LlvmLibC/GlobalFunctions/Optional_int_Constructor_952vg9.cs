using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Optional_int_Constructor_952vg9
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIiEC2EOi")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<int>::optional(int&&)")]
	[CleanName("Optional_int_Constructor")]
	public unsafe static void Invoke([MangledName("this")] void* This, [MangledName("t")][NativeType("int&&")] void* T)
	{
		unchecked
		{
			OptionalStorage_int_false_OptionalStorage_int.Invoke(&((Cpp_optional_g66fk4*)This)->Storage, Cpp_move_int.Invoke(T));
			((Cpp_optional_g66fk4*)This)->Storage.In_use = 1;
		}
	}
}
