using System;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm128ELb0EmEC2IovEET_")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>::BigInt<unsigned __int128, void>(unsigned __int128)")]
internal static partial class BigInt_128ul_false_unsigned_long_BigInt_unsigned_int128_void_unsigned_int128
{
	public unsafe static void Invoke(void* @this, [MangledName("v.coerce0")] long v, [MangledName("v.coerce1")] long T_SIZE)
	{
		Int128 @int = default(Int128);
		long num = 0L;
		sbyte b = 0;
		long num2 = 0L;
		unchecked
		{
			*(long*)(&@int) = v;
			((long*)(&@int))[1] = T_SIZE;
			Int128 int2 = @int;
			llvm_memset_p0_i64.Invoke(&((BigInt_qdkjbh*)@this)->val.Data, 0, 16L, isVolatile: false);
			llvm_lifetime_start_p0.Invoke(8L, &num);
			num = 128L;
			llvm_lifetime_start_p0.Invoke(1L, &b);
			b = (NumericHelper.IntCmpUlt(int2, 0L) ? ((sbyte)1) : ((sbyte)0));
			llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = 0L;
			int num3;
			while (true)
			{
				if ((ulong)num2 >= 2uL)
				{
					num3 = 2;
					break;
				}
				if (NumericHelper.IntCmpEq(int2, 0L))
				{
					BigInt_128ul_false_unsigned_long_extend_unsigned_long_bool.Invoke(@this, num2, (b & 1) == 1);
					num3 = 1;
					break;
				}
				long num4 = (long)int2;
				*(long*)cpp_array_unsigned_long_2ul_operator_unsigned_long.Invoke(&((BigInt_qdkjbh*)@this)->val, num2) = num4;
				int2 = NumericHelper.ShiftRightLogical(int2, 64L);
				num2++;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			if (num3 == 2)
			{
				num3 = 0;
			}
			llvm_lifetime_end_p0.Invoke(1L, &b);
			llvm_lifetime_end_p0.Invoke(8L, &num);
			switch (num3)
			{
			case 0:
			case 1:
				return;
			}
			throw null;
		}
	}
}
