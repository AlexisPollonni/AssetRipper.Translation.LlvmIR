using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNR19__llvm_libc_20_1_2_3cpp8optionalIDF16_E5valueEv")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<_Float16>::value() &")]
internal static partial class cpp_optional_Float16_value
{
	public unsafe static void* Invoke(cpp_optional_aq7wey* @this)
	{
		return &@this->storage.field;
	}
}
