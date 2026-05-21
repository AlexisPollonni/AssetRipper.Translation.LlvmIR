using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class syscall_impl_int_char_const_int_char_const
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12syscall_implIiJPKciS2_EEET_lDpT0_")]
	[DemangledName("int __llvm_libc_20_1_2_::syscall_impl<int, char const*, int, char const*>(long, char const*, int, char const*)")]
	[return: NativeType("int")]
	public unsafe static int Invoke([MangledName("__number")][NativeType("long")] long number, [MangledName("ts")][CleanName("ts")][NativeType("char const*")] void* ts_3enpke, [MangledName("ts1")][CleanName("ts")][NativeType("int")] int ts_76xnpk, [MangledName("ts3")][CleanName("ts")][NativeType("char const*")] void* ts_w24gdx)
	{
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = unchecked(syscall_impl.Invoke(number, (long)ts_3enpke, ts_76xnpk, (long)ts_w24gdx));
		int result = cpp_bit_or_static_cast_int_long.Invoke(&num);
		llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
