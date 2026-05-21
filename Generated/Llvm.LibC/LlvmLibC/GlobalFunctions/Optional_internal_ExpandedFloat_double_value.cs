using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Optional_internal_ExpandedFloat_double_value
{
	[MangledName("_ZNR19__llvm_libc_20_1_2_3cpp8optionalINS_8internal13ExpandedFloatIdEEE5valueEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::ExpandedFloat<double>>::value() &")]
	public unsafe static Llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv* Invoke([MangledName("this")] Llvm_libc_20_1_2_cpp_optional_9m4esb* This)
	{
		return unchecked((Llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv*)(&This->Storage.field));
	}
}
