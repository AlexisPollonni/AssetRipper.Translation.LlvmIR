using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Optional_statfs_ToBoolean
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp8optionalI6statfsEcvbEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<statfs>::operator bool() const")]
	public unsafe static bool Invoke([MangledName("this")] Cpp_optional_qbe95b* This)
	{
		return (This->Storage.In_use & 1) == 1;
	}
}
