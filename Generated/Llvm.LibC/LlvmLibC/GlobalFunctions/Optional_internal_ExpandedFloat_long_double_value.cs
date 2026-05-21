using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Optional_internal_ExpandedFloat_long_double_value
{
	[MangledName("_ZNR19__llvm_libc_20_1_2_3cpp8optionalINS_8internal13ExpandedFloatIeEEE5valueEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::ExpandedFloat<long double>>::value() &")]
	public unsafe static Llvm_libc_20_1_2_internal_ExpandedFloat_9jummq* Invoke([MangledName("this")] Llvm_libc_20_1_2_cpp_optional_q5jaj8* This)
	{
		return unchecked((Llvm_libc_20_1_2_internal_ExpandedFloat_9jummq*)(&This->Storage.field));
	}
}
