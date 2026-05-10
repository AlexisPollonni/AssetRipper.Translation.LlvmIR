using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_oRERNS_6BigIntILm64ELb0EmEERKS1_")]
[DemangledName("__llvm_libc_20_1_2_::operator|=(__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long>&, __llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long> const&)")]
internal static partial class operator_BigInt_64ul_false_unsigned_long_BigInt_64ul_false_unsigned_long_const
{
	public unsafe static long Invoke(void* lhs, void* rhs)
	{
		BigInt_nx6qdt bigInt_nx6qdt = default(BigInt_nx6qdt);
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		unchecked
		{
			for (num = 0L; (ulong)num < 1uL; num++)
			{
				long num2 = *(long*)BigInt_64ul_false_unsigned_long_operator_unsigned_long_const_64yjsu.Invoke(rhs, num);
				*(long*)BigInt_64ul_false_unsigned_long_operator_unsigned_long_kztvyk.Invoke(lhs, num) |= num2;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
			llvm_memcpy_p0_p0_i64.Invoke(&bigInt_nx6qdt, lhs, 8L, isVolatile: false);
			return *(long*)(&bigInt_nx6qdt.val.Data);
		}
	}
}
