using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_12syscall_implIiJPKcPKPcS5_EEET_lDpT0_")]
[DemangledName("int __llvm_libc_20_1_2_::syscall_impl<int, char const*, char* const*, char* const*>(long, char const*, char* const*, char* const*)")]
internal static partial class int_syscall_impl_int_char_const_char_const_char_const_long_char_const_char_const_char_const
{
	public unsafe static int Invoke([MangledName("__number")] long number, [MangledName("ts")][CleanName("ts")] void* ts_3enpke, [MangledName("ts1")][CleanName("ts")] void* ts_76xnpk, [MangledName("ts3")][CleanName("ts")] void* ts_w24gdx)
	{
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = unchecked(syscall_impl_long_long_long_long.Invoke(number, (long)ts_3enpke, (long)ts_76xnpk, (long)ts_w24gdx));
		int result = int_cpp_bit_or_static_cast_int_long_long_const.Invoke(&num);
		llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
