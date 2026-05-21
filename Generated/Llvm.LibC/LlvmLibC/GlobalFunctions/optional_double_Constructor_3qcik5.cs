using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class optional_double_Constructor_3qcik5
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIdEC2EOd")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<double>::optional(double&&)")]
	[CleanName("optional_double_Constructor")]
	public unsafe static void Invoke(cpp_optional_vhbvq7* @this, [NativeType("double&&")] void* t)
	{
		OptionalStorage_double_false_OptionalStorage_double.Invoke(&@this->storage, cpp_move_double.Invoke(t));
		@this->storage.in_use = 1;
	}
}
