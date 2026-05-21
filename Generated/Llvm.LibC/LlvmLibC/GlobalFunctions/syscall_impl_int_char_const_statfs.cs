using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class syscall_impl_int_char_const_statfs
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12syscall_implIiJPKcP6statfsEEET_lDpT0_")]
	[DemangledName("int __llvm_libc_20_1_2_::syscall_impl<int, char const*, statfs*>(long, char const*, statfs*)")]
	[return: NativeType("int")]
	public unsafe static int Invoke([MangledName("__number")][NativeType("long")] long number, [MangledName("ts")][CleanName("ts")][NativeType("char const*")] void* ts_3enpke, [MangledName("ts1")][CleanName("ts")][NativeType("statfs*")] statfs* ts_76xnpk)
	{
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = unchecked(syscall_impl.Invoke(number, (long)ts_3enpke, (long)ts_76xnpk));
		int result = cpp_bit_or_static_cast_int_long.Invoke(&num);
		llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
