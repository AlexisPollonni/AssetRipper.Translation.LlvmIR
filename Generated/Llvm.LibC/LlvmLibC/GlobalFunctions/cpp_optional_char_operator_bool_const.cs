using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp8optionalIPcEcvbEv")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<char*>::operator bool() const")]
internal static partial class cpp_optional_char_operator_bool_const
{
	public unsafe static bool Invoke(void* @this)
	{
		return (unchecked((cpp_optional_e5s7qx*)@this)->storage.in_use & 1) == 1;
	}
}
