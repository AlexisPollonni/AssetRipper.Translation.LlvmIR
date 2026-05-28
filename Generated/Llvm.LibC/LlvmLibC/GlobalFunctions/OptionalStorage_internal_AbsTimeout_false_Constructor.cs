using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class OptionalStorage_internal_AbsTimeout_false_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS_8internal10AbsTimeoutEE15OptionalStorageIS3_Lb0EEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::AbsTimeout>::OptionalStorage<__llvm_libc_20_1_2_::internal::AbsTimeout, false>::OptionalStorage()")]
	public unsafe static void Invoke([MangledName("this")] Cpp_optional_long_double_OptionalStorage* This)
	{
		unchecked
		{
			*(sbyte*)(&((Cpp_optional_internal_AbsTimeout_OptionalStorage*)This)->field) = 0;
			((Cpp_optional_internal_AbsTimeout_OptionalStorage*)This)->In_use = 0;
		}
	}
}
