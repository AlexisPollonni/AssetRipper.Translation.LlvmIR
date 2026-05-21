using LlvmLibC.Enumerations;
using LlvmLibC.GlobalVariables;

namespace LlvmLibC.GlobalFunctions;

internal static partial class srand
{
	public unsafe static void Invoke(int seed)
	{
		Atomic_unsigned_long_store.Invoke(rand_next.Pointer, unchecked((uint)seed), MemoryOrder.RELAXED, MemoryScope.DEVICE);
	}
}
