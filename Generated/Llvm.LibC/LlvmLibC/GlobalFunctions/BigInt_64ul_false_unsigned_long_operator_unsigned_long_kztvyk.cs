using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm64ELb0EmEixEm")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long>::operator[](unsigned long)")]
[CleanName("BigInt_64ul_false_unsigned_long_operator_unsigned_long")]
internal static partial class BigInt_64ul_false_unsigned_long_operator_unsigned_long_kztvyk
{
	public unsafe static void* Invoke(BigInt_nx6qdt* @this, long i)
	{
		return cpp_array_unsigned_long_1ul_operator_unsigned_long.Invoke(&@this->val, i);
	}
}
