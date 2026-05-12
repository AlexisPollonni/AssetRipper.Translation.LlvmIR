using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIfE15OptionalStorageIfLb0EEC2IJfEEENS0_10in_place_tEDpOT_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<float>::OptionalStorage<float, false>::OptionalStorage<float>(__llvm_libc_20_1_2_::cpp::in_place_t, float&&)")]
internal static partial class cpp_optional_float_OptionalStorage_float_false_OptionalStorage_float_cpp_in_place_t_float
{
	public unsafe static void Invoke(cpp_optional_float_OptionalStorage* @this, void* args)
	{
		anon_rkx6n5* field = &@this->field;
		unchecked
		{
			*(float*)field = *(float*)float_cpp_forward_float_cpp_remove_reference_float_type.Invoke(args);
			@this->in_use = 0;
		}
	}
}
