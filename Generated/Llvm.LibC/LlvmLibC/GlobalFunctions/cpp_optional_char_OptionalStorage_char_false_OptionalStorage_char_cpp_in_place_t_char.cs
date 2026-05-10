using System;
using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIPcE15OptionalStorageIS2_Lb0EEC2IJS2_EEENS0_10in_place_tEDpOT_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<char*>::OptionalStorage<char*, false>::OptionalStorage<char*>(__llvm_libc_20_1_2_::cpp::in_place_t, char*&&)")]
internal static partial class cpp_optional_char_OptionalStorage_char_false_OptionalStorage_char_cpp_in_place_t_char
{
	public unsafe static void Invoke(void* @this, void* args)
	{
		unchecked
		{
			anon_589mcc* field = &((cpp_optional_char_OptionalStorage*)@this)->field;
			*(IntPtr*)field = *(IntPtr*)char_cpp_forward_char_cpp_remove_reference_char_type.Invoke(args);
			((cpp_optional_char_OptionalStorage*)@this)->in_use = 0;
		}
	}
}
