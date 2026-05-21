using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class DyadicFloat_128ul_normalize
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11DyadicFloatILm128EE9normalizeEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>::normalize()")]
	public unsafe static fputil_DyadicFloat_kt2kd4* Invoke(fputil_DyadicFloat_kt2kd4* @this)
	{
		int num = 0;
		unchecked
		{
			if (!BigInt_128ul_false_unsigned_long_is_zero.Invoke((anon_izyfb7*)(&@this->mantissa)))
			{
				llvm_lifetime_start_p0.Invoke(4L, &num);
				num = cpp_countl_zero_BigInt_128ul_false_unsigned_long.Invoke((anon_izyfb7*)(&@this->mantissa));
				checked
				{
					@this->exponent -= num;
				}
				BigInt_128ul_false_unsigned_long_Operator_89tuvz.Invoke((anon_izyfb7*)(&@this->mantissa), num);
				llvm_lifetime_end_p0.Invoke(4L, &num);
			}
			return @this;
		}
	}
}
