using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIPcEC2ENS0_9nullopt_tE")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<char*>::optional(__llvm_libc_20_1_2_::cpp::nullopt_t)")]
internal static partial class cpp_optional_char_optional_cpp_nullopt_t
{
	public unsafe static void Invoke(void* @this)
	{
		cpp_optional_char_OptionalStorage_char_false_OptionalStorage.Invoke(&unchecked((cpp_optional_e5s7qx*)@this)->storage);
	}
}
