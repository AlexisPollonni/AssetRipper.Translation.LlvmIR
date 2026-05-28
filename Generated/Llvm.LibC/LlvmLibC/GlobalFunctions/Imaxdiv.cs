using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Imaxdiv
{
	[MangledName("imaxdiv")]
	[DemangledName("imaxdiv")]
	public unsafe static Struct_fiz2nb Invoke([MangledName("x")] long X, [MangledName("y")] long Y)
	{
		AuxEntry auxEntry = default(AuxEntry);
		unchecked
		{
			*(long*)(&auxEntry) = -6148914691236517206L;
			((long*)(&auxEntry))[1] = -6148914691236517206L;
			Integer_rem_quo_long_g6nshs.Invoke(X, Y, &auxEntry.Tv_sec, &auxEntry.Tv_nsec);
			return *(Struct_fiz2nb*)(&auxEntry);
		}
	}
}
