using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_32ul_false_unsigned_int_extend
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm32ELb0EjE6extendEmb")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<32ul, false, unsigned int>::extend(unsigned long, bool)")]
	public unsafe static void Invoke(BigInt_vtm4cw* @this, [NativeType("unsigned long")] long index, [NativeType("bool")] bool is_neg)
	{
		int num = 0;
		long num2 = 0L;
		sbyte b = (is_neg ? ((sbyte)1) : ((sbyte)0));
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = InstructionHelper.Select((b & 1) == 1, integer_impl_unsigned_int_0u_4294967295u_max.Invoke(), integer_impl_unsigned_int_0u_4294967295u_min.Invoke());
		llvm_lifetime_start_p0.Invoke(8L, &num2);
		unchecked
		{
			for (num2 = index; (ulong)num2 < 1uL; num2++)
			{
				int num3 = num;
				*(int*)array_unsigned_int_1ul_Index_ejbtjs.Invoke(&@this->val, num2) = num3;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			llvm_lifetime_end_p0.Invoke(4L, &num);
		}
	}
}
