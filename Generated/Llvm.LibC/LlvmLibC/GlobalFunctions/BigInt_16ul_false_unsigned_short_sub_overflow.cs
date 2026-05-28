using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_16ul_false_unsigned_short_sub_overflow
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm16ELb0EtE12sub_overflowERKS1_")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<16ul, false, unsigned short>::sub_overflow(__llvm_libc_20_1_2_::BigInt<16ul, false, unsigned short> const&)")]
	public unsafe static short Invoke([MangledName("this")] BigInt_ys7s55* This, [MangledName("rhs")][NativeType("__llvm_libc_20_1_2_::BigInt<16ul, false, unsigned short> const&")] BigInt_ys7s55* Rhs)
	{
		return Multiword_sub_with_borrow_unsigned_short_1ul_1ul.Invoke(&This->Val, &Rhs->Val);
	}
}
