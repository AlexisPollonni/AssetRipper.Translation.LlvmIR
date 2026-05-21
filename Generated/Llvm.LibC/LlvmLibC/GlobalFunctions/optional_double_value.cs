using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class optional_double_value
{
	[MangledName("_ZNR19__llvm_libc_20_1_2_3cpp8optionalIdE5valueEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<double>::value() &")]
	public unsafe static void* Invoke(cpp_optional_vhbvq7* @this)
	{
		return &@this->storage.field;
	}
}
