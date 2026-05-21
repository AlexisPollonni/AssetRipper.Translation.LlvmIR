using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class OptionalStorage_cpp_array_char_265ul_false_OptionalStorage_cpp_array_char_265ul
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS0_5arrayIcLm265EEEE15OptionalStorageIS3_Lb0EEC2IJS3_EEENS0_10in_place_tEDpOT_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::cpp::array<char, 265ul>>::OptionalStorage<__llvm_libc_20_1_2_::cpp::array<char, 265ul>, false>::OptionalStorage<__llvm_libc_20_1_2_::cpp::array<char, 265ul>>(__llvm_libc_20_1_2_::cpp::in_place_t, __llvm_libc_20_1_2_::cpp::array<char, 265ul>&&)")]
	public unsafe static void Invoke([MangledName("this")][NativeType("__llvm_libc_20_1_2_::cpp::in_place_t")] Llvm_libc_20_1_2_cpp_optional_cpp_array_char_265_OptionalStorage* This, [MangledName("args")][NativeType("__llvm_libc_20_1_2_::cpp::array<char, 265ul>&&")] void* Args)
	{
		Llvm_memcpy_p0_p0_i64.Invoke(&This->field, Cpp_forward_cpp_array_char_265ul.Invoke(unchecked((Llvm_libc_20_1_2_cpp_array_knc3mr*)Args)), 265L, isVolatile: false);
		This->In_use = 0;
	}
}
