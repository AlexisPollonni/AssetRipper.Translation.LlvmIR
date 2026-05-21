using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fixed_point_bit_and_Fract
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11fixed_point7bit_andIDRiEENS_3cpp9enable_ifIXsr3cppE16is_fixed_point_vIT_EES4_E4typeES4_S4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_fixed_point_v<_Fract>, _Fract>::type __llvm_libc_20_1_2_::fixed_point::bit_and<_Fract>(_Fract, _Fract)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_fixed_point_v<_Fract>, _Fract>::type")]
	public unsafe static short Invoke([NativeType("_Fract")] short x, [NativeType("_Fract")] short y)
	{
		short num = 0;
		short num2 = 0;
		short num3 = 0;
		short num4 = x;
		short num5 = y;
		llvm_lifetime_start_p0.Invoke(2L, &num);
		num = cpp_bit_cast_unsigned_short_Fract.Invoke(&num4);
		llvm_lifetime_start_p0.Invoke(2L, &num2);
		num2 = cpp_bit_cast_unsigned_short_Fract.Invoke(&num5);
		llvm_lifetime_start_p0.Invoke(2L, &num3);
		num3 = unchecked((short)((ushort)num & (ushort)num2));
		short result = cpp_bit_cast_Fract_unsigned_short.Invoke(&num3);
		llvm_lifetime_end_p0.Invoke(2L, &num3);
		llvm_lifetime_end_p0.Invoke(2L, &num2);
		llvm_lifetime_end_p0.Invoke(2L, &num);
		return result;
	}
}
