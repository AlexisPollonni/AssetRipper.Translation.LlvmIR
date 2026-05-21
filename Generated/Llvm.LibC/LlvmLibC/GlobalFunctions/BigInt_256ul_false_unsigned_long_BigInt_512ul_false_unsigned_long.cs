using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_256ul_false_unsigned_long_BigInt_512ul_false_unsigned_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm256ELb0EmEC2ILm512ELb0EmEERKNS0_IXT_EXT0_ET1_EE")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long>::BigInt<512ul, false, unsigned long>(__llvm_libc_20_1_2_::BigInt<512ul, false, unsigned long> const&)")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_BigInt_x9dsed* This, [MangledName("other")][NativeType("__llvm_libc_20_1_2_::BigInt<512ul, false, unsigned long> const&")] Llvm_libc_20_1_2_BigInt_fjg8pd* Other)
	{
		sbyte b = 0;
		long num = 0L;
		Llvm_memset_p0_i64.Invoke(&This->Val.Data, 0, 32L, isVolatile: false);
		Llvm_lifetime_start_p0.Invoke(1L, &b);
		b = 0;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		unchecked
		{
			for (num = 0L; (ulong)num < 4uL; num++)
			{
				long num2 = *(long*)BigInt_512ul_false_unsigned_long_Index.Invoke(Other, num);
				*(long*)Array_unsigned_long_4ul_Index_6jyt8f.Invoke(&This->Val, num) = num2;
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			Llvm_lifetime_end_p0.Invoke(1L, &b);
		}
	}
}
