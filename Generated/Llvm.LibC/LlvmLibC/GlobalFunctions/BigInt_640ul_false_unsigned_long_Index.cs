using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_640ul_false_unsigned_long_Index
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm640ELb0EmEixEm")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<640ul, false, unsigned long>::operator[](unsigned long) const")]
	public unsafe static void* Invoke([MangledName("this")] BigInt_m94xi3* This, [MangledName("i")][NativeType("unsigned long")] long I)
	{
		return Array_unsigned_long_10ul_Index_bujwnj.Invoke(&This->Val, I);
	}
}
