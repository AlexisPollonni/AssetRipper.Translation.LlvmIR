using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class syscall_impl_long_int_void_unsigned_long_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12syscall_implIlJiPvmlEEET_lDpT0_")]
	[DemangledName("long __llvm_libc_20_1_2_::syscall_impl<long, int, void*, unsigned long, long>(long, int, void*, unsigned long, long)")]
	[return: NativeType("long")]
	public unsafe static long Invoke([MangledName("__number")][NativeType("long")] long number, [MangledName("ts")][CleanName("ts")][NativeType("int")] int ts_3enpke, [MangledName("ts1")][CleanName("ts")][NativeType("void*")] void* ts_76xnpk, [MangledName("ts3")][CleanName("ts")][NativeType("unsigned long")] long ts_w24gdx, [MangledName("ts5")][CleanName("ts")][NativeType("long")] long ts_784yyq)
	{
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = syscall_impl.Invoke(number, ts_3enpke, unchecked((long)ts_76xnpk), ts_w24gdx, ts_784yyq);
		long result = cpp_bit_or_static_cast_long_long.Invoke(&num);
		llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
