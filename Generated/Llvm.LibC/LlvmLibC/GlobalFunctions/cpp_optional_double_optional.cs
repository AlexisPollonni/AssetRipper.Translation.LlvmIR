using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIdEC2Ev")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<double>::optional()")]
internal static partial class cpp_optional_double_optional
{
	public unsafe static void Invoke(cpp_optional_vhbvq7* @this)
	{
		cpp_optional_double_OptionalStorage_double_false_OptionalStorage.Invoke(&@this->storage);
	}
}
