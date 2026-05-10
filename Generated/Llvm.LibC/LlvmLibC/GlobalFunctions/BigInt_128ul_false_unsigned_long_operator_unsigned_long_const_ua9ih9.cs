using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm128ELb0EmEixEm")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>::operator[](unsigned long) const")]
[CleanName("BigInt_128ul_false_unsigned_long_operator_unsigned_long_const")]
internal static partial class BigInt_128ul_false_unsigned_long_operator_unsigned_long_const_ua9ih9
{
	public unsafe static void* Invoke(void* @this, long i)
	{
		return cpp_array_unsigned_long_2ul_operator_unsigned_long_const.Invoke(&unchecked((BigInt_qdkjbh*)@this)->val, i);
	}
}
