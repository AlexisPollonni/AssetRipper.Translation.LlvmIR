using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_12syscall_implIiJiPiiP6rusageEEET_lDpT0_")]
[DemangledName("int __llvm_libc_20_1_2_::syscall_impl<int, int, int*, int, rusage*>(long, int, int*, int, rusage*)")]
internal static partial class int_syscall_impl_int_int_int_int_rusage_long_int_int_int_rusage
{
	public unsafe static int Invoke([MangledName("__number")] long number, [MangledName("ts")][CleanName("ts")] int ts_3enpke, [MangledName("ts1")][CleanName("ts")] void* ts_76xnpk, [MangledName("ts3")][CleanName("ts")] int ts_w24gdx, [MangledName("ts5")][CleanName("ts")] void* ts_784yyq)
	{
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = unchecked(syscall_impl_long_long_long_long_long.Invoke(number, ts_3enpke, (long)ts_76xnpk, ts_w24gdx, (long)ts_784yyq));
		int result = int_cpp_bit_or_static_cast_int_long_long_const.Invoke(&num);
		llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
