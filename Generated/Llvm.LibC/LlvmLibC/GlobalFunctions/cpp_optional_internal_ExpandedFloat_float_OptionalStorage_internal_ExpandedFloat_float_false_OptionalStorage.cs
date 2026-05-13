using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS_8internal13ExpandedFloatIfEEE15OptionalStorageIS4_Lb0EEC2Ev")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::ExpandedFloat<float>>::OptionalStorage<__llvm_libc_20_1_2_::internal::ExpandedFloat<float>, false>::OptionalStorage()")]
internal static partial class cpp_optional_internal_ExpandedFloat_float_OptionalStorage_internal_ExpandedFloat_float_false_OptionalStorage
{
	public unsafe static void Invoke(cpp_optional_internal_ExpandedFloat_float_OptionalStorage* @this)
	{
		*unchecked((sbyte*)(&@this->field)) = 0;
		@this->in_use = 0;
	}
}
