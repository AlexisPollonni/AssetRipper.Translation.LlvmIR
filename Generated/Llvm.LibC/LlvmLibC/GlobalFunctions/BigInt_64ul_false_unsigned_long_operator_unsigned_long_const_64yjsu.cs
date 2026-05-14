using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm64ELb0EmEixEm")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long>::operator[](unsigned long) const")]
[CleanName("BigInt_64ul_false_unsigned_long_operator_unsigned_long_const")]
internal static partial class BigInt_64ul_false_unsigned_long_operator_unsigned_long_const_64yjsu
{
	public unsafe static void* Invoke(BigInt_555ggs* @this, long i)
	{
		return cpp_array_unsigned_long_1ul_operator_unsigned_long_const.Invoke(&@this->val, i);
	}
}
