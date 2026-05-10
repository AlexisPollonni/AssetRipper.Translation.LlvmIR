using System;
using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIDF16_E15OptionalStorageIDF16_Lb0EEC2IJDF16_EEENS0_10in_place_tEDpOT_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<_Float16>::OptionalStorage<_Float16, false>::OptionalStorage<_Float16>(__llvm_libc_20_1_2_::cpp::in_place_t, _Float16&&)")]
internal static partial class cpp_optional_Float16_OptionalStorage_Float16_false_OptionalStorage_Float16_cpp_in_place_t_Float16
{
	public unsafe static void Invoke(void* @this, void* args)
	{
		unchecked
		{
			anon_juyca8* field = &((cpp_optional_Float16_OptionalStorage*)@this)->field;
			*(Half*)field = *(Half*)Float16_cpp_forward_Float16_cpp_remove_reference_Float16_type.Invoke(args);
			((cpp_optional_Float16_OptionalStorage*)@this)->in_use = 0;
		}
	}
}
