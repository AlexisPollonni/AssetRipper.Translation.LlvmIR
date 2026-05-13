using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm32ELb0EjEixEm")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<32ul, false, unsigned int>::operator[](unsigned long) const")]
[CleanName("BigInt_32ul_false_unsigned_int_operator_unsigned_long_const")]
internal static partial class BigInt_32ul_false_unsigned_int_operator_unsigned_long_const_w3q3b2
{
	public unsafe static void* Invoke(BigInt_fzjdu3* @this, long i)
	{
		return cpp_array_unsigned_int_1ul_operator_unsigned_long_const.Invoke(&@this->val, i);
	}
}
