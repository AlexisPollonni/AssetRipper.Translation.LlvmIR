using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Optional_unsigned_int_Constructor_sqgrhj
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIjEC2EOj")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<unsigned int>::optional(unsigned int&&)")]
	[CleanName("Optional_unsigned_int_Constructor")]
	public unsafe static void Invoke([MangledName("this")] void* This, [MangledName("t")][NativeType("unsigned int&&")] void* T)
	{
		unchecked
		{
			OptionalStorage_unsigned_int_false_OptionalStorage_unsigned_int.Invoke(&((Llvm_libc_20_1_2_cpp_optional_g66fk4*)This)->Storage, Cpp_move_unsigned_int.Invoke(T));
			((Llvm_libc_20_1_2_cpp_optional_g66fk4*)This)->Storage.In_use = 1;
		}
	}
}
