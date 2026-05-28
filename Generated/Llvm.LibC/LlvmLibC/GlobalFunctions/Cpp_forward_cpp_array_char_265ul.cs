using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cpp_forward_cpp_array_char_265ul
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp7forwardINS0_5arrayIcLm265EEEEEOT_RNS0_16remove_referenceIS4_E4typeE")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<char, 265ul>&& __llvm_libc_20_1_2_::cpp::forward<__llvm_libc_20_1_2_::cpp::array<char, 265ul>>(__llvm_libc_20_1_2_::cpp::remove_reference<__llvm_libc_20_1_2_::cpp::array<char, 265ul>>::type&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::array<char, 265ul>&&")]
	public unsafe static Cpp_array_knc3mr* Invoke([MangledName("value")][NativeType("__llvm_libc_20_1_2_::cpp::remove_reference<__llvm_libc_20_1_2_::cpp::array<char, 265ul>>::type&")] Cpp_array_knc3mr* Value)
	{
		return Value;
	}
}
