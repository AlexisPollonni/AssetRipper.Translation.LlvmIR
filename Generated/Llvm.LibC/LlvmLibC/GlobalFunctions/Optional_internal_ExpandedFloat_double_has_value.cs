using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Optional_internal_ExpandedFloat_double_has_value
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp8optionalINS_8internal13ExpandedFloatIdEEE9has_valueEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::ExpandedFloat<double>>::has_value() const")]
	public unsafe static bool Invoke([MangledName("this")] Llvm_libc_20_1_2_cpp_optional_9m4esb* This)
	{
		return (This->Storage.In_use & 1) == 1;
	}
}
