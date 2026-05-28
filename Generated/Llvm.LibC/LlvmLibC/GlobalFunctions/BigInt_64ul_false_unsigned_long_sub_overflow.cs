using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_64ul_false_unsigned_long_sub_overflow
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm64ELb0EmE12sub_overflowERKS1_")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long>::sub_overflow(__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long> const&)")]
	public unsafe static long Invoke([MangledName("this")] BigInt_555ggs* This, [MangledName("rhs")][NativeType("__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long> const&")] BigInt_555ggs* Rhs)
	{
		return Multiword_sub_with_borrow_unsigned_long_1ul_1ul.Invoke(&This->Val, &Rhs->Val);
	}
}
