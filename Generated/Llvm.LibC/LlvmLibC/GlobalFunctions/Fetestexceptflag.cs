using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fetestexceptflag
{
	[MangledName("fetestexceptflag")]
	[DemangledName("fetestexceptflag")]
	public unsafe static int Invoke([MangledName("flagp")] void* Flagp, [MangledName("excepts")] int Excepts)
	{
		return unchecked((ushort)(*(short*)Flagp)) | Fputil_test_except.Invoke(Excepts);
	}
}
