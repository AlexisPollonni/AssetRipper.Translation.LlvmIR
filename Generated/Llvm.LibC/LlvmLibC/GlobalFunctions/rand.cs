using LlvmLibC.Enumerations;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class rand
{
	public unsafe static int Invoke()
	{
		int result = 0;
		long num = 0L;
		long num2 = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = Atomic_unsigned_long_load.Invoke(rand_next.Pointer, MemoryOrder.RELAXED, MemoryScope.DEVICE);
		while (true)
		{
			llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = num;
			num2 ^= num2 >>> 12;
			num2 ^= num2 << 25;
			num2 ^= num2 >>> 27;
			int num3;
			if (Atomic_unsigned_long_compare_exchange_strong.Invoke(desired: num2, @this: rand_next.Pointer, expected: &num, success_order: MemoryOrder.ACQUIRE, failure_order: MemoryOrder.RELAXED, mem_scope: MemoryScope.DEVICE))
			{
				result = unchecked((int)(num2 * 2685821657736338717L >>> 32)) & 0x7FFFFFFF;
				num3 = 1;
			}
			else
			{
				sleep_briefly.Invoke();
				num3 = 0;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			switch (num3)
			{
			case 0:
				continue;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
