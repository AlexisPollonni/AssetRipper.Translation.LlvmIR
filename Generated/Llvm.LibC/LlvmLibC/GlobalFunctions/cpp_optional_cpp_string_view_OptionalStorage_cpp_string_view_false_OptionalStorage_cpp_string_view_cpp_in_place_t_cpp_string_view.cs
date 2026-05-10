using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS0_11string_viewEE15OptionalStorageIS2_Lb0EEC2IJS2_EEENS0_10in_place_tEDpOT_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::cpp::string_view>::OptionalStorage<__llvm_libc_20_1_2_::cpp::string_view, false>::OptionalStorage<__llvm_libc_20_1_2_::cpp::string_view>(__llvm_libc_20_1_2_::cpp::in_place_t, __llvm_libc_20_1_2_::cpp::string_view&&)")]
internal static partial class cpp_optional_cpp_string_view_OptionalStorage_cpp_string_view_false_OptionalStorage_cpp_string_view_cpp_in_place_t_cpp_string_view
{
	public unsafe static void Invoke(void* @this, void* args)
	{
		unchecked
		{
			llvm_memcpy_p0_p0_i64.Invoke(&((cpp_optional_cpp_string_view_OptionalStorage*)@this)->field, cpp_string_view_cpp_forward_cpp_string_view_cpp_remove_reference_cpp_string_view_type.Invoke(args), 16L, isVolatile: false);
			((cpp_optional_cpp_string_view_OptionalStorage*)@this)->in_use = 0;
		}
	}
}
