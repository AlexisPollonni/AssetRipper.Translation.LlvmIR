using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fixed_point_bit_not_unsigned_short_Fract
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11fixed_point7bit_notIDRtEENS_3cpp9enable_ifIXsr3cppE16is_fixed_point_vIT_EES4_E4typeES4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_fixed_point_v<unsigned short _Fract>, unsigned short _Fract>::type __llvm_libc_20_1_2_::fixed_point::bit_not<unsigned short _Fract>(unsigned short _Fract)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_fixed_point_v<unsigned short _Fract>, unsigned short _Fract>::type")]
	public unsafe static sbyte Invoke([NativeType("unsigned short _Fract")] sbyte x)
	{
		sbyte b = 0;
		sbyte b2 = 0;
		sbyte b3 = x;
		llvm_lifetime_start_p0.Invoke(1L, &b);
		b = cpp_bit_cast_unsigned_char_unsigned_short_Fract.Invoke(&b3);
		llvm_lifetime_start_p0.Invoke(1L, &b2);
		b2 = unchecked((sbyte)((byte)b ^ -1));
		sbyte result = cpp_bit_cast_unsigned_short_Fract_unsigned_char.Invoke(&b2);
		llvm_lifetime_end_p0.Invoke(1L, &b2);
		llvm_lifetime_end_p0.Invoke(1L, &b);
		return result;
	}
}
