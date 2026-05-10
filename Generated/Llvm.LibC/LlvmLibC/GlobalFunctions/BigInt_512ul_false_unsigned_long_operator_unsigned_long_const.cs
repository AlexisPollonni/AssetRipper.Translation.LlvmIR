using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm512ELb0EmEixEm")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<512ul, false, unsigned long>::operator[](unsigned long) const")]
internal static partial class BigInt_512ul_false_unsigned_long_operator_unsigned_long_const
{
	public unsafe static void* Invoke(void* @this, long i)
	{
		return cpp_array_unsigned_long_8ul_operator_unsigned_long_const.Invoke(&unchecked((BigInt_fjg8pd*)@this)->val, i);
	}
}
