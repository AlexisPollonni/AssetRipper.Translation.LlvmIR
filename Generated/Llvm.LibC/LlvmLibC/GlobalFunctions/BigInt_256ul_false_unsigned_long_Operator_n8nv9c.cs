using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_256ul_false_unsigned_long_Operator_n8nv9c
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm256ELb0EmEmIERKS1_")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long>::operator-=(__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long> const&)")]
	[CleanName("BigInt_256ul_false_unsigned_long_Operator")]
	public unsafe static BigInt_x9dsed* Invoke([MangledName("this")] BigInt_x9dsed* This, [MangledName("other")][NativeType("__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long> const&")] BigInt_x9dsed* Other)
	{
		BigInt_256ul_false_unsigned_long_sub_overflow.Invoke(This, Other);
		return This;
	}
}
