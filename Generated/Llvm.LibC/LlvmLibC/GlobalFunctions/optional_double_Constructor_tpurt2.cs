using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class optional_double_Constructor_tpurt2
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIdEC2ENS0_9nullopt_tE")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<double>::optional(__llvm_libc_20_1_2_::cpp::nullopt_t)")]
	[CleanName("optional_double_Constructor")]
	public unsafe static void Invoke([NativeType("__llvm_libc_20_1_2_::cpp::nullopt_t")] cpp_optional_vhbvq7* @this)
	{
		OptionalStorage_double_false_OptionalStorage.Invoke(&@this->storage);
	}
}
