using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_256ul_false_unsigned_long_extend
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm256ELb0EmE6extendEmb")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long>::extend(unsigned long, bool)")]
	public unsafe static void Invoke(BigInt_x9dsed* @this, [NativeType("unsigned long")] long index, [NativeType("bool")] bool is_neg)
	{
		long num = 0L;
		long num2 = 0L;
		sbyte b = (is_neg ? ((sbyte)1) : ((sbyte)0));
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = InstructionHelper.Select((b & 1) == 1, integer_impl_unsigned_long_0ul_18446744073709551615ul_max.Invoke(), integer_impl_unsigned_long_0ul_18446744073709551615ul_min.Invoke());
		llvm_lifetime_start_p0.Invoke(8L, &num2);
		unchecked
		{
			for (num2 = index; (ulong)num2 < 4uL; num2++)
			{
				long num3 = num;
				*(long*)array_unsigned_long_4ul_Index_6jyt8f.Invoke(&@this->val, num2) = num3;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			llvm_lifetime_end_p0.Invoke(8L, &num);
		}
	}
}
