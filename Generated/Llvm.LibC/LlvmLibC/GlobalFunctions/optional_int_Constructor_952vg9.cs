using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class optional_int_Constructor_952vg9
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIiEC2EOi")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<int>::optional(int&&)")]
	[CleanName("optional_int_Constructor")]
	public unsafe static void Invoke(void* @this, [NativeType("int&&")] void* t)
	{
		unchecked
		{
			OptionalStorage_int_false_OptionalStorage_int.Invoke(&((cpp_optional_g66fk4*)@this)->storage, cpp_move_int.Invoke(t));
			((cpp_optional_g66fk4*)@this)->storage.in_use = 1;
		}
	}
}
