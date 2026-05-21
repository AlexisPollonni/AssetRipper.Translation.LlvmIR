using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FloatToString_long_double_0_zero_blocks_after_point
{
	[MangledName("_ZN19__llvm_libc_20_1_2_13FloatToStringIeLi0EE23zero_blocks_after_pointEv")]
	[DemangledName("__llvm_libc_20_1_2_::FloatToString<long double, 0>::zero_blocks_after_point()")]
	public unsafe static long Invoke(FloatToString_8m29tk* @this)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		long result;
		if (@this->exponent >= -63)
		{
			result = 0L;
		}
		else
		{
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = -@this->exponent - 1;
			llvm_lifetime_start_p0.Invoke(4L, &num2);
			unchecked
			{
				num2 = (int)((ulong)(uint)(num + 15L) / 16uL);
				llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = (int)((uint)(internal_ceil_log10_pow2.Invoke((int)((long)(uint)num2 * 16L)) - internal_ceil_log10_pow2.Invoke(64)) / 9u - 1);
				result = (uint)((num3 > 0) ? num3 : 0);
				llvm_lifetime_end_p0.Invoke(4L, &num3);
				llvm_lifetime_end_p0.Invoke(4L, &num2);
				llvm_lifetime_end_p0.Invoke(4L, &num);
			}
		}
		return result;
	}
}
