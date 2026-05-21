using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_256ul_false_unsigned_long_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm256ELb0EmEC2ERKNS_3cpp5arrayImLm4EEE")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long>::BigInt(__llvm_libc_20_1_2_::cpp::array<unsigned long, 4ul> const&)")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_BigInt_x9dsed* This, [MangledName("words")][NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned long, 4ul> const&")] Llvm_libc_20_1_2_cpp_array_jgy3xh* Words)
	{
		Llvm_memset_p0_i64.Invoke(&This->Val.Data, 0, 32L, isVolatile: false);
		Llvm_memcpy_p0_p0_i64.Invoke(&This->Val, Words, 32L, isVolatile: false);
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm256ELb0EmEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long>::BigInt()")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_BigInt_x9dsed* This)
	{
		Llvm_memset_p0_i64.Invoke(&This->Val.Data, 0, 32L, isVolatile: false);
	}
}
