using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Optional_cpp_array_char_265ul_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS0_5arrayIcLm265EEEEC2ENS0_9nullopt_tE")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::cpp::array<char, 265ul>>::optional(__llvm_libc_20_1_2_::cpp::nullopt_t)")]
	public unsafe static void Invoke([MangledName("this")][NativeType("__llvm_libc_20_1_2_::cpp::nullopt_t")] Llvm_libc_20_1_2_cpp_optional_hnriuf* This)
	{
		OptionalStorage_cpp_array_char_265ul_false_Constructor.Invoke(&This->Storage);
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS0_5arrayIcLm265EEEEC2EOS3_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::cpp::array<char, 265ul>>::optional(__llvm_libc_20_1_2_::cpp::array<char, 265ul>&&)")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_cpp_optional_hnriuf* This, [MangledName("t")][NativeType("__llvm_libc_20_1_2_::cpp::array<char, 265ul>&&")] Llvm_libc_20_1_2_cpp_array_knc3mr* T)
	{
		OptionalStorage_cpp_array_char_265ul_false_OptionalStorage_cpp_array_char_265ul.Invoke(&This->Storage, Cpp_move_cpp_array_char_265ul.Invoke(T));
		This->Storage.In_use = 1;
	}
}
