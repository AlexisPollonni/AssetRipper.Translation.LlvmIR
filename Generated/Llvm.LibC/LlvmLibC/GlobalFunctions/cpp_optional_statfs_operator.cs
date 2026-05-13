using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNR19__llvm_libc_20_1_2_3cpp8optionalI6statfsEdeEv")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<statfs>::operator*() &")]
internal static partial class cpp_optional_statfs_operator
{
	public unsafe static statfs* Invoke(cpp_optional_hij69m* @this)
	{
		return unchecked((statfs*)(&@this->storage.field));
	}
}
