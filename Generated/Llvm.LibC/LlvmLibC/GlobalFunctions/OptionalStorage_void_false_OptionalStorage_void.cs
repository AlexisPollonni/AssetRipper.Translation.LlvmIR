using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class OptionalStorage_void_false_OptionalStorage_void
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIPvE15OptionalStorageIS2_Lb0EEC2IJS2_EEENS0_10in_place_tEDpOT_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<void*>::OptionalStorage<void*, false>::OptionalStorage<void*>(__llvm_libc_20_1_2_::cpp::in_place_t, void*&&)")]
	public unsafe static void Invoke([MangledName("this")][NativeType("__llvm_libc_20_1_2_::cpp::in_place_t")] void* This, [MangledName("args")][NativeType("void*&&")] void* Args)
	{
		unchecked
		{
			Anon_5uk363* field = &((Llvm_libc_20_1_2_cpp_optional_char_OptionalStorage*)This)->field;
			*(IntPtr*)field = *(IntPtr*)Cpp_forward_void.Invoke(Args);
			((Llvm_libc_20_1_2_cpp_optional_char_OptionalStorage*)This)->In_use = 0;
		}
	}
}
