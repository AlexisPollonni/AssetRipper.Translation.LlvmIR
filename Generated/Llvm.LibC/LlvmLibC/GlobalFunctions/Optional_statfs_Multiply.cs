using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Optional_statfs_Multiply
{
	[MangledName("_ZNR19__llvm_libc_20_1_2_3cpp8optionalI6statfsEdeEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<statfs>::operator*() &")]
	public unsafe static Statfs* Invoke([MangledName("this")] Cpp_optional_qbe95b* This)
	{
		return unchecked((Statfs*)(&This->Storage.field));
	}
}
