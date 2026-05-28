using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Syscall_impl_int_int_int_rlimit_const_std_nullptr_t
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12syscall_implIiJiiPK6rlimitDnEEET_lDpT0_")]
	[DemangledName("int __llvm_libc_20_1_2_::syscall_impl<int, int, int, rlimit const*, std::nullptr_t>(long, int, int, rlimit const*, std::nullptr_t)")]
	[return: NativeType("int")]
	public unsafe static int Invoke([MangledName("__number")][NativeType("long")] long Number, [MangledName("ts")][CleanName("Ts")][NativeType("int")] int Ts_3enpke, [MangledName("ts1")][CleanName("Ts")][NativeType("int")] int Ts_76xnpk, [MangledName("ts3")][CleanName("Ts")][NativeType("rlimit const*")] void* Ts_w24gdx, [MangledName("ts5")][CleanName("Ts")][NativeType("std::nullptr_t")] void* Ts_784yyq)
	{
		long num = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = Syscall_impl.Invoke(Number, Ts_3enpke, Ts_76xnpk, unchecked((long)Ts_w24gdx), 0L);
		int result = Cpp_bit_or_static_cast_int_long.Invoke(&num);
		Llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
