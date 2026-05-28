using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_32ul_false_unsigned_int_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm32ELb0EjEC2ERKNS_3cpp5arrayIjLm1EEE")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<32ul, false, unsigned int>::BigInt(__llvm_libc_20_1_2_::cpp::array<unsigned int, 1ul> const&)")]
	public unsafe static void Invoke([MangledName("this")] BigInt_vtm4cw* This, [MangledName("words")][NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned int, 1ul> const&")] Cpp_array_2v7m9i* Words)
	{
		Llvm_memset_p0_i64.Invoke(&This->Val.Data, 0, 4L, isVolatile: false);
		Llvm_memcpy_p0_p0_i64.Invoke(&This->Val, Words, 4L, isVolatile: false);
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm32ELb0EjEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<32ul, false, unsigned int>::BigInt()")]
	public unsafe static void Invoke([MangledName("this")] BigInt_vtm4cw* This)
	{
		Llvm_memset_p0_i64.Invoke(&This->Val.Data, 0, 4L, isVolatile: false);
	}
}
