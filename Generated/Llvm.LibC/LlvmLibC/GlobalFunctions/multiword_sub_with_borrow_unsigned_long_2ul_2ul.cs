using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class multiword_sub_with_borrow_unsigned_long_2ul_2ul
{
	[MangledName("_ZN19__llvm_libc_20_1_2_9multiword15sub_with_borrowImLm2ELm2EEET_RNS_3cpp5arrayIS2_XT0_EEERKNS4_IS2_XT1_EEE")]
	[DemangledName("unsigned long __llvm_libc_20_1_2_::multiword::sub_with_borrow<unsigned long, 2ul, 2ul>(__llvm_libc_20_1_2_::cpp::array<unsigned long, 2ul>&, __llvm_libc_20_1_2_::cpp::array<unsigned long, 2ul> const&)")]
	[return: NativeType("unsigned long")]
	public unsafe static long Invoke([NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned long, 2ul>&")] cpp_array_i3937k* dst, [NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned long, 2ul> const&")] cpp_array_i3937k* rhs)
	{
		return multiword_inplace_binop_unsigned_long_unsigned_long_unsigned_long_unsigned_long_unsigned_long_unsigned_long_2ul_2ul.Invoke(sub_with_borrow_unsigned_long.__pointer, dst, rhs);
	}
}
