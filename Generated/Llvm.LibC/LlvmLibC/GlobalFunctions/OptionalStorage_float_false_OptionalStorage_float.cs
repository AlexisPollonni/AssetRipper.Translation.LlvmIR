using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class OptionalStorage_float_false_OptionalStorage_float
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIfE15OptionalStorageIfLb0EEC2IJfEEENS0_10in_place_tEDpOT_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<float>::OptionalStorage<float, false>::OptionalStorage<float>(__llvm_libc_20_1_2_::cpp::in_place_t, float&&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::optional")]
	public unsafe static void Invoke([MangledName("this")][NativeType("__llvm_libc_20_1_2_::cpp::in_place_t")] Cpp_optional_float_OptionalStorage* This, [MangledName("args")][NativeType("float&&")] void* Args)
	{
		Anon_egcq2t* field = &This->field;
		unchecked
		{
			*(float*)field = *(float*)Cpp_forward_float.Invoke(Args);
			This->In_use = 0;
		}
	}
}
