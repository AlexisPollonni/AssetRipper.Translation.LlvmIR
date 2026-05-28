using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_32ul_false_unsigned_int_Operator
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm32ELb0EjElSEm")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<32ul, false, unsigned int>::operator<<=(unsigned long)")]
	public unsafe static BigInt_vtm4cw* Invoke([MangledName("this")] BigInt_vtm4cw* This, [MangledName("s")][NativeType("unsigned long")] long S)
	{
		Cpp_array_2v7m9i cpp_array_2v7m9i = default(Cpp_array_2v7m9i);
		Cpp_array_2v7m9i cpp_array_2v7m9i2 = default(Cpp_array_2v7m9i);
		Llvm_lifetime_start_p0.Invoke(4L, &cpp_array_2v7m9i);
		Llvm_memcpy_p0_p0_i64.Invoke(&cpp_array_2v7m9i2, &This->Val, 4L, isVolatile: false);
		unchecked
		{
			int data = Multiword_shift_multiword_Direction_0_false_unsigned_int_1ul.Invoke(*(int*)(&cpp_array_2v7m9i2.Data), S);
			*(int*)(&cpp_array_2v7m9i.Data) = data;
			Llvm_memcpy_p0_p0_i64.Invoke(&This->Val, &cpp_array_2v7m9i, 4L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(4L, &cpp_array_2v7m9i);
			return This;
		}
	}
}
