using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm128ELb0EmEC2ILm16512ELb0EmEERKNS0_IXT_EXT0_ET1_EE")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>::BigInt<16512ul, false, unsigned long>(__llvm_libc_20_1_2_::BigInt<16512ul, false, unsigned long> const&)")]
internal static partial class BigInt_128ul_false_unsigned_long_BigInt_16512ul_false_unsigned_long_BigInt_16512ul_false_unsigned_long_const
{
	public unsafe static void Invoke(anon_izyfb7* @this, BigInt_q8g275* other)
	{
		sbyte b = 0;
		long num = 0L;
		unchecked
		{
			llvm_memset_p0_i64.Invoke(&((BigInt_qdkjbh*)@this)->val.Data, 0, 16L, isVolatile: false);
			llvm_lifetime_start_p0.Invoke(1L, &b);
			b = 0;
			llvm_lifetime_start_p0.Invoke(8L, &num);
			for (num = 0L; (ulong)num < 2uL; num++)
			{
				long num2 = *(long*)BigInt_16512ul_false_unsigned_long_operator_unsigned_long_const_h7iz72.Invoke(other, num);
				*(long*)cpp_array_unsigned_long_2ul_operator_unsigned_long.Invoke(&((BigInt_qdkjbh*)@this)->val, num) = num2;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
			llvm_lifetime_end_p0.Invoke(1L, &b);
		}
	}
}
