using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm256ELb0EmE12add_overflowERKS1_")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long>::add_overflow(__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long> const&)")]
internal static partial class BigInt_256ul_false_unsigned_long_add_overflow_BigInt_256ul_false_unsigned_long_const
{
	public unsafe static long Invoke(void* @this, void* rhs)
	{
		return unchecked(unsigned_long_multiword_add_with_carry_unsigned_long_4ul_4ul_cpp_array_unsigned_long_4ul_cpp_array_unsigned_long_4ul_const.Invoke(&((BigInt_x9dsed*)@this)->val, &((BigInt_x9dsed*)rhs)->val));
	}
}
