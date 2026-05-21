using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_32ul_false_unsigned_int_Subtract
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm32ELb0EjEmiEOS1_")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<32ul, false, unsigned int>::operator-(__llvm_libc_20_1_2_::BigInt<32ul, false, unsigned int>&&) const")]
	public unsafe static int Invoke(BigInt_vtm4cw* @this, [NativeType("__llvm_libc_20_1_2_::BigInt<32ul, false, unsigned int>&&")] BigInt_vtm4cw* other)
	{
		BigInt_vtm4cw bigInt_vtm4cw = default(BigInt_vtm4cw);
		unchecked
		{
			*(int*)(&bigInt_vtm4cw) = -1431655766;
			llvm_memcpy_p0_p0_i64.Invoke(&bigInt_vtm4cw, @this, 4L, isVolatile: false);
			BigInt_32ul_false_unsigned_int_sub_overflow.Invoke(&bigInt_vtm4cw, other);
			return *(int*)(&bigInt_vtm4cw.val.Data);
		}
	}
}
