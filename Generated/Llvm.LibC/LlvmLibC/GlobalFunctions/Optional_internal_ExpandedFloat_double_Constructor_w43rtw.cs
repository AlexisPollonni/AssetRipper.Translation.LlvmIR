using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Optional_internal_ExpandedFloat_double_Constructor_w43rtw
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS_8internal13ExpandedFloatIdEEEC2EOS4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::ExpandedFloat<double>>::optional(__llvm_libc_20_1_2_::internal::ExpandedFloat<double>&&)")]
	[CleanName("Optional_internal_ExpandedFloat_double_Constructor")]
	public unsafe static void Invoke([MangledName("this")] Cpp_optional_9m4esb* This, [MangledName("t")][NativeType("__llvm_libc_20_1_2_::internal::ExpandedFloat<double>&&")] Internal_ExpandedFloat_k68bhv* T)
	{
		OptionalStorage_internal_ExpandedFloat_double_false_OptionalStorage_internal_ExpandedFloat_double.Invoke(&This->Storage, Cpp_move_internal_ExpandedFloat_double.Invoke(T));
		This->Storage.In_use = 1;
	}
}
