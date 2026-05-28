using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_64ul_false_unsigned_long_Index_6xqgif
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm64ELb0EmEixEm")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long>::operator[](unsigned long)")]
	[CleanName("BigInt_64ul_false_unsigned_long_Index")]
	public unsafe static void* Invoke([MangledName("this")] BigInt_555ggs* This, [MangledName("i")][NativeType("unsigned long")] long I)
	{
		return Array_unsigned_long_1ul_Index_3erz3i.Invoke(&This->Val, I);
	}
}
