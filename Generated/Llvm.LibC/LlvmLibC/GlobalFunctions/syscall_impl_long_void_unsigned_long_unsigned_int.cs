using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class syscall_impl_long_void_unsigned_long_unsigned_int
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12syscall_implIlJPvmjEEET_lDpT0_")]
	[DemangledName("long __llvm_libc_20_1_2_::syscall_impl<long, void*, unsigned long, unsigned int>(long, void*, unsigned long, unsigned int)")]
	[return: NativeType("long")]
	public unsafe static long Invoke([MangledName("__number")][NativeType("long")] long number, [MangledName("ts")][CleanName("ts")][NativeType("void*")] void* ts_3enpke, [MangledName("ts1")][CleanName("ts")][NativeType("unsigned long")] long ts_76xnpk, [MangledName("ts3")][CleanName("ts")][NativeType("unsigned int")] int ts_w24gdx)
	{
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = unchecked(syscall_impl.Invoke(number, (long)ts_3enpke, ts_76xnpk, (uint)ts_w24gdx));
		long result = cpp_bit_or_static_cast_long_long.Invoke(&num);
		llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
