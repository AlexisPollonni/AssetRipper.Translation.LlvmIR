using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm64ELb0EmE12add_overflowERKS1_")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long>::add_overflow(__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long> const&)")]
internal static partial class BigInt_64ul_false_unsigned_long_add_overflow_BigInt_64ul_false_unsigned_long_const
{
	public unsafe static long Invoke(BigInt_nx6qdt* @this, BigInt_nx6qdt* rhs)
	{
		return unsigned_long_multiword_add_with_carry_unsigned_long_1ul_1ul_cpp_array_unsigned_long_1ul_cpp_array_unsigned_long_1ul_const.Invoke(&@this->val, &rhs->val);
	}
}
