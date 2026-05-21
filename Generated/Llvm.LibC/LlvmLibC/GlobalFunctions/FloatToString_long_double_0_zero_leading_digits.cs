using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FloatToString_long_double_0_zero_leading_digits
{
	[MangledName("_ZN19__llvm_libc_20_1_2_13FloatToStringIeLi0EE19zero_leading_digitsERNS_6BigIntILm16512ELb0EmEE")]
	[DemangledName("__llvm_libc_20_1_2_::FloatToString<long double, 0>::zero_leading_digits(__llvm_libc_20_1_2_::BigInt<16512ul, false, unsigned long>&)")]
	public unsafe static void Invoke([MangledName("int_num")][NativeType("__llvm_libc_20_1_2_::BigInt<16512ul, false, unsigned long>&")] Llvm_libc_20_1_2_BigInt_q8g275* Int_num)
	{
		long num = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		unchecked
		{
			for (num = 0L; (ulong)num < 2uL; num++)
			{
				*(long*)BigInt_16512ul_false_unsigned_long_Index_jsva56.Invoke(Int_num, num + 256L) = 0L;
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num);
		}
	}
}
