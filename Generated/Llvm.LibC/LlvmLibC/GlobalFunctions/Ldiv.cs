using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Ldiv
{
	[MangledName("ldiv")]
	[DemangledName("ldiv")]
	public unsafe static Struct_fiz2nb Invoke([MangledName("x")] long X, [MangledName("y")] long Y)
	{
		AuxEntry auxEntry = default(AuxEntry);
		unchecked
		{
			*(long*)(&auxEntry) = -6148914691236517206L;
			((long*)(&auxEntry))[1] = -6148914691236517206L;
			Integer_rem_quo_long_69v27w.Invoke(X, Y, &auxEntry.Tv_sec, &auxEntry.Tv_nsec);
			return *(Struct_fiz2nb*)(&auxEntry);
		}
	}
}
