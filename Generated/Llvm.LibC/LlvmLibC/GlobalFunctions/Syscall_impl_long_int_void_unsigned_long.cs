using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Syscall_impl_long_int_void_unsigned_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12syscall_implIlJiPvmEEET_lDpT0_")]
	[DemangledName("long __llvm_libc_20_1_2_::syscall_impl<long, int, void*, unsigned long>(long, int, void*, unsigned long)")]
	[return: NativeType("long")]
	public unsafe static long Invoke([MangledName("__number")][NativeType("long")] long Number, [MangledName("ts")][CleanName("Ts")][NativeType("int")] int Ts_3enpke, [MangledName("ts1")][CleanName("Ts")][NativeType("void*")] void* Ts_76xnpk, [MangledName("ts3")][CleanName("Ts")][NativeType("unsigned long")] long Ts_w24gdx)
	{
		long num = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = Syscall_impl.Invoke(Number, Ts_3enpke, unchecked((long)Ts_76xnpk), Ts_w24gdx);
		long result = Cpp_bit_or_static_cast_long_long.Invoke(&num);
		Llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
