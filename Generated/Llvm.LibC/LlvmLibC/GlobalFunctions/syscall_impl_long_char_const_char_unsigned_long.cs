using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class syscall_impl_long_char_const_char_unsigned_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12syscall_implIlJPKcPcmEEET_lDpT0_")]
	[DemangledName("long __llvm_libc_20_1_2_::syscall_impl<long, char const*, char*, unsigned long>(long, char const*, char*, unsigned long)")]
	[return: NativeType("long")]
	public unsafe static long Invoke([MangledName("__number")][NativeType("long")] long number, [MangledName("ts")][CleanName("ts")][NativeType("char const*")] void* ts_3enpke, [MangledName("ts1")][CleanName("ts")][NativeType("char*")] void* ts_76xnpk, [MangledName("ts3")][CleanName("ts")][NativeType("unsigned long")] long ts_w24gdx)
	{
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = unchecked(syscall_impl.Invoke(number, (long)ts_3enpke, (long)ts_76xnpk, ts_w24gdx));
		long result = cpp_bit_or_static_cast_long_long.Invoke(&num);
		llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
