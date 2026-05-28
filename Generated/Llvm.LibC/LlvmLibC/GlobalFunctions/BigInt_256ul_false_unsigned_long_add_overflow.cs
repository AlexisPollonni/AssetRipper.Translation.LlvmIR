using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_256ul_false_unsigned_long_add_overflow
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm256ELb0EmE12add_overflowERKS1_")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long>::add_overflow(__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long> const&)")]
	public unsafe static long Invoke([MangledName("this")] BigInt_x9dsed* This, [MangledName("rhs")][NativeType("__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long> const&")] BigInt_x9dsed* Rhs)
	{
		return Multiword_add_with_carry_unsigned_long_4ul_4ul.Invoke(&This->Val, &Rhs->Val);
	}
}
