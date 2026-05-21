using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Optional_statfs_value
{
	[MangledName("_ZNR19__llvm_libc_20_1_2_3cpp8optionalI6statfsE5valueEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<statfs>::value() &")]
	public unsafe static Statfs* Invoke([MangledName("this")] Llvm_libc_20_1_2_cpp_optional_qbe95b* This)
	{
		return unchecked((Statfs*)(&This->Storage.field));
	}
}
