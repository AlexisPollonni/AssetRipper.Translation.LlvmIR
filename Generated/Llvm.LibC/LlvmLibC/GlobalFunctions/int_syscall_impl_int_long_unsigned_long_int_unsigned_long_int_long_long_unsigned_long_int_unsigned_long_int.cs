using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_12syscall_implIiJlmimiEEET_lDpT0_")]
[DemangledName("int __llvm_libc_20_1_2_::syscall_impl<int, long, unsigned long, int, unsigned long, int>(long, long, unsigned long, int, unsigned long, int)")]
internal static partial class int_syscall_impl_int_long_unsigned_long_int_unsigned_long_int_long_long_unsigned_long_int_unsigned_long_int
{
	public unsafe static int Invoke([MangledName("__number")] long number, [MangledName("ts")][CleanName("ts")] long ts_3enpke, [MangledName("ts1")][CleanName("ts")] long ts_76xnpk, [MangledName("ts3")][CleanName("ts")] int ts_w24gdx, [MangledName("ts5")][CleanName("ts")] long ts_784yyq, [MangledName("ts7")][CleanName("ts")] int ts_4jbuhx)
	{
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = syscall_impl_long_long_long_long_long_long.Invoke(number, ts_3enpke, ts_76xnpk, ts_w24gdx, ts_784yyq, ts_4jbuhx);
		int result = int_cpp_bit_or_static_cast_int_long_long_const.Invoke(&num);
		llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
