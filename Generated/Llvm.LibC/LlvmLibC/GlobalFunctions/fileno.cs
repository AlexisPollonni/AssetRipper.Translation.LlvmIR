namespace LlvmLibC.GlobalFunctions;

internal static partial class fileno
{
	public unsafe static int Invoke(void* stream)
	{
		return Get_fileno_File.Invoke(stream);
	}
}
