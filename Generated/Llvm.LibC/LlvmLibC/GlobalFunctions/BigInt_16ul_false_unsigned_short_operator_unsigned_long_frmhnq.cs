using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm16ELb0EtEixEm")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<16ul, false, unsigned short>::operator[](unsigned long)")]
[CleanName("BigInt_16ul_false_unsigned_short_operator_unsigned_long")]
internal static partial class BigInt_16ul_false_unsigned_short_operator_unsigned_long_frmhnq
{
	public unsafe static void* Invoke(BigInt_ys7s55* @this, long i)
	{
		return cpp_array_unsigned_short_1ul_operator_unsigned_long.Invoke(&@this->val, i);
	}
}
