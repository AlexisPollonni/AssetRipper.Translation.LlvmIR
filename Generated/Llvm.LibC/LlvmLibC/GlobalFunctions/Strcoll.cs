using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Strcoll
{
	[MangledName("strcoll")]
	[DemangledName("strcoll")]
	public unsafe static int Invoke([MangledName("left")] void* Left, [MangledName("right")] void* Right)
	{
		void* ptr = Left;
		void* ptr2 = Right;
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
