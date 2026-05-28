using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cpp_move_internal_ExpandedFloat_long_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp4moveIRNS_8internal13ExpandedFloatIeEEEEONS0_16remove_referenceIT_E4typeEOS7_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::remove_reference<__llvm_libc_20_1_2_::internal::ExpandedFloat<long double>&>::type&& __llvm_libc_20_1_2_::cpp::move<__llvm_libc_20_1_2_::internal::ExpandedFloat<long double>&>(__llvm_libc_20_1_2_::internal::ExpandedFloat<long double>&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::remove_reference<__llvm_libc_20_1_2_::internal::ExpandedFloat<long double>&>::type&&")]
	public unsafe static Internal_ExpandedFloat_9jummq* Invoke([MangledName("t")][NativeType("__llvm_libc_20_1_2_::internal::ExpandedFloat<long double>&")] Internal_ExpandedFloat_9jummq* T)
	{
		return T;
	}
}
