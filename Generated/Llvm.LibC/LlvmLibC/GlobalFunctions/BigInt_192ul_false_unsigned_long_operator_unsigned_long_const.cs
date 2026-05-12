using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm192ELb0EmEixEm")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<192ul, false, unsigned long>::operator[](unsigned long) const")]
internal static partial class BigInt_192ul_false_unsigned_long_operator_unsigned_long_const
{
	public unsafe static void* Invoke(BigInt_ghrwnp* @this, long i)
	{
		return cpp_array_unsigned_long_3ul_operator_unsigned_long_const.Invoke(&@this->val, i);
	}
}
