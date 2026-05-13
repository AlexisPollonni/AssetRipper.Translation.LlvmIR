using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm16ELb0EtEC2Ev")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<16ul, false, unsigned short>::BigInt()")]
internal static partial class BigInt_16ul_false_unsigned_short_BigInt
{
	public unsafe static void Invoke(BigInt_ys7s55* @this)
	{
		llvm_memset_p0_i64.Invoke(&@this->val.Data, 0, 2L, isVolatile: false);
	}
}
