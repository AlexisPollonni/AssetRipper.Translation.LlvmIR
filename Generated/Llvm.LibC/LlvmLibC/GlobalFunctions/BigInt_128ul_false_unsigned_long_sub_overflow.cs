using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_128ul_false_unsigned_long_sub_overflow
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm128ELb0EmE12sub_overflowERKS1_")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>::sub_overflow(__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long> const&)")]
	public unsafe static long Invoke(anon_izyfb7* @this, [NativeType("__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long> const&")] anon_izyfb7* rhs)
	{
		return unchecked(multiword_sub_with_borrow_unsigned_long_2ul_2ul.Invoke(&((BigInt_qdkjbh*)@this)->val, &((BigInt_qdkjbh*)rhs)->val));
	}
}
