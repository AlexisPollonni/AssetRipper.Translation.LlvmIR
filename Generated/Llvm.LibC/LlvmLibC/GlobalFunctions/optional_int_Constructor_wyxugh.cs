using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class optional_int_Constructor_wyxugh
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIiEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<int>::optional()")]
	[CleanName("optional_int_Constructor")]
	public unsafe static void Invoke(void* @this)
	{
		OptionalStorage_int_false_OptionalStorage.Invoke(&unchecked((cpp_optional_g66fk4*)@this)->storage);
	}
}
