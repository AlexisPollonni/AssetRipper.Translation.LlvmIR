using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Syscall_impl_int_char_const_int_char_const
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12syscall_implIiJPKciS2_EEET_lDpT0_")]
	[DemangledName("int __llvm_libc_20_1_2_::syscall_impl<int, char const*, int, char const*>(long, char const*, int, char const*)")]
	[return: NativeType("int")]
	public unsafe static int Invoke([MangledName("__number")][NativeType("long")] long Number, [MangledName("ts")][CleanName("Ts")][NativeType("char const*")] void* Ts_3enpke, [MangledName("ts1")][CleanName("Ts")][NativeType("int")] int Ts_76xnpk, [MangledName("ts3")][CleanName("Ts")][NativeType("char const*")] void* Ts_w24gdx)
	{
		long num = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = unchecked(Syscall_impl.Invoke(Number, (long)Ts_3enpke, Ts_76xnpk, (long)Ts_w24gdx));
		int result = Cpp_bit_or_static_cast_int_long.Invoke(&num);
		Llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
