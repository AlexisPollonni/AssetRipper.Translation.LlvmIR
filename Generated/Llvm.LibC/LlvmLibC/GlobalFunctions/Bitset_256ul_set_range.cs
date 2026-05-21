using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Bitset_256ul_set_range
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp6bitsetILm256EE9set_rangeEmm")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::bitset<256ul>::set_range(unsigned long, unsigned long)")]
	public unsafe static void Invoke([MangledName("this")] void* This, [NativeType("unsigned long")] long Start, [NativeType("unsigned long")] long End)
	{
		long num = 0L;
		long num2 = 0L;
		long num3 = 0L;
		long num4 = 0L;
		long num5 = 0L;
		long num6 = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		unchecked
		{
			num = (long)((ulong)Start / 64uL);
			Llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = (long)((ulong)End / 64uL);
			if (num == num2)
			{
				Llvm_lifetime_start_p0.Invoke(8L, &num3);
				num3 = (1L << (int)(End - Start) << 1) - 1L << (int)(Start - num * 64L);
				((long*)(&((Llvm_libc_20_1_2_cpp_array_jgy3xh*)This)->Data))[num] |= num3;
				Llvm_lifetime_end_p0.Invoke(8L, &num3);
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(8L, &num4);
				num4 = ((1L << (int)(Start - num * 64L)) - 1L) ^ -1L;
				((long*)(&((Llvm_libc_20_1_2_cpp_array_jgy3xh*)This)->Data))[num] |= num4;
				Llvm_lifetime_start_p0.Invoke(8L, &num5);
				for (num5 = num + 1L; (ulong)num5 < (ulong)num2; num5++)
				{
					((long*)(&((Llvm_libc_20_1_2_cpp_array_jgy3xh*)This)->Data))[num5] = -1L;
				}
				Llvm_lifetime_end_p0.Invoke(8L, &num5);
				Llvm_lifetime_start_p0.Invoke(8L, &num6);
				num6 = (1L << (int)(End - num2 * 64L) << 1) - 1L;
				((long*)(&((Llvm_libc_20_1_2_cpp_array_jgy3xh*)This)->Data))[num2] |= num6;
				Llvm_lifetime_end_p0.Invoke(8L, &num6);
				Llvm_lifetime_end_p0.Invoke(8L, &num4);
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num2);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
		}
	}
}
