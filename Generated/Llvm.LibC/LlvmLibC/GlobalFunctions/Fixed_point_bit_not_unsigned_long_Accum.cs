using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fixed_point_bit_not_unsigned_long_Accum
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11fixed_point7bit_notIDAmEENS_3cpp9enable_ifIXsr3cppE16is_fixed_point_vIT_EES4_E4typeES4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_fixed_point_v<unsigned long _Accum>, unsigned long _Accum>::type __llvm_libc_20_1_2_::fixed_point::bit_not<unsigned long _Accum>(unsigned long _Accum)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_fixed_point_v<unsigned long _Accum>, unsigned long _Accum>::type")]
	public unsafe static long Invoke([MangledName("x")][NativeType("unsigned long _Accum")] long X)
	{
		long num = 0L;
		long num2 = 0L;
		long num3 = X;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = Cpp_bit_cast_unsigned_long_unsigned_long_Accum.Invoke(&num3);
		Llvm_lifetime_start_p0.Invoke(8L, &num2);
		num2 = num ^ -1L;
		long result = Cpp_bit_cast_unsigned_long_Accum_unsigned_long.Invoke(&num2);
		Llvm_lifetime_end_p0.Invoke(8L, &num2);
		Llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
