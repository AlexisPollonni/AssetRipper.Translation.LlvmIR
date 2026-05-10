using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm64ELb0EmEC2ILm128ELb0EmEERKNS0_IXT_EXT0_ET1_EE")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long>::BigInt<128ul, false, unsigned long>(__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long> const&)")]
internal static partial class BigInt_64ul_false_unsigned_long_BigInt_128ul_false_unsigned_long_BigInt_128ul_false_unsigned_long_const
{
	public unsafe static void Invoke(void* @this, void* other)
	{
		sbyte b = 0;
		long num = 0L;
		unchecked
		{
			llvm_memset_p0_i64.Invoke(&((BigInt_nx6qdt*)@this)->val.Data, 0, 8L, isVolatile: false);
			llvm_lifetime_start_p0.Invoke(1L, &b);
			b = 0;
			llvm_lifetime_start_p0.Invoke(8L, &num);
			for (num = 0L; (ulong)num < 1uL; num++)
			{
				long num2 = *(long*)BigInt_128ul_false_unsigned_long_operator_unsigned_long_const_ua9ih9.Invoke(other, num);
				*(long*)cpp_array_unsigned_long_1ul_operator_unsigned_long.Invoke(&((BigInt_nx6qdt*)@this)->val, num) = num2;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
			llvm_lifetime_end_p0.Invoke(1L, &b);
		}
	}
}
