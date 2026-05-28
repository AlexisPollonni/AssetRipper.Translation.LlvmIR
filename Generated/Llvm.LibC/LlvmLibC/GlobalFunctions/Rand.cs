using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Rand
{
	[MangledName("rand")]
	[DemangledName("rand")]
	public unsafe static int Invoke()
	{
		int result = 0;
		long num = 0L;
		long num2 = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = Atomic_unsigned_long_load.Invoke(Rand_next.Pointer, MemoryOrder.RELAXED, MemoryScope.DEVICE);
		while (true)
		{
			Llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = num;
			num2 ^= num2 >>> 12;
			num2 ^= num2 << 25;
			num2 ^= num2 >>> 27;
			int num3;
			if (Atomic_unsigned_long_compare_exchange_strong.Invoke(Desired: num2, This: Rand_next.Pointer, Expected: &num, Success_order: MemoryOrder.ACQUIRE, Failure_order: MemoryOrder.RELAXED, Mem_scope: MemoryScope.DEVICE))
			{
				result = unchecked((int)(num2 * 2685821657736338717L >>> 32)) & 0x7FFFFFFF;
				num3 = 1;
			}
			else
			{
				Sleep_briefly.Invoke();
				num3 = 0;
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num2);
			switch (num3)
			{
			case 0:
				continue;
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
