using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Syscall_impl_long_char_unsigned_long_int
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12syscall_implIlJPcmiEEET_lDpT0_")]
	[DemangledName("long __llvm_libc_20_1_2_::syscall_impl<long, char*, unsigned long, int>(long, char*, unsigned long, int)")]
	[return: NativeType("long")]
	public unsafe static long Invoke([MangledName("__number")][NativeType("long")] long Number, [MangledName("ts")][CleanName("Ts")][NativeType("char*")] void* Ts_3enpke, [MangledName("ts1")][CleanName("Ts")][NativeType("unsigned long")] long Ts_76xnpk, [MangledName("ts3")][CleanName("Ts")][NativeType("int")] int Ts_w24gdx)
	{
		long num = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = Syscall_impl.Invoke(Number, unchecked((long)Ts_3enpke), Ts_76xnpk, Ts_w24gdx);
		long result = Cpp_bit_or_static_cast_long_long.Invoke(&num);
		Llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
