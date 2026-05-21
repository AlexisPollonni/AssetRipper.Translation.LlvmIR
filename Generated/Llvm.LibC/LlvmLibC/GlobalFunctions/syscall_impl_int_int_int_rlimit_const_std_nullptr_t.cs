using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class syscall_impl_int_int_int_rlimit_const_std_nullptr_t
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12syscall_implIiJiiPK6rlimitDnEEET_lDpT0_")]
	[DemangledName("int __llvm_libc_20_1_2_::syscall_impl<int, int, int, rlimit const*, std::nullptr_t>(long, int, int, rlimit const*, std::nullptr_t)")]
	[return: NativeType("int")]
	public unsafe static int Invoke([MangledName("__number")][NativeType("long")] long number, [MangledName("ts")][CleanName("ts")][NativeType("int")] int ts_3enpke, [MangledName("ts1")][CleanName("ts")][NativeType("int")] int ts_76xnpk, [MangledName("ts3")][CleanName("ts")][NativeType("rlimit const*")] void* ts_w24gdx, [MangledName("ts5")][CleanName("ts")][NativeType("std::nullptr_t")] void* ts_784yyq)
	{
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = syscall_impl.Invoke(number, ts_3enpke, ts_76xnpk, unchecked((long)ts_w24gdx), 0L);
		int result = cpp_bit_or_static_cast_int_long.Invoke(&num);
		llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
