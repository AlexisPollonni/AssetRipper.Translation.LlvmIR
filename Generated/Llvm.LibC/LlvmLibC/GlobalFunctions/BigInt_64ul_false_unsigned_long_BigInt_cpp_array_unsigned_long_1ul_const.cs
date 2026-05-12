using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm64ELb0EmEC2ERKNS_3cpp5arrayImLm1EEE")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long>::BigInt(__llvm_libc_20_1_2_::cpp::array<unsigned long, 1ul> const&)")]
internal static partial class BigInt_64ul_false_unsigned_long_BigInt_cpp_array_unsigned_long_1ul_const
{
	public unsafe static void Invoke(BigInt_nx6qdt* @this, cpp_array_rpgxvv* words)
	{
		llvm_memset_p0_i64.Invoke(&@this->val.Data, 0, 8L, isVolatile: false);
		llvm_memcpy_p0_p0_i64.Invoke(&@this->val, words, 8L, isVolatile: false);
	}
}
