using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class cpp_move_cpp_array_char_265ul
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp4moveIRNS0_5arrayIcLm265EEEEEONS0_16remove_referenceIT_E4typeEOS6_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::remove_reference<__llvm_libc_20_1_2_::cpp::array<char, 265ul>&>::type&& __llvm_libc_20_1_2_::cpp::move<__llvm_libc_20_1_2_::cpp::array<char, 265ul>&>(__llvm_libc_20_1_2_::cpp::array<char, 265ul>&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::remove_reference<__llvm_libc_20_1_2_::cpp::array<char, 265ul>&>::type&&")]
	public unsafe static cpp_array_knc3mr* Invoke([NativeType("__llvm_libc_20_1_2_::cpp::array<char, 265ul>&")] cpp_array_knc3mr* t)
	{
		return t;
	}
}
