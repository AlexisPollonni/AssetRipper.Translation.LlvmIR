using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Optional_internal_ExpandedFloat_long_double_Constructor_crcz7y
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS_8internal13ExpandedFloatIeEEEC2EOS4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::ExpandedFloat<long double>>::optional(__llvm_libc_20_1_2_::internal::ExpandedFloat<long double>&&)")]
	[CleanName("Optional_internal_ExpandedFloat_long_double_Constructor")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_cpp_optional_q5jaj8* This, [MangledName("t")][NativeType("__llvm_libc_20_1_2_::internal::ExpandedFloat<long double>&&")] Llvm_libc_20_1_2_internal_ExpandedFloat_9jummq* T)
	{
		OptionalStorage_internal_ExpandedFloat_long_double_false_OptionalStorage_internal_ExpandedFloat_long_double.Invoke(&This->Storage, Cpp_move_internal_ExpandedFloat_long_double.Invoke(T));
		This->Storage.In_use = 1;
	}
}
