using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cmpERKNS_6BigIntILm128ELb0EmEES3_")]
[DemangledName("__llvm_libc_20_1_2_::cmp(__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long> const&, __llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long> const&)")]
internal static partial class cmp_BigInt_128ul_false_unsigned_long_const_BigInt_128ul_false_unsigned_long_const
{
	public unsafe static int Invoke(void* lhs, void* rhs)
	{
		int result = 0;
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		long num = 0L;
		int num2 = 0;
		llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb8);
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = 2L;
		unchecked
		{
			int num4;
			while (true)
			{
				long num3 = num;
				num = num3 + -1L;
				if ((ulong)num3 <= 0uL)
				{
					num4 = 2;
					break;
				}
				llvm_lifetime_start_p0.Invoke(4L, &num2);
				num2 = cmp_BigInt_128ul_false_unsigned_long_const_BigInt_128ul_false_unsigned_long_const_lambda_unsigned_long_unsigned_long_operator_unsigned_long_unsigned_long_const.Invoke(&anon_izyfb8, *(long*)BigInt_128ul_false_unsigned_long_operator_unsigned_long_const_ua9ih9.Invoke(lhs, num), *(long*)BigInt_128ul_false_unsigned_long_operator_unsigned_long_const_ua9ih9.Invoke(rhs, num));
				if (num2 != 0)
				{
					result = num2;
					num4 = 1;
				}
				else
				{
					num4 = 0;
				}
				llvm_lifetime_end_p0.Invoke(4L, &num2);
				switch (num4)
				{
				case 0:
					continue;
				}
				break;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
			if (num4 == 2)
			{
				result = 0;
			}
			llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
			return result;
		}
	}
}
