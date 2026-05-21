using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Futex_notify_all
{
	[MangledName("_ZN19__llvm_libc_20_1_2_5Futex10notify_allEb")]
	[DemangledName("__llvm_libc_20_1_2_::Futex::notify_all(bool)")]
	public unsafe static long Invoke([MangledName("this")] void* This, [MangledName("is_shared")][NativeType("bool")] bool Is_shared)
	{
		return Llvm_libc_20_1_2_syscall_impl_long_Futex_int_int_std_nullptr_t_std_nullptr_t_int.Invoke(202L, This, InstructionHelper.Select(((Is_shared ? 1u : 0u) & 1u) == 1, 1, 129), Integer_impl_int_2147483648_2147483647_max.Invoke(), null, null, 0);
	}
}
