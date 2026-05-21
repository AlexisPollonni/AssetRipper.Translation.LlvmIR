using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class syscall_impl_int_int_char_const_int_unsigned_int
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12syscall_implIiJiPKcijEEET_lDpT0_")]
	[DemangledName("int __llvm_libc_20_1_2_::syscall_impl<int, int, char const*, int, unsigned int>(long, int, char const*, int, unsigned int)")]
	[return: NativeType("int")]
	public unsafe static int Invoke([MangledName("__number")][NativeType("long")] long number, [MangledName("ts")][CleanName("ts")][NativeType("int")] int ts_3enpke, [MangledName("ts1")][CleanName("ts")][NativeType("char const*")] void* ts_76xnpk, [MangledName("ts3")][CleanName("ts")][NativeType("int")] int ts_w24gdx, [MangledName("ts5")][CleanName("ts")][NativeType("unsigned int")] int ts_784yyq)
	{
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = unchecked(syscall_impl.Invoke(number, ts_3enpke, (long)ts_76xnpk, ts_w24gdx, (uint)ts_784yyq));
		int result = cpp_bit_or_static_cast_int_long.Invoke(&num);
		llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
