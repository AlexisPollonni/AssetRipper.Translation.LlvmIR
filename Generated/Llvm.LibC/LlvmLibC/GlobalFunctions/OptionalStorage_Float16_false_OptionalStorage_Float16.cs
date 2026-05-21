using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class OptionalStorage_Float16_false_OptionalStorage_Float16
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIDF16_E15OptionalStorageIDF16_Lb0EEC2IJDF16_EEENS0_10in_place_tEDpOT_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<_Float16>::OptionalStorage<_Float16, false>::OptionalStorage<_Float16>(__llvm_libc_20_1_2_::cpp::in_place_t, _Float16&&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::optional")]
	public unsafe static void Invoke([MangledName("this")][NativeType("__llvm_libc_20_1_2_::cpp::in_place_t")] Llvm_libc_20_1_2_cpp_optional_Float16_OptionalStorage* This, [MangledName("args")][NativeType("_Float16&&")] void* Args)
	{
		Anon_juyca8* field = &This->field;
		unchecked
		{
			*(Half*)field = *(Half*)Cpp_forward_Float16.Invoke(Args);
			This->In_use = 0;
		}
	}
}
