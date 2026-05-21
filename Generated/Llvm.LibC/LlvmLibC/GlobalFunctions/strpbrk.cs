namespace LlvmLibC.GlobalFunctions;

internal static partial class strpbrk
{
	public unsafe static void* Invoke(void* src, void* breakset)
	{
		void* ptr = src;
		unchecked
		{
			ptr = (byte*)ptr + internal_complementary_span.Invoke(ptr, breakset);
			return (*(sbyte*)ptr == 0) ? null : ptr;
		}
	}
}
