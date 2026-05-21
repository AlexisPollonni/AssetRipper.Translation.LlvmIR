using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class DyadicFloat_256ul_shift_left
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11DyadicFloatILm256EE10shift_leftEj")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat<256ul>::shift_left(unsigned int)")]
	public unsafe static fputil_DyadicFloat_jhcpjj* Invoke(fputil_DyadicFloat_jhcpjj* @this, [NativeType("unsigned int")] int shift_length)
	{
		BigInt_x9dsed bigInt_x9dsed = default(BigInt_x9dsed);
		if (unchecked((ulong)(uint)shift_length) < 256uL)
		{
			@this->exponent -= shift_length;
			BigInt_256ul_false_unsigned_long_Operator_d84zyi.Invoke(&@this->mantissa, unchecked((uint)shift_length));
		}
		else
		{
			@this->exponent = 0;
			llvm_lifetime_start_p0.Invoke(32L, &bigInt_x9dsed);
			BigInt_256ul_false_unsigned_long_BigInt_int_void.Invoke(&bigInt_x9dsed, 0);
			llvm_memcpy_p0_p0_i64.Invoke(&@this->mantissa, &bigInt_x9dsed, 32L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(32L, &bigInt_x9dsed);
		}
		return @this;
	}
}
