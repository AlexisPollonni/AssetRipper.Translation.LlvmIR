using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Getpid
{
	[MangledName("getpid")]
	[DemangledName("getpid")]
	public static int Invoke()
	{
		return Llvm_libc_20_1_2_syscall_impl_int.Invoke(39L);
	}
}
