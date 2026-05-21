using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_128ul_false_unsigned_long_BigInt_2ul
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm128ELb0EmEC2ILm2EEERAT__Km")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>::BigInt<2ul>(unsigned long const (&) [2ul])")]
	public unsafe static void Invoke([MangledName("this")] Anon_izyfb7* This, [MangledName("nums")][NativeType("unsigned long const (&) [2ul]")] void* Nums)
	{
		long num = 0L;
		unchecked
		{
			Llvm_memset_p0_i64.Invoke(&((Llvm_libc_20_1_2_BigInt_qdkjbh*)This)->Val.Data, 0, 16L, isVolatile: false);
			Llvm_lifetime_start_p0.Invoke(8L, &num);
			for (num = 0L; (ulong)num < 2uL; num++)
			{
				long num2 = ((long*)Nums)[num];
				*(long*)Array_unsigned_long_2ul_Index_6dk93t.Invoke(&((Llvm_libc_20_1_2_BigInt_qdkjbh*)This)->Val, num) = num2;
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num);
		}
	}
}
