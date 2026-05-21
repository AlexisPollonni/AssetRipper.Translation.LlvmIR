using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_exit
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal4exitEi")]
	[DemangledName("__llvm_libc_20_1_2_::internal::exit(int)")]
	public static void Invoke([NativeType("int")] int status)
	{
		while (true)
		{
			syscall_impl_long_int.Invoke(231L, status);
			syscall_impl_long_int.Invoke(60L, status);
		}
	}
}
