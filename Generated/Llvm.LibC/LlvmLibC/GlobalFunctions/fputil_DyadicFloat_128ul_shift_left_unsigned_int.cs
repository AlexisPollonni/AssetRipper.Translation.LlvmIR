using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11DyadicFloatILm128EE10shift_leftEj")]
[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>::shift_left(unsigned int)")]
internal static partial class fputil_DyadicFloat_128ul_shift_left_unsigned_int
{
	public unsafe static fputil_DyadicFloat_kt2kd4* Invoke(fputil_DyadicFloat_kt2kd4* @this, int shift_length)
	{
		BigInt_qdkjbh bigInt_qdkjbh = default(BigInt_qdkjbh);
		unchecked
		{
			if ((ulong)(uint)shift_length < 128uL)
			{
				checked
				{
					@this->exponent -= shift_length;
				}
				BigInt_128ul_false_unsigned_long_operator_unsigned_long_89tuvz.Invoke((anon_izyfb7*)(&@this->mantissa), (uint)shift_length);
			}
			else
			{
				@this->exponent = 0;
				llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh);
				BigInt_128ul_false_unsigned_long_BigInt_int_void_int.Invoke((anon_izyfb7*)(&bigInt_qdkjbh), 0);
				llvm_memcpy_p0_p0_i64.Invoke(&@this->mantissa, &bigInt_qdkjbh, 16L, isVolatile: false);
				llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh);
			}
			return @this;
		}
	}
}
