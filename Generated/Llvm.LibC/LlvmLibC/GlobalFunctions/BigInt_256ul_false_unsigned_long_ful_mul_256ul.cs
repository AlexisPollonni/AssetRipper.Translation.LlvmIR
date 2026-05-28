using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_256ul_false_unsigned_long_ful_mul_256ul
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm256ELb0EmE7ful_mulILm256EEEDaRKNS0_IXT_ELb0EmEE")]
	[DemangledName("auto __llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long>::ful_mul<256ul>(__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long> const&) const")]
	[return: NativeType("auto")]
	public unsafe static void Invoke([MangledName("agg.result")] BigInt_fjg8pd* Agg_result, [MangledName("this")] BigInt_x9dsed* This, [MangledName("other")] BigInt_x9dsed* Other)
	{
		BigInt_fjg8pd bigInt_fjg8pd = default(BigInt_fjg8pd);
		Llvm_lifetime_start_p0.Invoke(64L, &bigInt_fjg8pd);
		Llvm_memset_p0_i64.Invoke(&bigInt_fjg8pd, -86, 64L, isVolatile: false);
		BigInt_512ul_false_unsigned_long_Constructor.Invoke(&bigInt_fjg8pd);
		Multiword_multiply_with_carry_unsigned_long_8ul_4ul_4ul.Invoke(&bigInt_fjg8pd.Val, &This->Val, &Other->Val);
		Llvm_memcpy_p0_p0_i64.Invoke(Agg_result, &bigInt_fjg8pd, 64L, isVolatile: false);
		Llvm_lifetime_end_p0.Invoke(64L, &bigInt_fjg8pd);
	}
}
