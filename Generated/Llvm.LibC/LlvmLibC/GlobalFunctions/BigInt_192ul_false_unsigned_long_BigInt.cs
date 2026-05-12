using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm192ELb0EmEC2Ev")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<192ul, false, unsigned long>::BigInt()")]
internal static partial class BigInt_192ul_false_unsigned_long_BigInt
{
	public unsafe static void Invoke(BigInt_ghrwnp* @this)
	{
		llvm_memset_p0_i64.Invoke(&@this->val.Data, 0, 24L, isVolatile: false);
	}
}
