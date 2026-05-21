using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class syscall_impl_int_char_const_long_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12syscall_implIiJPKcllEEET_lDpT0_")]
	[DemangledName("int __llvm_libc_20_1_2_::syscall_impl<int, char const*, long, long>(long, char const*, long, long)")]
	[return: NativeType("int")]
	public unsafe static int Invoke([MangledName("__number")][NativeType("long")] long number, [MangledName("ts")][CleanName("ts")][NativeType("char const*")] void* ts_3enpke, [MangledName("ts1")][CleanName("ts")][NativeType("long")] long ts_76xnpk, [MangledName("ts3")][CleanName("ts")][NativeType("long")] long ts_w24gdx)
	{
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = syscall_impl.Invoke(number, unchecked((long)ts_3enpke), ts_76xnpk, ts_w24gdx);
		int result = cpp_bit_or_static_cast_int_long.Invoke(&num);
		llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
