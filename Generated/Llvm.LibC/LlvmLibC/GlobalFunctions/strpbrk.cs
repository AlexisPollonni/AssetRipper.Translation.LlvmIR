namespace LlvmLibC.GlobalFunctions;

internal static partial class strpbrk
{
	public unsafe static void* Invoke(void* src, void* breakset)
	{
		void* ptr = src;
		unchecked
		{
			ptr = (byte*)ptr + internal_complementary_span_char_const_char_const.Invoke(ptr, breakset);
			return (*(sbyte*)ptr == 0) ? null : ptr;
		}
	}
}
