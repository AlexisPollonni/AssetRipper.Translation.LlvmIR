using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Syscall_impl_int_int_sched_param_const
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12syscall_implIiJiPK11sched_paramEEET_lDpT0_")]
	[DemangledName("int __llvm_libc_20_1_2_::syscall_impl<int, int, sched_param const*>(long, int, sched_param const*)")]
	[return: NativeType("int")]
	public unsafe static int Invoke([MangledName("__number")][NativeType("long")] long Number, [MangledName("ts")][CleanName("Ts")][NativeType("int")] int Ts_3enpke, [MangledName("ts1")][CleanName("Ts")][NativeType("sched_param const*")] void* Ts_76xnpk)
	{
		long num = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = Syscall_impl.Invoke(Number, Ts_3enpke, unchecked((long)Ts_76xnpk));
		int result = Cpp_bit_or_static_cast_int_long.Invoke(&num);
		Llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
