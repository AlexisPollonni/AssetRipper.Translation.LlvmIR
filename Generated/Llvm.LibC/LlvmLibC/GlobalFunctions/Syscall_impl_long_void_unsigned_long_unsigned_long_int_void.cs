using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Syscall_impl_long_void_unsigned_long_unsigned_long_int_void
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12syscall_implIlJPvmmiS1_EEET_lDpT0_")]
	[DemangledName("long __llvm_libc_20_1_2_::syscall_impl<long, void*, unsigned long, unsigned long, int, void*>(long, void*, unsigned long, unsigned long, int, void*)")]
	[return: NativeType("long")]
	public unsafe static long Invoke([MangledName("__number")][NativeType("long")] long Number, [MangledName("ts")][CleanName("Ts")][NativeType("void*")] void* Ts_3enpke, [MangledName("ts1")][CleanName("Ts")][NativeType("unsigned long")] long Ts_76xnpk, [MangledName("ts3")][CleanName("Ts")][NativeType("unsigned long")] long Ts_w24gdx, [MangledName("ts5")][CleanName("Ts")][NativeType("int")] int Ts_784yyq, [MangledName("ts7")][CleanName("Ts")][NativeType("void*")] void* Ts_4jbuhx)
	{
		long num = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = unchecked(Syscall_impl.Invoke(Number, (long)Ts_3enpke, Ts_76xnpk, Ts_w24gdx, Ts_784yyq, (long)Ts_4jbuhx));
		long result = Cpp_bit_or_static_cast_long_long.Invoke(&num);
		Llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
