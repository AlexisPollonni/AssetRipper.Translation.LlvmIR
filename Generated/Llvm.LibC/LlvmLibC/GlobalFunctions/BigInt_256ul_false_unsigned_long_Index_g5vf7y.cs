using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_256ul_false_unsigned_long_Index_g5vf7y
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm256ELb0EmEixEm")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long>::operator[](unsigned long) const")]
	[CleanName("BigInt_256ul_false_unsigned_long_Index")]
	public unsafe static void* Invoke([MangledName("this")] BigInt_x9dsed* This, [MangledName("i")][NativeType("unsigned long")] long I)
	{
		return Array_unsigned_long_4ul_Index_pwcpnu.Invoke(&This->Val, I);
	}
}
