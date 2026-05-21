using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class optional_int_Constructor_ucy85v
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIiEC2ENS0_9nullopt_tE")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<int>::optional(__llvm_libc_20_1_2_::cpp::nullopt_t)")]
	[CleanName("optional_int_Constructor")]
	public unsafe static void Invoke([NativeType("__llvm_libc_20_1_2_::cpp::nullopt_t")] void* @this)
	{
		OptionalStorage_int_false_OptionalStorage.Invoke(&unchecked((cpp_optional_g66fk4*)@this)->storage);
	}
}
