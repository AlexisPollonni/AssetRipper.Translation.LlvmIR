using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm128ELb0EmEixEm")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>::operator[](unsigned long)")]
[CleanName("BigInt_128ul_false_unsigned_long_operator_unsigned_long")]
internal static partial class BigInt_128ul_false_unsigned_long_operator_unsigned_long_3b99zc
{
	public unsafe static void* Invoke(anon_izyfb7* @this, long i)
	{
		return cpp_array_unsigned_long_2ul_operator_unsigned_long.Invoke(&unchecked((BigInt_qdkjbh*)@this)->val, i);
	}
}
