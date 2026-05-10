using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_13FloatToStringIdLi0EE19get_positive_blocksEv")]
[DemangledName("__llvm_libc_20_1_2_::FloatToString<double, 0>::get_positive_blocks()")]
internal static partial class FloatToString_double_0_get_positive_blocks
{
	public unsafe static long Invoke(void* @this)
	{
		int num = 0;
		unchecked
		{
			long result;
			if (((FloatToString_dhsqbm*)@this)->field_1 < -52)
			{
				result = 0L;
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(4L, &num);
				num = (int)((((FloatToString_dhsqbm*)@this)->field_1 >= 0) ? ((ulong)(uint)(((FloatToString_dhsqbm*)@this)->field_1 + 15L) / 16uL) : 0L);
				result = (uint)internal_length_for_num_unsigned_int_unsigned_int.Invoke((int)((long)(uint)num * 16L), 52);
				llvm_lifetime_end_p0.Invoke(4L, &num);
			}
			return result;
		}
	}
}
