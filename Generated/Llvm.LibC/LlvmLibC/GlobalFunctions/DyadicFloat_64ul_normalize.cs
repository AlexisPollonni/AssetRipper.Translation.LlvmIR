using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class DyadicFloat_64ul_normalize
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11DyadicFloatILm64EE9normalizeEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat<64ul>::normalize()")]
	public unsafe static fputil_DyadicFloat_syracv* Invoke(fputil_DyadicFloat_syracv* @this)
	{
		int num = 0;
		if (!BigInt_64ul_false_unsigned_long_is_zero.Invoke(&@this->mantissa))
		{
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = cpp_countl_zero_BigInt_64ul_false_unsigned_long.Invoke(&@this->mantissa);
			@this->exponent -= num;
			BigInt_64ul_false_unsigned_long_Operator_pq2pm2.Invoke(&@this->mantissa, num);
			llvm_lifetime_end_p0.Invoke(4L, &num);
		}
		return @this;
	}
}
