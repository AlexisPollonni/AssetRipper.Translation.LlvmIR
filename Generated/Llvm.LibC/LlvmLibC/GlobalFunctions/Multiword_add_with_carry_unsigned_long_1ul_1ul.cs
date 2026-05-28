using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Multiword_add_with_carry_unsigned_long_1ul_1ul
{
	[MangledName("_ZN19__llvm_libc_20_1_2_9multiword14add_with_carryImLm1ELm1EEET_RNS_3cpp5arrayIS2_XT0_EEERKNS4_IS2_XT1_EEE")]
	[DemangledName("unsigned long __llvm_libc_20_1_2_::multiword::add_with_carry<unsigned long, 1ul, 1ul>(__llvm_libc_20_1_2_::cpp::array<unsigned long, 1ul>&, __llvm_libc_20_1_2_::cpp::array<unsigned long, 1ul> const&)")]
	[return: NativeType("unsigned long")]
	public unsafe static long Invoke([MangledName("dst")][NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned long, 1ul>&")] Cpp_array_rpgxvv* Dst, [MangledName("rhs")][NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned long, 1ul> const&")] Cpp_array_rpgxvv* Rhs)
	{
		return Multiword_inplace_binop_unsigned_long_unsigned_long_unsigned_long_unsigned_long_unsigned_long_unsigned_long_1ul_1ul.Invoke(Add_with_carry_unsigned_long.__pointer, Dst, Rhs);
	}
}
