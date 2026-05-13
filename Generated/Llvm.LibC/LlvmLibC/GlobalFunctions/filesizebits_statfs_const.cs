using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_12filesizebitsERK6statfs")]
[DemangledName("__llvm_libc_20_1_2_::filesizebits(statfs const&)")]
internal static partial class filesizebits_statfs_const
{
	public unsafe static long Invoke(statfs* s)
	{
		long f_type = s->f_type;
		if (f_type == 29366L || f_type == 19780L || f_type == 22092L)
		{
			return 32L;
		}
		return 64L;
	}
}
