using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_32ul_false_unsigned_int_RightShift
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm32ELb0EjErsEm")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<32ul, false, unsigned int>::operator>>(unsigned long) const")]
	public unsafe static int Invoke([MangledName("this")] Llvm_libc_20_1_2_BigInt_vtm4cw* This, [MangledName("s")][NativeType("unsigned long")] long S)
	{
		Llvm_libc_20_1_2_BigInt_vtm4cw llvm_libc_20_1_2_BigInt_vtm4cw = default(Llvm_libc_20_1_2_BigInt_vtm4cw);
		Llvm_libc_20_1_2_cpp_array_2v7m9i llvm_libc_20_1_2_cpp_array_2v7m9i = default(Llvm_libc_20_1_2_cpp_array_2v7m9i);
		Llvm_libc_20_1_2_cpp_array_2v7m9i llvm_libc_20_1_2_cpp_array_2v7m9i2 = default(Llvm_libc_20_1_2_cpp_array_2v7m9i);
		Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_cpp_array_2v7m9i);
		Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_cpp_array_2v7m9i2, &This->Val, 4L, isVolatile: false);
		unchecked
		{
			int data = Multiword_shift_multiword_Direction_1_false_unsigned_int_1ul.Invoke(*(int*)(&llvm_libc_20_1_2_cpp_array_2v7m9i2.Data), S);
			*(int*)(&llvm_libc_20_1_2_cpp_array_2v7m9i.Data) = data;
			BigInt_32ul_false_unsigned_int_Constructor.Invoke(&llvm_libc_20_1_2_BigInt_vtm4cw, &llvm_libc_20_1_2_cpp_array_2v7m9i);
			Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_cpp_array_2v7m9i);
			return *(int*)(&llvm_libc_20_1_2_BigInt_vtm4cw.Val.Data);
		}
	}
}
