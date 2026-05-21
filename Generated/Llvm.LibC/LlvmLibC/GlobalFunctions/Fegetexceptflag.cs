using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fegetexceptflag
{
	[MangledName("fegetexceptflag")]
	[DemangledName("fegetexceptflag")]
	public unsafe static int Invoke([MangledName("flagp")] void* Flagp, [MangledName("excepts")] int Excepts)
	{
		unchecked
		{
			*(short*)Flagp = (short)(Fputil_test_except.Invoke(61) & Excepts);
			return 0;
		}
	}
}
