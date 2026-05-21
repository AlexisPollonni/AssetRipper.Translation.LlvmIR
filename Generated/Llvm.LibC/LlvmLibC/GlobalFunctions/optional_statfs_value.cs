using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class optional_statfs_value
{
	[MangledName("_ZNR19__llvm_libc_20_1_2_3cpp8optionalI6statfsE5valueEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<statfs>::value() &")]
	public unsafe static statfs* Invoke(cpp_optional_qbe95b* @this)
	{
		return unchecked((statfs*)(&@this->storage.field));
	}
}
