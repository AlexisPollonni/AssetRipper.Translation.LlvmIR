namespace LlvmLibC.GlobalFunctions;

internal static partial class lkbits
{
	public unsafe static long Invoke(long x)
	{
		long num = x;
		return cpp_bit_cast_long_Accum_long_long.Invoke(&num);
	}
}
