using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class syscall_impl_int_int_unsigned_long_cpu_set_t
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12syscall_implIiJimP9cpu_set_tEEET_lDpT0_")]
	[DemangledName("int __llvm_libc_20_1_2_::syscall_impl<int, int, unsigned long, cpu_set_t*>(long, int, unsigned long, cpu_set_t*)")]
	[return: NativeType("int")]
	public unsafe static int Invoke([MangledName("__number")][NativeType("long")] long number, [MangledName("ts")][CleanName("ts")][NativeType("int")] int ts_3enpke, [MangledName("ts1")][CleanName("ts")][NativeType("unsigned long")] long ts_76xnpk, [MangledName("ts3")][CleanName("ts")][NativeType("cpu_set_t*")] void* ts_w24gdx)
	{
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = syscall_impl.Invoke(number, ts_3enpke, ts_76xnpk, unchecked((long)ts_w24gdx));
		int result = cpp_bit_or_static_cast_int_long.Invoke(&num);
		llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
