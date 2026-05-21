using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fixed_point_bit_and_unsigned_Accum
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11fixed_point7bit_andIDAjEENS_3cpp9enable_ifIXsr3cppE16is_fixed_point_vIT_EES4_E4typeES4_S4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_fixed_point_v<unsigned _Accum>, unsigned _Accum>::type __llvm_libc_20_1_2_::fixed_point::bit_and<unsigned _Accum>(unsigned _Accum, unsigned _Accum)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_fixed_point_v<unsigned _Accum>, unsigned _Accum>::type")]
	public unsafe static int Invoke([NativeType("unsigned _Accum")] int x, [NativeType("unsigned _Accum")] int y)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = x;
		int num5 = y;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = cpp_bit_cast_unsigned_int_unsigned_Accum.Invoke(&num4);
		llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = cpp_bit_cast_unsigned_int_unsigned_Accum.Invoke(&num5);
		llvm_lifetime_start_p0.Invoke(4L, &num3);
		num3 = num & num2;
		int result = cpp_bit_cast_unsigned_Accum_unsigned_int.Invoke(&num3);
		llvm_lifetime_end_p0.Invoke(4L, &num3);
		llvm_lifetime_end_p0.Invoke(4L, &num2);
		llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
