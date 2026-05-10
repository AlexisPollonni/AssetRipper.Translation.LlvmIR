using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11DyadicFloatILm256EE10shift_leftEj")]
[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat<256ul>::shift_left(unsigned int)")]
internal static partial class fputil_DyadicFloat_256ul_shift_left_unsigned_int
{
	public unsafe static void* Invoke(void* @this, int shift_length)
	{
		BigInt_x9dsed bigInt_x9dsed = default(BigInt_x9dsed);
		unchecked
		{
			if ((ulong)(uint)shift_length < 256uL)
			{
				checked
				{
					unchecked((fputil_DyadicFloat_jhcpjj*)@this)->exponent -= shift_length;
				}
				BigInt_256ul_false_unsigned_long_operator_unsigned_long_d84zyi.Invoke(&((fputil_DyadicFloat_jhcpjj*)@this)->mantissa, (uint)shift_length);
			}
			else
			{
				((fputil_DyadicFloat_jhcpjj*)@this)->exponent = 0;
				llvm_lifetime_start_p0.Invoke(32L, &bigInt_x9dsed);
				BigInt_256ul_false_unsigned_long_BigInt_int_void_int.Invoke(&bigInt_x9dsed, 0);
				llvm_memcpy_p0_p0_i64.Invoke(&((fputil_DyadicFloat_jhcpjj*)@this)->mantissa, &bigInt_x9dsed, 32L, isVolatile: false);
				llvm_lifetime_end_p0.Invoke(32L, &bigInt_x9dsed);
			}
			return @this;
		}
	}
}
