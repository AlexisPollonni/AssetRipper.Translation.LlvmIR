using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class optional_unsigned_int_Constructor_uavk26
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIjEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<unsigned int>::optional()")]
	[CleanName("optional_unsigned_int_Constructor")]
	public unsafe static void Invoke(void* @this)
	{
		OptionalStorage_unsigned_int_false_OptionalStorage.Invoke(&unchecked((cpp_optional_g66fk4*)@this)->storage);
	}
}
