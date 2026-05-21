using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class optional_cpp_array_char_265ul_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS0_5arrayIcLm265EEEEC2ENS0_9nullopt_tE")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::cpp::array<char, 265ul>>::optional(__llvm_libc_20_1_2_::cpp::nullopt_t)")]
	public unsafe static void Invoke([NativeType("__llvm_libc_20_1_2_::cpp::nullopt_t")] cpp_optional_hnriuf* @this)
	{
		OptionalStorage_cpp_array_char_265ul_false_Constructor.Invoke(&@this->storage);
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS0_5arrayIcLm265EEEEC2EOS3_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::cpp::array<char, 265ul>>::optional(__llvm_libc_20_1_2_::cpp::array<char, 265ul>&&)")]
	public unsafe static void Invoke(cpp_optional_hnriuf* @this, [NativeType("__llvm_libc_20_1_2_::cpp::array<char, 265ul>&&")] cpp_array_knc3mr* t)
	{
		OptionalStorage_cpp_array_char_265ul_false_OptionalStorage_cpp_array_char_265ul.Invoke(&@this->storage, cpp_move_cpp_array_char_265ul.Invoke(t));
		@this->storage.in_use = 1;
	}
}
