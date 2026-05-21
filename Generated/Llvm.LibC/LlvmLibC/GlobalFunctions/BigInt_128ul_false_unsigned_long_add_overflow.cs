using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_128ul_false_unsigned_long_add_overflow
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm128ELb0EmE12add_overflowERKS1_")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>::add_overflow(__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long> const&)")]
	public unsafe static long Invoke(anon_izyfb7* @this, [NativeType("__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long> const&")] anon_izyfb7* rhs)
	{
		return unchecked(multiword_add_with_carry_unsigned_long_2ul_2ul.Invoke(&((BigInt_qdkjbh*)@this)->val, &((BigInt_qdkjbh*)rhs)->val));
	}
}
