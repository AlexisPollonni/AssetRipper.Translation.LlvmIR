using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS_8internal13ExpandedFloatIeEEE15OptionalStorageIS4_Lb0EEC2Ev")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::ExpandedFloat<long double>>::OptionalStorage<__llvm_libc_20_1_2_::internal::ExpandedFloat<long double>, false>::OptionalStorage()")]
internal static partial class cpp_optional_internal_ExpandedFloat_long_double_OptionalStorage_internal_ExpandedFloat_long_double_false_OptionalStorage
{
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			*(sbyte*)(&((cpp_optional_internal_ExpandedFloat_long_double_OptionalStorage*)@this)->field) = 0;
			((cpp_optional_internal_ExpandedFloat_long_double_OptionalStorage*)@this)->in_use = 0;
		}
	}
}
