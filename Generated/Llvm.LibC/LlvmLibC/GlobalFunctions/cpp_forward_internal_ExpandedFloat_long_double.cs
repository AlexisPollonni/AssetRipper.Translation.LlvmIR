using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class cpp_forward_internal_ExpandedFloat_long_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp7forwardINS_8internal13ExpandedFloatIeEEEEOT_RNS0_16remove_referenceIS5_E4typeE")]
	[DemangledName("__llvm_libc_20_1_2_::internal::ExpandedFloat<long double>&& __llvm_libc_20_1_2_::cpp::forward<__llvm_libc_20_1_2_::internal::ExpandedFloat<long double>>(__llvm_libc_20_1_2_::cpp::remove_reference<__llvm_libc_20_1_2_::internal::ExpandedFloat<long double>>::type&)")]
	[return: NativeType("__llvm_libc_20_1_2_::internal::ExpandedFloat<long double>&&")]
	public unsafe static internal_ExpandedFloat_9jummq* Invoke([NativeType("__llvm_libc_20_1_2_::cpp::remove_reference<__llvm_libc_20_1_2_::internal::ExpandedFloat<long double>>::type&")] internal_ExpandedFloat_9jummq* value)
	{
		return value;
	}
}
