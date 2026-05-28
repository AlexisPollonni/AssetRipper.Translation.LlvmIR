using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_64ul_false_unsigned_long_extend
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm64ELb0EmE6extendEmb")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long>::extend(unsigned long, bool)")]
	public unsafe static void Invoke([MangledName("this")] BigInt_555ggs* This, [MangledName("index")][NativeType("unsigned long")] long Index, [MangledName("is_neg")][NativeType("bool")] bool Is_neg)
	{
		long num = 0L;
		long num2 = 0L;
		sbyte b = (Is_neg ? ((sbyte)1) : ((sbyte)0));
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = InstructionHelper.Select((b & 1) == 1, Integer_impl_unsigned_long_0ul_18446744073709551615ul_max.Invoke(), Integer_impl_unsigned_long_0ul_18446744073709551615ul_min.Invoke());
		Llvm_lifetime_start_p0.Invoke(8L, &num2);
		unchecked
		{
			for (num2 = Index; (ulong)num2 < 1uL; num2++)
			{
				long num3 = num;
				*(long*)Array_unsigned_long_1ul_Index_3erz3i.Invoke(&This->Val, num2) = num3;
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num2);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
		}
	}
}
