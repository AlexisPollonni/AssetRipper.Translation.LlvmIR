using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_128ul_false_unsigned_long_quick_mul_hi
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm128ELb0EmE12quick_mul_hiERKS1_")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>::quick_mul_hi(__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long> const&) const")]
	public unsafe static Struct_fiz2nb Invoke(anon_izyfb7* @this, [NativeType("__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long> const&")] anon_izyfb7* other)
	{
		BigInt_qdkjbh bigInt_qdkjbh = default(BigInt_qdkjbh);
		unchecked
		{
			sbyte* ptr = (sbyte*)(&bigInt_qdkjbh);
			*(long*)ptr = -6148914691236517206L;
			((long*)ptr)[1] = -6148914691236517206L;
			BigInt_128ul_false_unsigned_long_Constructor.Invoke((anon_izyfb7*)(&bigInt_qdkjbh));
			multiword_quick_mul_hi_unsigned_long_2ul.Invoke(&bigInt_qdkjbh.val, &((BigInt_qdkjbh*)@this)->val, &((BigInt_qdkjbh*)other)->val);
			return *(Struct_fiz2nb*)(&bigInt_qdkjbh.val.Data);
		}
	}
}
