using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS0_5arrayIcLm265EEEE15OptionalStorageIS3_Lb0EEC2IJS3_EEENS0_10in_place_tEDpOT_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::cpp::array<char, 265ul>>::OptionalStorage<__llvm_libc_20_1_2_::cpp::array<char, 265ul>, false>::OptionalStorage<__llvm_libc_20_1_2_::cpp::array<char, 265ul>>(__llvm_libc_20_1_2_::cpp::in_place_t, __llvm_libc_20_1_2_::cpp::array<char, 265ul>&&)")]
internal static partial class cpp_optional_cpp_array_char_265ul_OptionalStorage_cpp_array_char_265ul_false_OptionalStorage_cpp_array_char_265ul_cpp_in_place_t_cpp_array_char_265ul
{
	public unsafe static void Invoke(void* @this, void* args)
	{
		unchecked
		{
			llvm_memcpy_p0_p0_i64.Invoke(&((cpp_optional_cpp_array_char_265_OptionalStorage*)@this)->field, cpp_array_char_265ul_cpp_forward_cpp_array_char_265ul_cpp_remove_reference_cpp_array_char_265ul_type.Invoke(args), 265L, isVolatile: false);
			((cpp_optional_cpp_array_char_265_OptionalStorage*)@this)->in_use = 0;
		}
	}
}
