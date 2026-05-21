using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_128ul_false_unsigned_long_Index_ua9ih9
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm128ELb0EmEixEm")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>::operator[](unsigned long) const")]
	[CleanName("BigInt_128ul_false_unsigned_long_Index")]
	public unsafe static void* Invoke(anon_izyfb7* @this, [NativeType("unsigned long")] long i)
	{
		return array_unsigned_long_2ul_Index_j6w6uu.Invoke(&unchecked((BigInt_qdkjbh*)@this)->val, i);
	}
}
