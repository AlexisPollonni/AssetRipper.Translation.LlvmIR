using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_64ul_false_unsigned_long_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm64ELb0EmEC2ERKNS_3cpp5arrayImLm1EEE")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long>::BigInt(__llvm_libc_20_1_2_::cpp::array<unsigned long, 1ul> const&)")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_BigInt_555ggs* This, [MangledName("words")][NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned long, 1ul> const&")] Llvm_libc_20_1_2_cpp_array_rpgxvv* Words)
	{
		Llvm_memset_p0_i64.Invoke(&This->Val.Data, 0, 8L, isVolatile: false);
		Llvm_memcpy_p0_p0_i64.Invoke(&This->Val, Words, 8L, isVolatile: false);
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm64ELb0EmEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long>::BigInt()")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_BigInt_555ggs* This)
	{
		Llvm_memset_p0_i64.Invoke(&This->Val.Data, 0, 8L, isVolatile: false);
	}
}
