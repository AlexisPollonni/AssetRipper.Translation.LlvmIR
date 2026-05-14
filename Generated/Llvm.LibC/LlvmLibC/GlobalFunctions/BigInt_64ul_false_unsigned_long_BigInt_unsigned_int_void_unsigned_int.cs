using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm64ELb0EmEC2IjvEET_")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long>::BigInt<unsigned int, void>(unsigned int)")]
internal static partial class BigInt_64ul_false_unsigned_long_BigInt_unsigned_int_void_unsigned_int
{
	public unsafe static void Invoke(BigInt_555ggs* @this, int v)
	{
		long num = 0L;
		sbyte b = 0;
		long num2 = 0L;
		int num3 = v;
		llvm_memset_p0_i64.Invoke(&@this->val.Data, 0, 8L, isVolatile: false);
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = 32L;
		llvm_lifetime_start_p0.Invoke(1L, &b);
		unchecked
		{
			b = (((uint)num3 < 0u) ? ((sbyte)1) : ((sbyte)0));
			llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = 0L;
			int num4;
			while (true)
			{
				if ((ulong)num2 >= 1uL)
				{
					num4 = 2;
					break;
				}
				if (num3 == 0)
				{
					BigInt_64ul_false_unsigned_long_extend_unsigned_long_bool.Invoke(@this, num2, (b & 1) == 1);
					num4 = 1;
					break;
				}
				*(long*)cpp_array_unsigned_long_1ul_operator_unsigned_long.Invoke(&@this->val, num2) = (uint)num3;
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
			throw new NotImplementedException("Reached LLVM unreachable instruction.");
		}
	}
}
