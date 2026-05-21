using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_32ul_false_unsigned_int_Subtract
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm32ELb0EjEmiEOS1_")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<32ul, false, unsigned int>::operator-(__llvm_libc_20_1_2_::BigInt<32ul, false, unsigned int>&&) const")]
	public unsafe static int Invoke([MangledName("this")] Llvm_libc_20_1_2_BigInt_vtm4cw* This, [MangledName("other")][NativeType("__llvm_libc_20_1_2_::BigInt<32ul, false, unsigned int>&&")] Llvm_libc_20_1_2_BigInt_vtm4cw* Other)
	{
		Llvm_libc_20_1_2_BigInt_vtm4cw llvm_libc_20_1_2_BigInt_vtm4cw = default(Llvm_libc_20_1_2_BigInt_vtm4cw);
		unchecked
		{
			*(int*)(&llvm_libc_20_1_2_BigInt_vtm4cw) = -1431655766;
			Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_BigInt_vtm4cw, This, 4L, isVolatile: false);
			BigInt_32ul_false_unsigned_int_sub_overflow.Invoke(&llvm_libc_20_1_2_BigInt_vtm4cw, Other);
			return *(int*)(&llvm_libc_20_1_2_BigInt_vtm4cw.Val.Data);
		}
	}
}
