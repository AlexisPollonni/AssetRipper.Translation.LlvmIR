using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_64ul_false_unsigned_long_Operator_wnux5g
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm64ELb0EmEmIERKS1_")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long>::operator-=(__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long> const&)")]
	[CleanName("BigInt_64ul_false_unsigned_long_Operator")]
	public unsafe static Llvm_libc_20_1_2_BigInt_555ggs* Invoke([MangledName("this")] Llvm_libc_20_1_2_BigInt_555ggs* This, [MangledName("other")][NativeType("__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long> const&")] Llvm_libc_20_1_2_BigInt_555ggs* Other)
	{
		BigInt_64ul_false_unsigned_long_sub_overflow.Invoke(This, Other);
		return This;
	}
}
