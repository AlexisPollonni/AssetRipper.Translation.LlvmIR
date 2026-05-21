using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_128ul_false_unsigned_long_Operator_qwctfr
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm128ELb0EmEmIERKS1_")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>::operator-=(__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long> const&)")]
	[CleanName("BigInt_128ul_false_unsigned_long_Operator")]
	public unsafe static Anon_izyfb7* Invoke([MangledName("this")] Anon_izyfb7* This, [MangledName("other")][NativeType("__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long> const&")] Anon_izyfb7* Other)
	{
		BigInt_128ul_false_unsigned_long_sub_overflow.Invoke(This, Other);
		return This;
	}
}
