using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class OptionalStorage_internal_ExpandedFloat_float_false_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS_8internal13ExpandedFloatIfEEE15OptionalStorageIS4_Lb0EEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::ExpandedFloat<float>>::OptionalStorage<__llvm_libc_20_1_2_::internal::ExpandedFloat<float>, false>::OptionalStorage()")]
	public unsafe static void Invoke([MangledName("this")] Cpp_optional_internal_ExpandedFloat_float_OptionalStorage* This)
	{
		*unchecked((sbyte*)(&This->field)) = 0;
		This->In_use = 0;
	}
}
