using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal4exitEi")]
[DemangledName("__llvm_libc_20_1_2_::internal::exit(int)")]
internal static partial class internal_exit_int
{
	public static void Invoke(int status)
	{
		while (true)
		{
			long_syscall_impl_long_int_long_int.Invoke(231L, status);
			long_syscall_impl_long_int_long_int.Invoke(60L, status);
		}
	}
}
