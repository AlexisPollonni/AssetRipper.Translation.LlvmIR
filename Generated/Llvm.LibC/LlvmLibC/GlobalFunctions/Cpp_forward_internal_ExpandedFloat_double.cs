using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cpp_forward_internal_ExpandedFloat_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp7forwardINS_8internal13ExpandedFloatIdEEEEOT_RNS0_16remove_referenceIS5_E4typeE")]
	[DemangledName("__llvm_libc_20_1_2_::internal::ExpandedFloat<double>&& __llvm_libc_20_1_2_::cpp::forward<__llvm_libc_20_1_2_::internal::ExpandedFloat<double>>(__llvm_libc_20_1_2_::cpp::remove_reference<__llvm_libc_20_1_2_::internal::ExpandedFloat<double>>::type&)")]
	[return: NativeType("__llvm_libc_20_1_2_::internal::ExpandedFloat<double>&&")]
	public unsafe static Llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv* Invoke([MangledName("value")][NativeType("__llvm_libc_20_1_2_::cpp::remove_reference<__llvm_libc_20_1_2_::internal::ExpandedFloat<double>>::type&")] Llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv* Value)
	{
		return Value;
	}
}
