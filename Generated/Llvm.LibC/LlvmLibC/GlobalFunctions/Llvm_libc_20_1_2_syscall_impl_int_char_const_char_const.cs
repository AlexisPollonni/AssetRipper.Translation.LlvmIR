using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llvm_libc_20_1_2_syscall_impl_int_char_const_char_const
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12syscall_implIiJPKcS2_EEET_lDpT0_")]
	[DemangledName("int __llvm_libc_20_1_2_::syscall_impl<int, char const*, char const*>(long, char const*, char const*)")]
	[return: NativeType("int")]
	public unsafe static int Invoke([MangledName("__number")][NativeType("long")] long Number, [MangledName("ts")][CleanName("Ts")][NativeType("char const*")] void* Ts_3enpke, [MangledName("ts1")][CleanName("Ts")][NativeType("char const*")] void* Ts_76xnpk)
	{
		long num = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = unchecked(Llvm_libc_20_1_2_syscall_impl.Invoke(Number, (long)Ts_3enpke, (long)Ts_76xnpk));
		int result = Cpp_bit_or_static_cast_int_long.Invoke(&num);
		Llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
