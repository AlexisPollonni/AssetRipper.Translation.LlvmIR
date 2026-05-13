using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm16512ELb0EmEC2ERKNS_3cpp5arrayImLm258EEE")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<16512ul, false, unsigned long>::BigInt(__llvm_libc_20_1_2_::cpp::array<unsigned long, 258ul> const&)")]
internal static partial class BigInt_16512ul_false_unsigned_long_BigInt_cpp_array_unsigned_long_258ul_const
{
	public unsafe static void Invoke(BigInt_k36xhe* @this, cpp_array_vnnqx8* words)
	{
		llvm_memset_p0_i64.Invoke(&@this->val.Data, 0, 2064L, isVolatile: false);
		llvm_memcpy_p0_p0_i64.Invoke(&@this->val, words, 2064L, isVolatile: false);
	}
}
