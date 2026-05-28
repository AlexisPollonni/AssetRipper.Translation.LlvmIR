using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_128ul_false_unsigned_long_sub_overflow
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm128ELb0EmE12sub_overflowERKS1_")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>::sub_overflow(__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long> const&)")]
	public unsafe static long Invoke([MangledName("this")] Anon_izyfb7* This, [MangledName("rhs")][NativeType("__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long> const&")] Anon_izyfb7* Rhs)
	{
		return unchecked(Multiword_sub_with_borrow_unsigned_long_2ul_2ul.Invoke(&((BigInt_qdkjbh*)This)->Val, &((BigInt_qdkjbh*)Rhs)->Val));
	}
}
