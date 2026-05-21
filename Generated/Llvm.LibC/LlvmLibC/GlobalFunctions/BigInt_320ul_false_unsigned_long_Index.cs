using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_320ul_false_unsigned_long_Index
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm320ELb0EmEixEm")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<320ul, false, unsigned long>::operator[](unsigned long)")]
	public unsafe static void* Invoke([MangledName("this")] Llvm_libc_20_1_2_BigInt_76gxx6* This, [MangledName("i")][NativeType("unsigned long")] long I)
	{
		return Array_unsigned_long_5ul_Index_wu6ki8.Invoke(&This->Val, I);
	}
}
