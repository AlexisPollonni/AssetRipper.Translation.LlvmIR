using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fixed_point_bit_and_unsigned_short_Fract
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11fixed_point7bit_andIDRtEENS_3cpp9enable_ifIXsr3cppE16is_fixed_point_vIT_EES4_E4typeES4_S4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_fixed_point_v<unsigned short _Fract>, unsigned short _Fract>::type __llvm_libc_20_1_2_::fixed_point::bit_and<unsigned short _Fract>(unsigned short _Fract, unsigned short _Fract)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_fixed_point_v<unsigned short _Fract>, unsigned short _Fract>::type")]
	public unsafe static sbyte Invoke([MangledName("x")][NativeType("unsigned short _Fract")] sbyte X, [MangledName("y")][NativeType("unsigned short _Fract")] sbyte Y)
	{
		sbyte b = 0;
		sbyte b2 = 0;
		sbyte b3 = 0;
		sbyte b4 = X;
		sbyte b5 = Y;
		Llvm_lifetime_start_p0.Invoke(1L, &b);
		b = Cpp_bit_cast_unsigned_char_unsigned_short_Fract.Invoke(&b4);
		Llvm_lifetime_start_p0.Invoke(1L, &b2);
		b2 = Cpp_bit_cast_unsigned_char_unsigned_short_Fract.Invoke(&b5);
		Llvm_lifetime_start_p0.Invoke(1L, &b3);
		b3 = unchecked((sbyte)((byte)b & (byte)b2));
		sbyte result = Cpp_bit_cast_unsigned_short_Fract_unsigned_char.Invoke(&b3);
		Llvm_lifetime_end_p0.Invoke(1L, &b3);
		Llvm_lifetime_end_p0.Invoke(1L, &b2);
		Llvm_lifetime_end_p0.Invoke(1L, &b);
		return result;
	}
}
