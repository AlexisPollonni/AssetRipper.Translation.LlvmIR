using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_128ul_false_unsigned_long_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm128ELb0EmEC2ERKNS_3cpp5arrayImLm2EEE")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>::BigInt(__llvm_libc_20_1_2_::cpp::array<unsigned long, 2ul> const&)")]
	public unsafe static void Invoke([MangledName("this")] Anon_izyfb7* This, [MangledName("words")][NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned long, 2ul> const&")] Cpp_array_i3937k* Words)
	{
		unchecked
		{
			Llvm_memset_p0_i64.Invoke(&((BigInt_qdkjbh*)This)->Val.Data, 0, 16L, isVolatile: false);
			Llvm_memcpy_p0_p0_i64.Invoke(&((BigInt_qdkjbh*)This)->Val, Words, 16L, isVolatile: false);
		}
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm128ELb0EmEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>::BigInt()")]
	public unsafe static void Invoke([MangledName("this")] Anon_izyfb7* This)
	{
		Llvm_memset_p0_i64.Invoke(&unchecked((BigInt_qdkjbh*)This)->Val.Data, 0, 16L, isVolatile: false);
	}
}
