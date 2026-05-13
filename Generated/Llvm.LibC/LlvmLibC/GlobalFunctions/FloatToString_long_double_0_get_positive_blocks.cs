using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_13FloatToStringIeLi0EE19get_positive_blocksEv")]
[DemangledName("__llvm_libc_20_1_2_::FloatToString<long double, 0>::get_positive_blocks()")]
internal static partial class FloatToString_long_double_0_get_positive_blocks
{
	public unsafe static long Invoke(FloatToString_8m29tk* @this)
	{
		int num = 0;
		unchecked
		{
			long result;
			if (@this->exponent < -63)
			{
				result = 0L;
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(4L, &num);
				num = (int)((@this->exponent >= 0) ? ((ulong)(uint)(@this->exponent + 15L) / 16uL) : 0L);
				result = (uint)internal_length_for_num_unsigned_int_unsigned_int.Invoke((int)((long)(uint)num * 16L), 63);
				llvm_lifetime_end_p0.Invoke(4L, &num);
			}
			return result;
		}
	}
}
