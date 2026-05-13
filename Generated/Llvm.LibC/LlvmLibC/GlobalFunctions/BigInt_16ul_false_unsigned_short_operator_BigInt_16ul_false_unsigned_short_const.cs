using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm16ELb0EtEmiEOS1_")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<16ul, false, unsigned short>::operator-(__llvm_libc_20_1_2_::BigInt<16ul, false, unsigned short>&&) const")]
internal static partial class BigInt_16ul_false_unsigned_short_operator_BigInt_16ul_false_unsigned_short_const
{
	public unsafe static short Invoke(BigInt_ys7s55* @this, BigInt_ys7s55* other)
	{
		BigInt_ys7s55 bigInt_ys7s = default(BigInt_ys7s55);
		unchecked
		{
			*(short*)(&bigInt_ys7s) = -21846;
			llvm_memcpy_p0_p0_i64.Invoke(&bigInt_ys7s, @this, 2L, isVolatile: false);
			BigInt_16ul_false_unsigned_short_sub_overflow_BigInt_16ul_false_unsigned_short_const.Invoke(&bigInt_ys7s, other);
			return *(short*)(&bigInt_ys7s.val.Data);
		}
	}
}
