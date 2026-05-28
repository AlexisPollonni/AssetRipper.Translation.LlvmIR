using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_128ul_false_unsigned_long_BigInt_int_void
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm128ELb0EmEC2IivEET_")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>::BigInt<int, void>(int)")]
	public unsafe static void Invoke([MangledName("this")] Anon_izyfb7* This, [MangledName("v")][NativeType("int")] int V)
	{
		long num = 0L;
		sbyte b = 0;
		long num2 = 0L;
		int num3 = V;
		unchecked
		{
			Llvm_memset_p0_i64.Invoke(&((BigInt_qdkjbh*)This)->Val.Data, 0, 16L, isVolatile: false);
			Llvm_lifetime_start_p0.Invoke(8L, &num);
			num = 32L;
			Llvm_lifetime_start_p0.Invoke(1L, &b);
			b = ((num3 < 0) ? ((sbyte)1) : ((sbyte)0));
			Llvm_lifetime_start_p0.Invoke(8L, &num2);
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
					BigInt_128ul_false_unsigned_long_extend.Invoke(This, num2, (b & 1) == 1);
					num4 = 1;
					break;
				}
				*(long*)Array_unsigned_long_2ul_Index_6dk93t.Invoke(&((BigInt_qdkjbh*)This)->Val, num2) = num3;
				num3 = 0;
				num2++;
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num2);
			if (num4 == 2)
			{
				num4 = 0;
			}
			Llvm_lifetime_end_p0.Invoke(1L, &b);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
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
