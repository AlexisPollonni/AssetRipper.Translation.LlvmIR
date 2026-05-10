using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm32ELb0EjEixEm")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<32ul, false, unsigned int>::operator[](unsigned long)")]
[CleanName("BigInt_32ul_false_unsigned_int_operator_unsigned_long")]
internal static partial class BigInt_32ul_false_unsigned_int_operator_unsigned_long_pb64yf
{
	public unsafe static void* Invoke(void* @this, long i)
	{
		return cpp_array_unsigned_int_1ul_operator_unsigned_long.Invoke(&unchecked((BigInt_fzjdu3*)@this)->val, i);
	}
}
