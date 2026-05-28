using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_128ul_false_unsigned_long_Multiply
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm128ELb0EmEmlERKS1_")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>::operator*(__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long> const&) const")]
	public unsafe static Struct_fiz2nb Invoke([MangledName("this")] Anon_izyfb7* This, [MangledName("other")][NativeType("__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long> const&")] Anon_izyfb7* Other)
	{
		BigInt_qdkjbh bigInt_qdkjbh = default(BigInt_qdkjbh);
		BigInt_x9dsed bigInt_x9dsed = default(BigInt_x9dsed);
		Llvm_lifetime_start_p0.Invoke(32L, &bigInt_x9dsed);
		BigInt_128ul_false_unsigned_long_ful_mul_128ul.Invoke(&bigInt_x9dsed, This, Other);
		unchecked
		{
			BigInt_128ul_false_unsigned_long_BigInt_256ul_false_unsigned_long.Invoke((Anon_izyfb7*)(&bigInt_qdkjbh), &bigInt_x9dsed);
			Llvm_lifetime_end_p0.Invoke(32L, &bigInt_x9dsed);
			return *(Struct_fiz2nb*)(&bigInt_qdkjbh.Val.Data);
		}
	}
}
