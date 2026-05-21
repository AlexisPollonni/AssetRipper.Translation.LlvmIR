using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fixed_point_bit_and_short_Accum
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11fixed_point7bit_andIDAsEENS_3cpp9enable_ifIXsr3cppE16is_fixed_point_vIT_EES4_E4typeES4_S4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_fixed_point_v<short _Accum>, short _Accum>::type __llvm_libc_20_1_2_::fixed_point::bit_and<short _Accum>(short _Accum, short _Accum)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_fixed_point_v<short _Accum>, short _Accum>::type")]
	public unsafe static short Invoke([MangledName("x")][NativeType("short _Accum")] short X, [MangledName("y")][NativeType("short _Accum")] short Y)
	{
		short num = 0;
		short num2 = 0;
		short num3 = 0;
		short num4 = X;
		short num5 = Y;
		Llvm_lifetime_start_p0.Invoke(2L, &num);
		num = Cpp_bit_cast_unsigned_short_short_Accum.Invoke(&num4);
		Llvm_lifetime_start_p0.Invoke(2L, &num2);
		num2 = Cpp_bit_cast_unsigned_short_short_Accum.Invoke(&num5);
		Llvm_lifetime_start_p0.Invoke(2L, &num3);
		num3 = unchecked((short)((ushort)num & (ushort)num2));
		short result = Cpp_bit_cast_short_Accum_unsigned_short.Invoke(&num3);
		Llvm_lifetime_end_p0.Invoke(2L, &num3);
		Llvm_lifetime_end_p0.Invoke(2L, &num2);
		Llvm_lifetime_end_p0.Invoke(2L, &num);
		return result;
	}
}
