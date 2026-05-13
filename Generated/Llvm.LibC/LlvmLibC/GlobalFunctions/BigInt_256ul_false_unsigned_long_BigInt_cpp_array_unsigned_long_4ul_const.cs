using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm256ELb0EmEC2ERKNS_3cpp5arrayImLm4EEE")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long>::BigInt(__llvm_libc_20_1_2_::cpp::array<unsigned long, 4ul> const&)")]
internal static partial class BigInt_256ul_false_unsigned_long_BigInt_cpp_array_unsigned_long_4ul_const
{
	public unsafe static void Invoke(BigInt_x9dsed* @this, cpp_array_jgy3xh* words)
	{
		llvm_memset_p0_i64.Invoke(&@this->val.Data, 0, 32L, isVolatile: false);
		llvm_memcpy_p0_p0_i64.Invoke(&@this->val, words, 32L, isVolatile: false);
	}
}
