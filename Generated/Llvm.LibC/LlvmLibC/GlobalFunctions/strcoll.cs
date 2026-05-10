namespace LlvmLibC.GlobalFunctions;

internal static partial class strcoll
{
	public unsafe static int Invoke(void* left, void* right)
	{
		void* ptr = left;
		void* ptr2 = right;
		unchecked
		{
			while (*(bool*)ptr && *(sbyte*)ptr == *(sbyte*)ptr2)
			{
				ptr = (byte*)ptr + 1;
				ptr2 = (byte*)ptr2 + 1;
			}
		}
		return *unchecked((sbyte*)ptr) - *unchecked((sbyte*)ptr2);
	}
}
