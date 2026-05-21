using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Multiword_sub_with_borrow_unsigned_int_1ul_1ul
{
	[MangledName("_ZN19__llvm_libc_20_1_2_9multiword15sub_with_borrowIjLm1ELm1EEET_RNS_3cpp5arrayIS2_XT0_EEERKNS4_IS2_XT1_EEE")]
	[DemangledName("unsigned int __llvm_libc_20_1_2_::multiword::sub_with_borrow<unsigned int, 1ul, 1ul>(__llvm_libc_20_1_2_::cpp::array<unsigned int, 1ul>&, __llvm_libc_20_1_2_::cpp::array<unsigned int, 1ul> const&)")]
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke([MangledName("dst")][NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned int, 1ul>&")] Llvm_libc_20_1_2_cpp_array_2v7m9i* Dst, [MangledName("rhs")][NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned int, 1ul> const&")] Llvm_libc_20_1_2_cpp_array_2v7m9i* Rhs)
	{
		return Multiword_inplace_binop_unsigned_int_unsigned_int_unsigned_int_unsigned_int_unsigned_int_unsigned_int_1ul_1ul.Invoke(Llvm_libc_20_1_2_sub_with_borrow_unsigned_int.__pointer, Dst, Rhs);
	}
}
