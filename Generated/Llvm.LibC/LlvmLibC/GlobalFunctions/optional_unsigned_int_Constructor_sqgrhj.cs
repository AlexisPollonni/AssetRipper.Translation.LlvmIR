using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class optional_unsigned_int_Constructor_sqgrhj
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIjEC2EOj")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<unsigned int>::optional(unsigned int&&)")]
	[CleanName("optional_unsigned_int_Constructor")]
	public unsafe static void Invoke(void* @this, [NativeType("unsigned int&&")] void* t)
	{
		unchecked
		{
			OptionalStorage_unsigned_int_false_OptionalStorage_unsigned_int.Invoke(&((cpp_optional_g66fk4*)@this)->storage, cpp_move_unsigned_int.Invoke(t));
			((cpp_optional_g66fk4*)@this)->storage.in_use = 1;
		}
	}
}
