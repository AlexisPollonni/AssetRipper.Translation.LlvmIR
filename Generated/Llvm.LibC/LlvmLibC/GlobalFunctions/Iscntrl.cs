using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Iscntrl
{
	[MangledName("iscntrl")]
	[DemangledName("iscntrl")]
	public unsafe static int Invoke([MangledName("c")] int C)
	{
		int num = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = C;
		byte result = unchecked((byte)(((uint)num >= 32u) ? ((num == 127) ? 1 : 0) : (-1)));
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
