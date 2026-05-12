using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm640ELb0EmEixEm")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<640ul, false, unsigned long>::operator[](unsigned long) const")]
internal static partial class BigInt_640ul_false_unsigned_long_operator_unsigned_long_const
{
	public unsafe static void* Invoke(BigInt_m94xi3* @this, long i)
	{
		return cpp_array_unsigned_long_10ul_operator_unsigned_long_const.Invoke(&@this->val, i);
	}
}
