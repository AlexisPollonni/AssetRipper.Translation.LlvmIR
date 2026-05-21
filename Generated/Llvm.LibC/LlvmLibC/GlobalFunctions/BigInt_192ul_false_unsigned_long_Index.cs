using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_192ul_false_unsigned_long_Index
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm192ELb0EmEixEm")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<192ul, false, unsigned long>::operator[](unsigned long) const")]
	public unsafe static void* Invoke(BigInt_khh67p* @this, [NativeType("unsigned long")] long i)
	{
		return array_unsigned_long_3ul_Index_urpq28.Invoke(&@this->val, i);
	}
}
