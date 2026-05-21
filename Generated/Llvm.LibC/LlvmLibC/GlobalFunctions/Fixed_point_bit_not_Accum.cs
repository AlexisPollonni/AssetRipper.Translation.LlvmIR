using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fixed_point_bit_not_Accum
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11fixed_point7bit_notIDAiEENS_3cpp9enable_ifIXsr3cppE16is_fixed_point_vIT_EES4_E4typeES4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_fixed_point_v<_Accum>, _Accum>::type __llvm_libc_20_1_2_::fixed_point::bit_not<_Accum>(_Accum)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_fixed_point_v<_Accum>, _Accum>::type")]
	public unsafe static int Invoke([MangledName("x")][NativeType("_Accum")] int X)
	{
		int num = 0;
		int num2 = 0;
		int num3 = X;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = Cpp_bit_cast_unsigned_int_Accum.Invoke(&num3);
		Llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = num ^ -1;
		int result = Cpp_bit_cast_Accum_unsigned_int.Invoke(&num2);
		Llvm_lifetime_end_p0.Invoke(4L, &num2);
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
