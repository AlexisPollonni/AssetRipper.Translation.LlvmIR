using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_192ul_false_unsigned_long_BigInt_3ul
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm192ELb0EmEC2ILm3EEERAT__Km")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<192ul, false, unsigned long>::BigInt<3ul>(unsigned long const (&) [3ul])")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_BigInt_khh67p* This, [MangledName("nums")][NativeType("unsigned long const (&) [3ul]")] void* Nums)
	{
		long num = 0L;
		Llvm_memset_p0_i64.Invoke(&This->Val.Data, 0, 24L, isVolatile: false);
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		unchecked
		{
			for (num = 0L; (ulong)num < 3uL; num++)
			{
				long num2 = ((long*)Nums)[num];
				*(long*)Array_unsigned_long_3ul_Index_rqhh8a.Invoke(&This->Val, num) = num2;
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num);
		}
	}
}
