using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_16ul_false_unsigned_short_Subtract
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm16ELb0EtEmiEOS1_")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<16ul, false, unsigned short>::operator-(__llvm_libc_20_1_2_::BigInt<16ul, false, unsigned short>&&) const")]
	public unsafe static short Invoke([MangledName("this")] Llvm_libc_20_1_2_BigInt_ys7s55* This, [MangledName("other")][NativeType("__llvm_libc_20_1_2_::BigInt<16ul, false, unsigned short>&&")] Llvm_libc_20_1_2_BigInt_ys7s55* Other)
	{
		Llvm_libc_20_1_2_BigInt_ys7s55 llvm_libc_20_1_2_BigInt_ys7s = default(Llvm_libc_20_1_2_BigInt_ys7s55);
		unchecked
		{
			*(short*)(&llvm_libc_20_1_2_BigInt_ys7s) = -21846;
			Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_BigInt_ys7s, This, 2L, isVolatile: false);
			BigInt_16ul_false_unsigned_short_sub_overflow.Invoke(&llvm_libc_20_1_2_BigInt_ys7s, Other);
			return *(short*)(&llvm_libc_20_1_2_BigInt_ys7s.Val.Data);
		}
	}
}
