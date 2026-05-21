using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class DyadicFloat_32ul_normalize
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11DyadicFloatILm32EE9normalizeEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat<32ul>::normalize()")]
	public unsafe static void* Invoke(void* @this)
	{
		int num = 0;
		unchecked
		{
			if (!BigInt_32ul_false_unsigned_int_is_zero.Invoke(&((fputil_DyadicFloat_cs3nhs*)@this)->mantissa))
			{
				llvm_lifetime_start_p0.Invoke(4L, &num);
				num = cpp_countl_zero_BigInt_32ul_false_unsigned_int.Invoke(&((fputil_DyadicFloat_cs3nhs*)@this)->mantissa);
				checked
				{
					unchecked((fputil_DyadicFloat_cs3nhs*)@this)->exponent -= num;
				}
				BigInt_32ul_false_unsigned_int_Operator.Invoke(&((fputil_DyadicFloat_cs3nhs*)@this)->mantissa, num);
				llvm_lifetime_end_p0.Invoke(4L, &num);
			}
			return @this;
		}
	}
}
