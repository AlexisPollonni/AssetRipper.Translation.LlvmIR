using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Getuid
{
	[MangledName("getuid")]
	[DemangledName("getuid")]
	public static int Invoke()
	{
		return Llvm_libc_20_1_2_syscall_impl_unsigned_int.Invoke(102L);
	}
}
