using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm128ELb0EmEC2IivEET_")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>::BigInt<int, void>(int)")]
internal static partial class BigInt_128ul_false_unsigned_long_BigInt_int_void_int
{
	public unsafe static void Invoke(void* @this, int v)
	{
		long num = 0L;
		sbyte b = 0;
		long num2 = 0L;
		int num3 = v;
		unchecked
		{
			llvm_memset_p0_i64.Invoke(&((BigInt_qdkjbh*)@this)->val.Data, 0, 16L, isVolatile: false);
			llvm_lifetime_start_p0.Invoke(8L, &num);
			num = 32L;
			llvm_lifetime_start_p0.Invoke(1L, &b);
			b = ((num3 < 0) ? ((sbyte)1) : ((sbyte)0));
			llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = 0L;
			int num4;
			while (true)
			{
				if ((ulong)num2 >= 2uL)
				{
					num4 = 2;
					break;
				}
				if (num3 == 0)
				{
					BigInt_128ul_false_unsigned_long_extend_unsigned_long_bool.Invoke(@this, num2, (b & 1) == 1);
					num4 = 1;
					break;
				}
				*(long*)cpp_array_unsigned_long_2ul_operator_unsigned_long.Invoke(&((BigInt_qdkjbh*)@this)->val, num2) = num3;
				num3 = 0;
				num2++;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			if (num4 == 2)
			{
				num4 = 0;
			}
			llvm_lifetime_end_p0.Invoke(1L, &b);
			llvm_lifetime_end_p0.Invoke(8L, &num);
			switch (num4)
			{
			case 0:
			case 1:
				return;
			}
			throw null;
		}
	}
}
