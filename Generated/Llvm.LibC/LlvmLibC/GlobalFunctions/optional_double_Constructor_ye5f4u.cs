using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class optional_double_Constructor_ye5f4u
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIdEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<double>::optional()")]
	[CleanName("optional_double_Constructor")]
	public unsafe static void Invoke(cpp_optional_vhbvq7* @this)
	{
		OptionalStorage_double_false_OptionalStorage.Invoke(&@this->storage);
	}
}
