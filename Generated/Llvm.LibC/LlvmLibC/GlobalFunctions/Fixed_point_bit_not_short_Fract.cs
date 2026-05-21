using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fixed_point_bit_not_short_Fract
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11fixed_point7bit_notIDRsEENS_3cpp9enable_ifIXsr3cppE16is_fixed_point_vIT_EES4_E4typeES4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_fixed_point_v<short _Fract>, short _Fract>::type __llvm_libc_20_1_2_::fixed_point::bit_not<short _Fract>(short _Fract)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_fixed_point_v<short _Fract>, short _Fract>::type")]
	public unsafe static sbyte Invoke([MangledName("x")][NativeType("short _Fract")] sbyte X)
	{
		sbyte b = 0;
		sbyte b2 = 0;
		sbyte b3 = X;
		Llvm_lifetime_start_p0.Invoke(1L, &b);
		b = Cpp_bit_cast_unsigned_char_short_Fract.Invoke(&b3);
		Llvm_lifetime_start_p0.Invoke(1L, &b2);
		b2 = unchecked((sbyte)((byte)b ^ -1));
		sbyte result = Cpp_bit_cast_short_Fract_unsigned_char.Invoke(&b2);
		Llvm_lifetime_end_p0.Invoke(1L, &b2);
		Llvm_lifetime_end_p0.Invoke(1L, &b);
		return result;
	}
}
