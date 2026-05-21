using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llvm_libc_20_1_2_syscall_impl_int_int_char_const_unsigned_int
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12syscall_implIiJiPKcjEEET_lDpT0_")]
	[DemangledName("int __llvm_libc_20_1_2_::syscall_impl<int, int, char const*, unsigned int>(long, int, char const*, unsigned int)")]
	[return: NativeType("int")]
	public unsafe static int Invoke([MangledName("__number")][NativeType("long")] long Number, [MangledName("ts")][CleanName("Ts")][NativeType("int")] int Ts_3enpke, [MangledName("ts1")][CleanName("Ts")][NativeType("char const*")] void* Ts_76xnpk, [MangledName("ts3")][CleanName("Ts")][NativeType("unsigned int")] int Ts_w24gdx)
	{
		long num = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = unchecked(Llvm_libc_20_1_2_syscall_impl.Invoke(Number, Ts_3enpke, (long)Ts_76xnpk, (uint)Ts_w24gdx));
		int result = Cpp_bit_or_static_cast_int_long.Invoke(&num);
		Llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
