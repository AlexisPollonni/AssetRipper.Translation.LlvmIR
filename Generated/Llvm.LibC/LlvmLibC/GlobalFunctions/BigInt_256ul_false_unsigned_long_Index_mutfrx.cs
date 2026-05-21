using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_256ul_false_unsigned_long_Index_mutfrx
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm256ELb0EmEixEm")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long>::operator[](unsigned long)")]
	[CleanName("BigInt_256ul_false_unsigned_long_Index")]
	public unsafe static void* Invoke(BigInt_x9dsed* @this, [NativeType("unsigned long")] long i)
	{
		return array_unsigned_long_4ul_Index_6jyt8f.Invoke(&@this->val, i);
	}
}
