using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_64ul_false_unsigned_long_Operator_wnux5g
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm64ELb0EmEmIERKS1_")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long>::operator-=(__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long> const&)")]
	[CleanName("BigInt_64ul_false_unsigned_long_Operator")]
	public unsafe static BigInt_555ggs* Invoke(BigInt_555ggs* @this, [NativeType("__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long> const&")] BigInt_555ggs* other)
	{
		BigInt_64ul_false_unsigned_long_sub_overflow.Invoke(@this, other);
		return @this;
	}
}
