using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Syscall_impl_int_utsname
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12syscall_implIiJP7utsnameEEET_lDpT0_")]
	[DemangledName("int __llvm_libc_20_1_2_::syscall_impl<int, utsname*>(long, utsname*)")]
	[return: NativeType("int")]
	public unsafe static int Invoke([MangledName("__number")][NativeType("long")] long Number, [MangledName("ts")][NativeType("utsname*")] void* Ts)
	{
		long num = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = Syscall_impl.Invoke(Number, unchecked((long)Ts));
		int result = Cpp_bit_or_static_cast_int_long.Invoke(&num);
		Llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
