using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class OptionalStorage_void_false_OptionalStorage_void
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIPvE15OptionalStorageIS2_Lb0EEC2IJS2_EEENS0_10in_place_tEDpOT_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<void*>::OptionalStorage<void*, false>::OptionalStorage<void*>(__llvm_libc_20_1_2_::cpp::in_place_t, void*&&)")]
	public unsafe static void Invoke([NativeType("__llvm_libc_20_1_2_::cpp::in_place_t")] void* @this, [NativeType("void*&&")] void* args)
	{
		unchecked
		{
			anon_5uk363* field = &((cpp_optional_char_OptionalStorage*)@this)->field;
			*(IntPtr*)field = *(IntPtr*)cpp_forward_void.Invoke(args);
			((cpp_optional_char_OptionalStorage*)@this)->in_use = 0;
		}
	}
}
