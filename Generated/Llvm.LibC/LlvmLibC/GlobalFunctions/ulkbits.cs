namespace LlvmLibC.GlobalFunctions;

internal static partial class ulkbits
{
	public unsafe static long Invoke(long x)
	{
		long num = x;
		return cpp_bit_cast_unsigned_long_Accum_unsigned_long_long.Invoke(&num);
	}
}
