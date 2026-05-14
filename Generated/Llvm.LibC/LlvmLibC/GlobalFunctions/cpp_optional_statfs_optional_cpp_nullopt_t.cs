using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalI6statfsEC2ENS0_9nullopt_tE")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<statfs>::optional(__llvm_libc_20_1_2_::cpp::nullopt_t)")]
internal static partial class cpp_optional_statfs_optional_cpp_nullopt_t
{
	public unsafe static void Invoke(cpp_optional_qbe95b* @this)
	{
		cpp_optional_statfs_OptionalStorage_statfs_false_OptionalStorage.Invoke(&@this->storage);
	}
}
