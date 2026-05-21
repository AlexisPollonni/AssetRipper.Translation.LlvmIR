using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_192ul_false_unsigned_long_Index
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm192ELb0EmEixEm")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<192ul, false, unsigned long>::operator[](unsigned long) const")]
	public unsafe static void* Invoke([MangledName("this")] Llvm_libc_20_1_2_BigInt_khh67p* This, [MangledName("i")][NativeType("unsigned long")] long I)
	{
		return Array_unsigned_long_3ul_Index_urpq28.Invoke(&This->Val, I);
	}
}
