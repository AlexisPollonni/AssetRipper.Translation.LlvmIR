using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm256ELb0EmEixEm")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long>::operator[](unsigned long) const")]
[CleanName("BigInt_256ul_false_unsigned_long_operator_unsigned_long_const")]
internal static partial class BigInt_256ul_false_unsigned_long_operator_unsigned_long_const_g5vf7y
{
	public unsafe static void* Invoke(BigInt_x9dsed* @this, long i)
	{
		return cpp_array_unsigned_long_4ul_operator_unsigned_long_const.Invoke(&@this->val, i);
	}
}
