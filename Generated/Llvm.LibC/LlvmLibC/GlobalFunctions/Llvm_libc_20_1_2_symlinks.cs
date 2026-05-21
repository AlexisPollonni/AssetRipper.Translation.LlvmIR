using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llvm_libc_20_1_2_symlinks
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8symlinksERK6statfs")]
	[DemangledName("__llvm_libc_20_1_2_::symlinks(statfs const&)")]
	public unsafe static long Invoke([MangledName("s")][NativeType("statfs const&")] Statfs* S)
	{
		long f_type = S->F_type;
		if (f_type == 44533L || f_type == 464386766L || f_type == 684539205L || f_type == 4278867L || f_type == 19780L || f_type == 47L)
		{
			return 0L;
		}
		return 1L;
	}
}
