using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class imaxdiv
{
	public unsafe static Struct_fiz2nb Invoke(long x, long y)
	{
		AuxEntry auxEntry = default(AuxEntry);
		unchecked
		{
			*(long*)(&auxEntry) = -6148914691236517206L;
			((long*)(&auxEntry))[1] = -6148914691236517206L;
			integer_rem_quo_long_g6nshs.Invoke(x, y, &auxEntry.tv_sec, &auxEntry.tv_nsec);
			return *(Struct_fiz2nb*)(&auxEntry);
		}
	}
}
