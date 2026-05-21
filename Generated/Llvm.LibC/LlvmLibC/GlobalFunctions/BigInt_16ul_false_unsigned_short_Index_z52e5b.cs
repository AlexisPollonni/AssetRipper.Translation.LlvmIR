using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_16ul_false_unsigned_short_Index_z52e5b
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm16ELb0EtEixEm")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<16ul, false, unsigned short>::operator[](unsigned long) const")]
	[CleanName("BigInt_16ul_false_unsigned_short_Index")]
	public unsafe static void* Invoke(BigInt_ys7s55* @this, [NativeType("unsigned long")] long i)
	{
		return array_unsigned_short_1ul_Index_25c283.Invoke(&@this->val, i);
	}
}
