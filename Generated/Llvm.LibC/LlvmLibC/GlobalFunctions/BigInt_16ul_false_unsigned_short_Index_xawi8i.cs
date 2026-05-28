using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_16ul_false_unsigned_short_Index_xawi8i
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm16ELb0EtEixEm")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<16ul, false, unsigned short>::operator[](unsigned long)")]
	[CleanName("BigInt_16ul_false_unsigned_short_Index")]
	public unsafe static void* Invoke([MangledName("this")] BigInt_ys7s55* This, [MangledName("i")][NativeType("unsigned long")] long I)
	{
		return Array_unsigned_short_1ul_Index_yq9pn3.Invoke(&This->Val, I);
	}
}
