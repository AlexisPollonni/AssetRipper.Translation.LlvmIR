using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm16512ELb0EmEixEm")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<16512ul, false, unsigned long>::operator[](unsigned long)")]
[CleanName("BigInt_16512ul_false_unsigned_long_operator_unsigned_long")]
internal static partial class BigInt_16512ul_false_unsigned_long_operator_unsigned_long_jsva56
{
	public unsafe static void* Invoke(BigInt_k36xhe* @this, long i)
	{
		return cpp_array_unsigned_long_258ul_operator_unsigned_long.Invoke(&@this->val, i);
	}
}
