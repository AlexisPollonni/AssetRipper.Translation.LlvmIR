using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm640ELb0EmEC2Ev")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<640ul, false, unsigned long>::BigInt()")]
internal static partial class BigInt_640ul_false_unsigned_long_BigInt
{
	public unsafe static void Invoke(BigInt_m94xi3* @this)
	{
		llvm_memset_p0_i64.Invoke(&@this->val.Data, 0, 80L, isVolatile: false);
	}
}
