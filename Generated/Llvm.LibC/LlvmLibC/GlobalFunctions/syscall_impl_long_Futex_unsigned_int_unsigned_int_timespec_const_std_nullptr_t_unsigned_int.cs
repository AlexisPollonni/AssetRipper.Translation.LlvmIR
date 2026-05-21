using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class syscall_impl_long_Futex_unsigned_int_unsigned_int_timespec_const_std_nullptr_t_unsigned_int
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12syscall_implIlJPNS_5FutexEjjPK8timespecDnjEEET_lDpT0_")]
	[DemangledName("long __llvm_libc_20_1_2_::syscall_impl<long, __llvm_libc_20_1_2_::Futex*, unsigned int, unsigned int, timespec const*, std::nullptr_t, unsigned int>(long, __llvm_libc_20_1_2_::Futex*, unsigned int, unsigned int, timespec const*, std::nullptr_t, unsigned int)")]
	[return: NativeType("long")]
	public unsafe static long Invoke([MangledName("__number")][NativeType("long")] long number, [MangledName("ts")][CleanName("ts")][NativeType("__llvm_libc_20_1_2_::Futex*")] void* ts_3enpke, [MangledName("ts1")][CleanName("ts")][NativeType("unsigned int")] int ts_76xnpk, [MangledName("ts3")][CleanName("ts")][NativeType("unsigned int")] int ts_w24gdx, [MangledName("ts5")][CleanName("ts")][NativeType("timespec const*")] AuxEntry* ts_784yyq, [MangledName("ts7")][CleanName("ts")][NativeType("std::nullptr_t")] void* ts_4jbuhx, [MangledName("ts9")][CleanName("ts")][NativeType("unsigned int")] int ts_g7c8gc)
	{
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = unchecked(syscall_impl.Invoke(number, (long)ts_3enpke, (uint)ts_76xnpk, (uint)ts_w24gdx, (long)ts_784yyq, 0L, (uint)ts_g7c8gc));
		long result = cpp_bit_or_static_cast_long_long.Invoke(&num);
		llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
