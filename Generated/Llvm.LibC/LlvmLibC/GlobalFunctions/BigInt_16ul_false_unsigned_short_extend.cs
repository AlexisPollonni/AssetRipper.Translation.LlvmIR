using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_16ul_false_unsigned_short_extend
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm16ELb0EtE6extendEmb")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<16ul, false, unsigned short>::extend(unsigned long, bool)")]
	public unsafe static void Invoke([MangledName("this")] BigInt_ys7s55* This, [MangledName("index")][NativeType("unsigned long")] long Index, [MangledName("is_neg")][NativeType("bool")] bool Is_neg)
	{
		short num = 0;
		long num2 = 0L;
		sbyte b = (Is_neg ? ((sbyte)1) : ((sbyte)0));
		Llvm_lifetime_start_p0.Invoke(2L, &num);
		num = InstructionHelper.Select((b & 1) == 1, Integer_impl_unsigned_short_unsigned_short_0_unsigned_short_65535_max.Invoke(), Integer_impl_unsigned_short_unsigned_short_0_unsigned_short_65535_min.Invoke());
		Llvm_lifetime_start_p0.Invoke(8L, &num2);
		unchecked
		{
			for (num2 = Index; (ulong)num2 < 1uL; num2++)
			{
				short num3 = num;
				*(short*)Array_unsigned_short_1ul_Index_yq9pn3.Invoke(&This->Val, num2) = num3;
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num2);
			Llvm_lifetime_end_p0.Invoke(2L, &num);
		}
	}
}
