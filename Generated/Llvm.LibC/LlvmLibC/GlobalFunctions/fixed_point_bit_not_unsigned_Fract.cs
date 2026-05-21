using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fixed_point_bit_not_unsigned_Fract
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11fixed_point7bit_notIDRjEENS_3cpp9enable_ifIXsr3cppE16is_fixed_point_vIT_EES4_E4typeES4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_fixed_point_v<unsigned _Fract>, unsigned _Fract>::type __llvm_libc_20_1_2_::fixed_point::bit_not<unsigned _Fract>(unsigned _Fract)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_fixed_point_v<unsigned _Fract>, unsigned _Fract>::type")]
	public unsafe static short Invoke([NativeType("unsigned _Fract")] short x)
	{
		short num = 0;
		short num2 = 0;
		short num3 = x;
		llvm_lifetime_start_p0.Invoke(2L, &num);
		num = cpp_bit_cast_unsigned_short_unsigned_Fract.Invoke(&num3);
		llvm_lifetime_start_p0.Invoke(2L, &num2);
		num2 = unchecked((short)((ushort)num ^ -1));
		short result = cpp_bit_cast_unsigned_Fract_unsigned_short.Invoke(&num2);
		llvm_lifetime_end_p0.Invoke(2L, &num2);
		llvm_lifetime_end_p0.Invoke(2L, &num);
		return result;
	}
}
