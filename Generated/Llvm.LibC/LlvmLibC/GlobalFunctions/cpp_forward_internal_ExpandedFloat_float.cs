using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class cpp_forward_internal_ExpandedFloat_float
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp7forwardINS_8internal13ExpandedFloatIfEEEEOT_RNS0_16remove_referenceIS5_E4typeE")]
	[DemangledName("__llvm_libc_20_1_2_::internal::ExpandedFloat<float>&& __llvm_libc_20_1_2_::cpp::forward<__llvm_libc_20_1_2_::internal::ExpandedFloat<float>>(__llvm_libc_20_1_2_::cpp::remove_reference<__llvm_libc_20_1_2_::internal::ExpandedFloat<float>>::type&)")]
	[return: NativeType("__llvm_libc_20_1_2_::internal::ExpandedFloat<float>&&")]
	public unsafe static internal_ExpandedFloat_i7t5up* Invoke([NativeType("__llvm_libc_20_1_2_::cpp::remove_reference<__llvm_libc_20_1_2_::internal::ExpandedFloat<float>>::type&")] internal_ExpandedFloat_i7t5up* value)
	{
		return value;
	}
}
