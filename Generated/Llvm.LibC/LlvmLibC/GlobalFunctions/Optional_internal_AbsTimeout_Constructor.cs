using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Optional_internal_AbsTimeout_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS_8internal10AbsTimeoutEEC2ENS0_9nullopt_tE")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::AbsTimeout>::optional(__llvm_libc_20_1_2_::cpp::nullopt_t)")]
	public unsafe static void Invoke([MangledName("this")][NativeType("__llvm_libc_20_1_2_::cpp::nullopt_t")] Llvm_libc_20_1_2_cpp_optional_59q3zq* This)
	{
		OptionalStorage_internal_AbsTimeout_false_Constructor.Invoke(unchecked((Llvm_libc_20_1_2_cpp_optional_long_double_OptionalStorage*)(&((Llvm_libc_20_1_2_cpp_optional_r9nbkt*)This)->Storage)));
	}
}
