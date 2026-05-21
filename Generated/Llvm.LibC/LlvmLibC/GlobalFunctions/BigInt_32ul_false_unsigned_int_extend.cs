using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_32ul_false_unsigned_int_extend
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm32ELb0EjE6extendEmb")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<32ul, false, unsigned int>::extend(unsigned long, bool)")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_BigInt_vtm4cw* This, [MangledName("index")][NativeType("unsigned long")] long Index, [MangledName("is_neg")][NativeType("bool")] bool Is_neg)
	{
		int num = 0;
		long num2 = 0L;
		sbyte b = (Is_neg ? ((sbyte)1) : ((sbyte)0));
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = InstructionHelper.Select((b & 1) == 1, Integer_impl_unsigned_int_0u_4294967295u_max.Invoke(), Integer_impl_unsigned_int_0u_4294967295u_min.Invoke());
		Llvm_lifetime_start_p0.Invoke(8L, &num2);
		unchecked
		{
			for (num2 = Index; (ulong)num2 < 1uL; num2++)
			{
				int num3 = num;
				*(int*)Array_unsigned_int_1ul_Index_ejbtjs.Invoke(&This->Val, num2) = num3;
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num2);
			Llvm_lifetime_end_p0.Invoke(4L, &num);
		}
	}
}
