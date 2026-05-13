using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm32ELb0EjEC2ERKNS_3cpp5arrayIjLm1EEE")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<32ul, false, unsigned int>::BigInt(__llvm_libc_20_1_2_::cpp::array<unsigned int, 1ul> const&)")]
internal static partial class BigInt_32ul_false_unsigned_int_BigInt_cpp_array_unsigned_int_1ul_const
{
	public unsafe static void Invoke(BigInt_fzjdu3* @this, cpp_array_aj48id* words)
	{
		llvm_memset_p0_i64.Invoke(&@this->val.Data, 0, 4L, isVolatile: false);
		llvm_memcpy_p0_p0_i64.Invoke(&@this->val, words, 4L, isVolatile: false);
	}
}
