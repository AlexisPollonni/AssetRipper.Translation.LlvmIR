using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_exit
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal4exitEi")]
	[DemangledName("__llvm_libc_20_1_2_::internal::exit(int)")]
	public static void Invoke([MangledName("status")][NativeType("int")] int Status)
	{
		while (true)
		{
			Syscall_impl_long_int.Invoke(231L, Status);
			Syscall_impl_long_int.Invoke(60L, Status);
		}
	}
}
