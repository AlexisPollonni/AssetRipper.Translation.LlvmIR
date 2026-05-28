using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_16ul_false_unsigned_short_BigInt_unsigned_short_void
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm16ELb0EtEC2ItvEET_")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<16ul, false, unsigned short>::BigInt<unsigned short, void>(unsigned short)")]
	public unsafe static void Invoke([MangledName("this")] BigInt_ys7s55* This, [MangledName("v")][NativeType("unsigned short")] short V)
	{
		long num = 0L;
		sbyte b = 0;
		long num2 = 0L;
		short num3 = V;
		Llvm_memset_p0_i64.Invoke(&This->Val.Data, 0, 2L, isVolatile: false);
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = 16L;
		Llvm_lifetime_start_p0.Invoke(1L, &b);
		unchecked
		{
			b = (((ushort)num3 < 0) ? ((sbyte)1) : ((sbyte)0));
			Llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = 0L;
			int num4;
			while (true)
			{
				if ((ulong)num2 >= 1uL)
				{
					num4 = 2;
					break;
				}
				if ((ushort)num3 == 0)
				{
					BigInt_16ul_false_unsigned_short_extend.Invoke(This, num2, (b & 1) == 1);
					num4 = 1;
					break;
				}
				*(short*)Array_unsigned_short_1ul_Index_yq9pn3.Invoke(&This->Val, num2) = num3;
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
