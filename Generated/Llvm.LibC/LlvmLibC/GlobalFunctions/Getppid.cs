using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Getppid
{
	[MangledName("getppid")]
	[DemangledName("getppid")]
	public static int Invoke()
	{
		return Llvm_libc_20_1_2_syscall_impl_int.Invoke(110L);
	}
}
