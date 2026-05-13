using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm16ELb0EtErsEm")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<16ul, false, unsigned short>::operator>>(unsigned long) const")]
[CleanName("BigInt_16ul_false_unsigned_short_operator_unsigned_long_const")]
internal static partial class BigInt_16ul_false_unsigned_short_operator_unsigned_long_const_4jf2a2
{
	public unsafe static short Invoke(BigInt_ys7s55* @this, long s)
	{
		BigInt_ys7s55 bigInt_ys7s = default(BigInt_ys7s55);
		cpp_array_knh6hw cpp_array_knh6hw2 = default(cpp_array_knh6hw);
		cpp_array_knh6hw cpp_array_knh6hw3 = default(cpp_array_knh6hw);
		llvm_lifetime_start_p0.Invoke(2L, &cpp_array_knh6hw2);
		llvm_memcpy_p0_p0_i64.Invoke(&cpp_array_knh6hw3, &@this->val, 2L, isVolatile: false);
		unchecked
		{
			short data = cpp_array_unsigned_short_1ul_multiword_shift_multiword_Direction_1_false_unsigned_short_1ul_cpp_array_unsigned_short_1ul_unsigned_long.Invoke(*(short*)(&cpp_array_knh6hw3.Data), s);
			*(short*)(&cpp_array_knh6hw2.Data) = data;
			BigInt_16ul_false_unsigned_short_BigInt_cpp_array_unsigned_short_1ul_const.Invoke(&bigInt_ys7s, &cpp_array_knh6hw2);
			llvm_lifetime_end_p0.Invoke(2L, &cpp_array_knh6hw2);
			return *(short*)(&bigInt_ys7s.val.Data);
		}
	}
}
