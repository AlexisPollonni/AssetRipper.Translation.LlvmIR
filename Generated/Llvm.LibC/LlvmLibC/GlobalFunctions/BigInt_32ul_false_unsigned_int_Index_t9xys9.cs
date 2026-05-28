using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_32ul_false_unsigned_int_Index_t9xys9
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm32ELb0EjEixEm")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<32ul, false, unsigned int>::operator[](unsigned long)")]
	[CleanName("BigInt_32ul_false_unsigned_int_Index")]
	public unsafe static void* Invoke([MangledName("this")] BigInt_vtm4cw* This, [MangledName("i")][NativeType("unsigned long")] long I)
	{
		return Array_unsigned_int_1ul_Index_ejbtjs.Invoke(&This->Val, I);
	}
}
