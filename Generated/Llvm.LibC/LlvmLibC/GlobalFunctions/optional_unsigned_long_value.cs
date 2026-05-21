using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class optional_unsigned_long_value
{
	[MangledName("_ZNR19__llvm_libc_20_1_2_3cpp8optionalImE5valueEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<unsigned long>::value() &")]
	public unsafe static void* Invoke(void* @this)
	{
		return &unchecked((cpp_optional_d6hvji*)@this)->storage.field;
	}
}
