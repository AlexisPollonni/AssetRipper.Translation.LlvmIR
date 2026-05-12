using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11DyadicFloatILm64EE10shift_leftEj")]
[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat<64ul>::shift_left(unsigned int)")]
internal static partial class fputil_DyadicFloat_64ul_shift_left_unsigned_int
{
	public unsafe static fputil_DyadicFloat_374hpp* Invoke(fputil_DyadicFloat_374hpp* @this, int shift_length)
	{
		BigInt_nx6qdt bigInt_nx6qdt = default(BigInt_nx6qdt);
		if (unchecked((ulong)(uint)shift_length) < 64uL)
		{
			@this->exponent -= shift_length;
			BigInt_64ul_false_unsigned_long_operator_unsigned_long_pq2pm2.Invoke(&@this->mantissa, unchecked((uint)shift_length));
		}
		else
		{
			@this->exponent = 0;
			llvm_lifetime_start_p0.Invoke(8L, &bigInt_nx6qdt);
			BigInt_64ul_false_unsigned_long_BigInt_int_void_int.Invoke(&bigInt_nx6qdt, 0);
			llvm_memcpy_p0_p0_i64.Invoke(&@this->mantissa, &bigInt_nx6qdt, 8L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(8L, &bigInt_nx6qdt);
		}
		return @this;
	}
}
