using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_16ul_false_unsigned_short_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm16ELb0EtEC2ERKNS_3cpp5arrayItLm1EEE")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<16ul, false, unsigned short>::BigInt(__llvm_libc_20_1_2_::cpp::array<unsigned short, 1ul> const&)")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_BigInt_ys7s55* This, [MangledName("words")][NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned short, 1ul> const&")] Llvm_libc_20_1_2_cpp_array_knh6hw* Words)
	{
		Llvm_memset_p0_i64.Invoke(&This->Val.Data, 0, 2L, isVolatile: false);
		Llvm_memcpy_p0_p0_i64.Invoke(&This->Val, Words, 2L, isVolatile: false);
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm16ELb0EtEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<16ul, false, unsigned short>::BigInt()")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_BigInt_ys7s55* This)
	{
		Llvm_memset_p0_i64.Invoke(&This->Val.Data, 0, 2L, isVolatile: false);
	}
}
