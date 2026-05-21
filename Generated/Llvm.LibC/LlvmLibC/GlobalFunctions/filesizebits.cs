using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class filesizebits
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12filesizebitsERK6statfs")]
	[DemangledName("__llvm_libc_20_1_2_::filesizebits(statfs const&)")]
	public unsafe static long Invoke([NativeType("statfs const&")] statfs* s)
	{
		long f_type = s->f_type;
		if (f_type == 29366L || f_type == 19780L || f_type == 22092L)
		{
			return 32L;
		}
		return 64L;
	}
}
