using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_16512ul_false_unsigned_long_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm16512ELb0EmEC2ERKNS_3cpp5arrayImLm258EEE")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<16512ul, false, unsigned long>::BigInt(__llvm_libc_20_1_2_::cpp::array<unsigned long, 258ul> const&)")]
	public unsafe static void Invoke(BigInt_q8g275* @this, [NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned long, 258ul> const&")] cpp_array_anzbtp* words)
	{
		llvm_memset_p0_i64.Invoke(&@this->val.Data, 0, 2064L, isVolatile: false);
		llvm_memcpy_p0_p0_i64.Invoke(&@this->val, words, 2064L, isVolatile: false);
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm16512ELb0EmEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<16512ul, false, unsigned long>::BigInt()")]
	public unsafe static void Invoke(BigInt_q8g275* @this)
	{
		llvm_memset_p0_i64.Invoke(&@this->val.Data, 0, 2064L, isVolatile: false);
	}
}
