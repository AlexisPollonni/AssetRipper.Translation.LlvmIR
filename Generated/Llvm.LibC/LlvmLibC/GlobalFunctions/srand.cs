using LlvmLibC.Enumerations;
using LlvmLibC.GlobalVariables;

namespace LlvmLibC.GlobalFunctions;

internal static partial class srand
{
	public unsafe static void Invoke(int seed)
	{
		cpp_Atomic_unsigned_long_store_unsigned_long_cpp_MemoryOrder_cpp_MemoryScope.Invoke(rand_next.Pointer, unchecked((uint)seed), MemoryOrder.RELAXED, MemoryScope.DEVICE);
	}
}
