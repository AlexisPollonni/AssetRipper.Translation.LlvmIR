using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class multiword_sub_with_borrow_unsigned_short_1ul_1ul
{
	[MangledName("_ZN19__llvm_libc_20_1_2_9multiword15sub_with_borrowItLm1ELm1EEET_RNS_3cpp5arrayIS2_XT0_EEERKNS4_IS2_XT1_EEE")]
	[DemangledName("unsigned short __llvm_libc_20_1_2_::multiword::sub_with_borrow<unsigned short, 1ul, 1ul>(__llvm_libc_20_1_2_::cpp::array<unsigned short, 1ul>&, __llvm_libc_20_1_2_::cpp::array<unsigned short, 1ul> const&)")]
	[return: NativeType("unsigned short")]
	public unsafe static short Invoke([NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned short, 1ul>&")] cpp_array_knh6hw* dst, [NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned short, 1ul> const&")] cpp_array_knh6hw* rhs)
	{
		return multiword_inplace_binop_unsigned_short_unsigned_short_unsigned_short_unsigned_short_unsigned_short_unsigned_short_1ul_1ul.Invoke(sub_with_borrow_unsigned_short.__pointer, dst, rhs);
	}
}
