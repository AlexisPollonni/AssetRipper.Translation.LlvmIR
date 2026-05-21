using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_16ul_false_unsigned_short_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm16ELb0EtEC2ERKNS_3cpp5arrayItLm1EEE")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<16ul, false, unsigned short>::BigInt(__llvm_libc_20_1_2_::cpp::array<unsigned short, 1ul> const&)")]
	public unsafe static void Invoke(BigInt_ys7s55* @this, [NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned short, 1ul> const&")] cpp_array_knh6hw* words)
	{
		llvm_memset_p0_i64.Invoke(&@this->val.Data, 0, 2L, isVolatile: false);
		llvm_memcpy_p0_p0_i64.Invoke(&@this->val, words, 2L, isVolatile: false);
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm16ELb0EtEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<16ul, false, unsigned short>::BigInt()")]
	public unsafe static void Invoke(BigInt_ys7s55* @this)
	{
		llvm_memset_p0_i64.Invoke(&@this->val.Data, 0, 2L, isVolatile: false);
	}
}
