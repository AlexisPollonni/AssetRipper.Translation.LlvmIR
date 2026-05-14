using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIjEC2Ev")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<unsigned int>::optional()")]
internal static partial class cpp_optional_unsigned_int_optional
{
	public unsafe static void Invoke(void* @this)
	{
		cpp_optional_unsigned_int_OptionalStorage_unsigned_int_false_OptionalStorage.Invoke(&unchecked((cpp_optional_g66fk4*)@this)->storage);
	}
}
