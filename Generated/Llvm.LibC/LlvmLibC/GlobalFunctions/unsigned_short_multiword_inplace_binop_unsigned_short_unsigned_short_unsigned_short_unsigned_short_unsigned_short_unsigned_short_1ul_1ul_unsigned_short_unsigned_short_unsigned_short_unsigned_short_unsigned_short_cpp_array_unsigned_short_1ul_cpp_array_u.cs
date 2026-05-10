using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_9multiword13inplace_binopIPFttttRtEtLm1ELm1EEET0_T_RNS_3cpp5arrayIS5_XT1_EEERKNS8_IS5_XT2_EEE")]
[DemangledName("unsigned short __llvm_libc_20_1_2_::multiword::inplace_binop<unsigned short (*)(unsigned short, unsigned short, unsigned short, unsigned short&), unsigned short, 1ul, 1ul>(unsigned short (*)(unsigned short, unsigned short, unsigned short, unsigned short&), __llvm_libc_20_1_2_::cpp::array<unsigned short, 1ul>&, __llvm_libc_20_1_2_::cpp::array<unsigned short, 1ul> const&)")]
internal static partial class unsigned_short_multiword_inplace_binop_unsigned_short_unsigned_short_unsigned_short_unsigned_short_unsigned_short_unsigned_short_1ul_1ul_unsigned_short_unsigned_short_unsigned_short_unsigned_short_unsigned_short_cpp_array_unsigned_short_1ul_cpp_array_unsigned_short_1ul_const
{
	public unsafe static short Invoke(void* op_with_carry, void* dst, void* rhs)
	{
		short num = 0;
		long num2 = 0L;
		sbyte b = 0;
		short num3 = 0;
		short num4 = 0;
		llvm_lifetime_start_p0.Invoke(2L, &num);
		num = 0;
		llvm_lifetime_start_p0.Invoke(8L, &num2);
		unchecked
		{
			for (num2 = 0L; (ulong)num2 < 1uL; num2++)
			{
				llvm_lifetime_start_p0.Invoke(1L, &b);
				b = (((ulong)num2 < 1uL) ? ((sbyte)1) : ((sbyte)0));
				llvm_lifetime_start_p0.Invoke(2L, &num3);
				num3 = (short)(((b & 1) == 1) ? ((ushort)(*(short*)cpp_array_unsigned_short_1ul_operator_unsigned_long_const.Invoke(rhs, num2))) : 0);
				llvm_lifetime_start_p0.Invoke(2L, &num4);
				num4 = num;
				short num5 = ((delegate*<short, short, short, short*, short>)op_with_carry)(*(short*)cpp_array_unsigned_short_1ul_operator_unsigned_long.Invoke(dst, num2), num3, num4, &num);
				*(short*)cpp_array_unsigned_short_1ul_operator_unsigned_long.Invoke(dst, num2) = num5;
				int num6 = (((b & 1) != 1 && (ushort)num == 0) ? 2 : 0);
				llvm_lifetime_end_p0.Invoke(2L, &num4);
				llvm_lifetime_end_p0.Invoke(2L, &num3);
				llvm_lifetime_end_p0.Invoke(1L, &b);
				switch (num6)
				{
				case 0:
					continue;
				}
				break;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			short result = num;
			llvm_lifetime_end_p0.Invoke(2L, &num);
			return result;
		}
	}
}
