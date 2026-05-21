using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Optional_internal_ExpandedFloat_float_Constructor_cm37bp
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS_8internal13ExpandedFloatIfEEEC2EOS4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::ExpandedFloat<float>>::optional(__llvm_libc_20_1_2_::internal::ExpandedFloat<float>&&)")]
	[CleanName("Optional_internal_ExpandedFloat_float_Constructor")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_cpp_optional_6hseum* This, [MangledName("t")][NativeType("__llvm_libc_20_1_2_::internal::ExpandedFloat<float>&&")] Llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up* T)
	{
		OptionalStorage_internal_ExpandedFloat_float_false_OptionalStorage_internal_ExpandedFloat_float.Invoke(&This->Storage, Cpp_move_internal_ExpandedFloat_float.Invoke(T));
		This->Storage.In_use = 1;
	}
}
