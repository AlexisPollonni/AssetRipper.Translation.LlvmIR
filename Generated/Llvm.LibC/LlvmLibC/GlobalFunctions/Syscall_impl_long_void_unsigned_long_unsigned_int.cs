using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Syscall_impl_long_void_unsigned_long_unsigned_int
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12syscall_implIlJPvmjEEET_lDpT0_")]
	[DemangledName("long __llvm_libc_20_1_2_::syscall_impl<long, void*, unsigned long, unsigned int>(long, void*, unsigned long, unsigned int)")]
	[return: NativeType("long")]
	public unsafe static long Invoke([MangledName("__number")][NativeType("long")] long Number, [MangledName("ts")][CleanName("Ts")][NativeType("void*")] void* Ts_3enpke, [MangledName("ts1")][CleanName("Ts")][NativeType("unsigned long")] long Ts_76xnpk, [MangledName("ts3")][CleanName("Ts")][NativeType("unsigned int")] int Ts_w24gdx)
	{
		long num = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = unchecked(Syscall_impl.Invoke(Number, (long)Ts_3enpke, Ts_76xnpk, (uint)Ts_w24gdx));
		long result = Cpp_bit_or_static_cast_long_long.Invoke(&num);
		Llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
