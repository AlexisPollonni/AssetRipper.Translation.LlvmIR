using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.GlobalVariables;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Srand
{
	[MangledName("srand")]
	[DemangledName("srand")]
	public unsafe static void Invoke([MangledName("seed")] int Seed)
	{
		Atomic_unsigned_long_store.Invoke(Rand_next.Pointer, unchecked((uint)Seed), MemoryOrder.RELAXED, MemoryScope.DEVICE);
	}
}
