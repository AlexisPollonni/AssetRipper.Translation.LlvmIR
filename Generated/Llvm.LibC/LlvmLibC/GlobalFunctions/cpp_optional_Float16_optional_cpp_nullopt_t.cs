using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIDF16_EC2ENS0_9nullopt_tE")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<_Float16>::optional(__llvm_libc_20_1_2_::cpp::nullopt_t)")]
internal static partial class cpp_optional_Float16_optional_cpp_nullopt_t
{
	public unsafe static void Invoke(cpp_optional_aq7wey* @this)
	{
		cpp_optional_Float16_OptionalStorage_Float16_false_OptionalStorage.Invoke(&@this->storage);
	}
}
