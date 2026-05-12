using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm32ELb0EjEC2Ev")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<32ul, false, unsigned int>::BigInt()")]
internal static partial class BigInt_32ul_false_unsigned_int_BigInt
{
	public unsafe static void Invoke(BigInt_fzjdu3* @this)
	{
		llvm_memset_p0_i64.Invoke(&@this->val.Data, 0, 4L, isVolatile: false);
	}
}
