using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_32ul_false_unsigned_int_Index_w3q3b2
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm32ELb0EjEixEm")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<32ul, false, unsigned int>::operator[](unsigned long) const")]
	[CleanName("BigInt_32ul_false_unsigned_int_Index")]
	public unsafe static void* Invoke([MangledName("this")] Llvm_libc_20_1_2_BigInt_vtm4cw* This, [MangledName("i")][NativeType("unsigned long")] long I)
	{
		return Array_unsigned_int_1ul_Index_9mw8rm.Invoke(&This->Val, I);
	}
}
