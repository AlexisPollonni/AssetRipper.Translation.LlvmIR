using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_64ul_false_unsigned_long_Index_64yjsu
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm64ELb0EmEixEm")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long>::operator[](unsigned long) const")]
	[CleanName("BigInt_64ul_false_unsigned_long_Index")]
	public unsafe static void* Invoke([MangledName("this")] Llvm_libc_20_1_2_BigInt_555ggs* This, [MangledName("i")][NativeType("unsigned long")] long I)
	{
		return Array_unsigned_long_1ul_Index_fk3nam.Invoke(&This->Val, I);
	}
}
