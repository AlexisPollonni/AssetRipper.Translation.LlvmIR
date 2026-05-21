using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FloatToString_long_double_0_zero_blocks_after_point
{
	[MangledName("_ZN19__llvm_libc_20_1_2_13FloatToStringIeLi0EE23zero_blocks_after_pointEv")]
	[DemangledName("__llvm_libc_20_1_2_::FloatToString<long double, 0>::zero_blocks_after_point()")]
	public unsafe static long Invoke([MangledName("this")] Llvm_libc_20_1_2_FloatToString_8m29tk* This)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		long result;
		if (This->Exponent >= -63)
		{
			result = 0L;
		}
		else
		{
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = -This->Exponent - 1;
			Llvm_lifetime_start_p0.Invoke(4L, &num2);
			unchecked
			{
				num2 = (int)((ulong)(uint)(num + 15L) / 16uL);
				Llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = (int)((uint)(Internal_ceil_log10_pow2.Invoke((int)((long)(uint)num2 * 16L)) - Internal_ceil_log10_pow2.Invoke(64)) / 9u - 1);
				result = (uint)((num3 > 0) ? num3 : 0);
				Llvm_lifetime_end_p0.Invoke(4L, &num3);
				Llvm_lifetime_end_p0.Invoke(4L, &num2);
				Llvm_lifetime_end_p0.Invoke(4L, &num);
			}
		}
		return result;
	}
}
