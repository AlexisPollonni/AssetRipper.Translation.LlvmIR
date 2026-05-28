using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cpp_move_internal_ExpandedFloat_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp4moveIRNS_8internal13ExpandedFloatIdEEEEONS0_16remove_referenceIT_E4typeEOS7_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::remove_reference<__llvm_libc_20_1_2_::internal::ExpandedFloat<double>&>::type&& __llvm_libc_20_1_2_::cpp::move<__llvm_libc_20_1_2_::internal::ExpandedFloat<double>&>(__llvm_libc_20_1_2_::internal::ExpandedFloat<double>&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::remove_reference<__llvm_libc_20_1_2_::internal::ExpandedFloat<double>&>::type&&")]
	public unsafe static Internal_ExpandedFloat_k68bhv* Invoke([MangledName("t")][NativeType("__llvm_libc_20_1_2_::internal::ExpandedFloat<double>&")] Internal_ExpandedFloat_k68bhv* T)
	{
		return T;
	}
}
