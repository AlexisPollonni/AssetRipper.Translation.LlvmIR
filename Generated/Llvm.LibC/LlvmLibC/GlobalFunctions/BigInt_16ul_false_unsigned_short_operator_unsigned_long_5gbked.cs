using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm16ELb0EtElSEm")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<16ul, false, unsigned short>::operator<<=(unsigned long)")]
[CleanName("BigInt_16ul_false_unsigned_short_operator_unsigned_long")]
internal static partial class BigInt_16ul_false_unsigned_short_operator_unsigned_long_5gbked
{
	public unsafe static BigInt_ys7s55* Invoke(BigInt_ys7s55* @this, long s)
	{
		cpp_array_knh6hw cpp_array_knh6hw2 = default(cpp_array_knh6hw);
		cpp_array_knh6hw cpp_array_knh6hw3 = default(cpp_array_knh6hw);
		llvm_lifetime_start_p0.Invoke(2L, &cpp_array_knh6hw2);
		llvm_memcpy_p0_p0_i64.Invoke(&cpp_array_knh6hw3, &@this->val, 2L, isVolatile: false);
		unchecked
		{
			short data = cpp_array_unsigned_short_1ul_multiword_shift_multiword_Direction_0_false_unsigned_short_1ul_cpp_array_unsigned_short_1ul_unsigned_long.Invoke(*(short*)(&cpp_array_knh6hw3.Data), s);
			*(short*)(&cpp_array_knh6hw2.Data) = data;
			llvm_memcpy_p0_p0_i64.Invoke(&@this->val, &cpp_array_knh6hw2, 2L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(2L, &cpp_array_knh6hw2);
			return @this;
		}
	}
}
