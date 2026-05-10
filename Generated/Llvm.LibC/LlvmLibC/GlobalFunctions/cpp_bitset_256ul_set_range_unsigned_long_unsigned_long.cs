using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp6bitsetILm256EE9set_rangeEmm")]
[DemangledName("__llvm_libc_20_1_2_::cpp::bitset<256ul>::set_range(unsigned long, unsigned long)")]
internal static partial class cpp_bitset_256ul_set_range_unsigned_long_unsigned_long
{
	public unsafe static void Invoke(void* @this, long Start, long End)
	{
		long num = 0L;
		long num2 = 0L;
		long num3 = 0L;
		long num4 = 0L;
		long num5 = 0L;
		long num6 = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		unchecked
		{
			num = (long)((ulong)Start / 64uL);
			llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = (long)((ulong)End / 64uL);
			if (num == num2)
			{
				llvm_lifetime_start_p0.Invoke(8L, &num3);
				num3 = (1L << (int)(End - Start) << 1) - 1L << (int)(Start - num * 64L);
				((long*)(&((cpp_array_jgy3xh*)@this)->Data))[num] |= num3;
				llvm_lifetime_end_p0.Invoke(8L, &num3);
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(8L, &num4);
				num4 = ((1L << (int)(Start - num * 64L)) - 1L) ^ -1L;
				((long*)(&((cpp_array_jgy3xh*)@this)->Data))[num] |= num4;
				llvm_lifetime_start_p0.Invoke(8L, &num5);
				for (num5 = num + 1L; (ulong)num5 < (ulong)num2; num5++)
				{
					((long*)(&((cpp_array_jgy3xh*)@this)->Data))[num5] = -1L;
				}
				llvm_lifetime_end_p0.Invoke(8L, &num5);
				llvm_lifetime_start_p0.Invoke(8L, &num6);
				num6 = (1L << (int)(End - num2 * 64L) << 1) - 1L;
				((long*)(&((cpp_array_jgy3xh*)@this)->Data))[num2] |= num6;
				llvm_lifetime_end_p0.Invoke(8L, &num6);
				llvm_lifetime_end_p0.Invoke(8L, &num4);
			}
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			llvm_lifetime_end_p0.Invoke(8L, &num);
		}
	}
}
