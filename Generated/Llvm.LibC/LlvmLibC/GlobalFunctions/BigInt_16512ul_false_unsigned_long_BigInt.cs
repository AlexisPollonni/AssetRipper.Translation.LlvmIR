using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm16512ELb0EmEC2Ev")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<16512ul, false, unsigned long>::BigInt()")]
internal static partial class BigInt_16512ul_false_unsigned_long_BigInt
{
	public unsafe static void Invoke(BigInt_k36xhe* @this)
	{
		llvm_memset_p0_i64.Invoke(&@this->val.Data, 0, 2064L, isVolatile: false);
	}
}
