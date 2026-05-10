using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_eqERKNS_6BigIntILm128ELb0EmEES3_")]
[DemangledName("__llvm_libc_20_1_2_::operator==(__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long> const&, __llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long> const&)")]
[CleanName("operator_BigInt_128ul_false_unsigned_long_const_BigInt_128ul_false_unsigned_long_const")]
internal static partial class operator_BigInt_128ul_false_unsigned_long_const_BigInt_128ul_false_unsigned_long_const_u7vb72
{
	public unsafe static bool Invoke(void* lhs, void* rhs)
	{
		bool result = false;
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = 0L;
		unchecked
		{
			int num2;
			while (true)
			{
				if ((ulong)num >= 2uL)
				{
					num2 = 2;
					break;
				}
				if (*(long*)cpp_array_unsigned_long_2ul_operator_unsigned_long_const.Invoke(&((BigInt_qdkjbh*)lhs)->val, num) != *(long*)cpp_array_unsigned_long_2ul_operator_unsigned_long_const.Invoke(&((BigInt_qdkjbh*)rhs)->val, num))
				{
					result = false;
					num2 = 1;
					break;
				}
				num++;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
			int num3 = num2;
			if (num3 != 2)
			{
				if (num3 != 1)
				{
					throw null;
				}
			}
			else
			{
				result = true;
			}
			return result;
		}
	}
}
