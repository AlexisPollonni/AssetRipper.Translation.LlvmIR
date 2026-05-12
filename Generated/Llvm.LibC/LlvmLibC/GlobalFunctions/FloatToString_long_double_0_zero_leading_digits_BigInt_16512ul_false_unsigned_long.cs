using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_13FloatToStringIeLi0EE19zero_leading_digitsERNS_6BigIntILm16512ELb0EmEE")]
[DemangledName("__llvm_libc_20_1_2_::FloatToString<long double, 0>::zero_leading_digits(__llvm_libc_20_1_2_::BigInt<16512ul, false, unsigned long>&)")]
internal static partial class FloatToString_long_double_0_zero_leading_digits_BigInt_16512ul_false_unsigned_long
{
	public unsafe static void Invoke(BigInt_k36xhe* int_num)
	{
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		unchecked
		{
			for (num = 0L; (ulong)num < 2uL; num++)
			{
				*(long*)BigInt_16512ul_false_unsigned_long_operator_unsigned_long_jsva56.Invoke(int_num, num + 256L) = 0L;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
		}
	}
}
