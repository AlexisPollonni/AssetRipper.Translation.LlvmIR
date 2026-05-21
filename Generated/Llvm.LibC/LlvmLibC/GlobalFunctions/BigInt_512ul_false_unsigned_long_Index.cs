using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_512ul_false_unsigned_long_Index
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm512ELb0EmEixEm")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<512ul, false, unsigned long>::operator[](unsigned long) const")]
	public unsafe static void* Invoke(BigInt_fjg8pd* @this, [NativeType("unsigned long")] long i)
	{
		return array_unsigned_long_8ul_Index_32sgdp.Invoke(&@this->val, i);
	}
}
