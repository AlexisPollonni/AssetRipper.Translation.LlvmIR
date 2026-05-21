using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_256ul_false_unsigned_long_sub_overflow
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm256ELb0EmE12sub_overflowERKS1_")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long>::sub_overflow(__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long> const&)")]
	public unsafe static long Invoke([MangledName("this")] Llvm_libc_20_1_2_BigInt_x9dsed* This, [MangledName("rhs")][NativeType("__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long> const&")] Llvm_libc_20_1_2_BigInt_x9dsed* Rhs)
	{
		return Multiword_sub_with_borrow_unsigned_long_4ul_4ul.Invoke(&This->Val, &Rhs->Val);
	}
}
