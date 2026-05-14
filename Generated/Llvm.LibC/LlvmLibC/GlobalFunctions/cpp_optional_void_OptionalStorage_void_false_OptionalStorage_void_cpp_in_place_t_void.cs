using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIPvE15OptionalStorageIS2_Lb0EEC2IJS2_EEENS0_10in_place_tEDpOT_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<void*>::OptionalStorage<void*, false>::OptionalStorage<void*>(__llvm_libc_20_1_2_::cpp::in_place_t, void*&&)")]
internal static partial class cpp_optional_void_OptionalStorage_void_false_OptionalStorage_void_cpp_in_place_t_void
{
	public unsafe static void Invoke(void* @this, void* args)
	{
		unchecked
		{
			anon_5uk363* field = &((cpp_optional_char_OptionalStorage*)@this)->field;
			*(IntPtr*)field = *(IntPtr*)void_cpp_forward_void_cpp_remove_reference_void_type.Invoke(args);
			((cpp_optional_char_OptionalStorage*)@this)->in_use = 0;
		}
	}
}
