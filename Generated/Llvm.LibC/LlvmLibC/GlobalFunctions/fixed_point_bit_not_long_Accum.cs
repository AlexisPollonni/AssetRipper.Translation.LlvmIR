using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fixed_point_bit_not_long_Accum
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11fixed_point7bit_notIDAlEENS_3cpp9enable_ifIXsr3cppE16is_fixed_point_vIT_EES4_E4typeES4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_fixed_point_v<long _Accum>, long _Accum>::type __llvm_libc_20_1_2_::fixed_point::bit_not<long _Accum>(long _Accum)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_fixed_point_v<long _Accum>, long _Accum>::type")]
	public unsafe static long Invoke([NativeType("long _Accum")] long x)
	{
		long num = 0L;
		long num2 = 0L;
		long num3 = x;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = cpp_bit_cast_unsigned_long_long_Accum.Invoke(&num3);
		llvm_lifetime_start_p0.Invoke(8L, &num2);
		num2 = num ^ -1L;
		long result = cpp_bit_cast_long_Accum_unsigned_long.Invoke(&num2);
		llvm_lifetime_end_p0.Invoke(8L, &num2);
		llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
