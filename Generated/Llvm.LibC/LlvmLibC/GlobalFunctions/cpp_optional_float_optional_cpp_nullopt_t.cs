using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIfEC2ENS0_9nullopt_tE")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<float>::optional(__llvm_libc_20_1_2_::cpp::nullopt_t)")]
internal static partial class cpp_optional_float_optional_cpp_nullopt_t
{
	public unsafe static void Invoke(cpp_optional_89h55j* @this)
	{
		cpp_optional_float_OptionalStorage_float_false_OptionalStorage.Invoke(&@this->storage);
	}
}
