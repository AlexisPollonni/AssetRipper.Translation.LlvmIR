namespace LlvmLibC.GlobalFunctions;

internal static partial class strcspn
{
	public unsafe static long Invoke(void* src, void* segment)
	{
		return internal_complementary_span_char_const_char_const.Invoke(src, segment);
	}
}
