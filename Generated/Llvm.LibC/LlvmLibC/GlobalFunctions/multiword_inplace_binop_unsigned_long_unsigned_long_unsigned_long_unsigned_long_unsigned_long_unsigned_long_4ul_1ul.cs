using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class multiword_inplace_binop_unsigned_long_unsigned_long_unsigned_long_unsigned_long_unsigned_long_unsigned_long_4ul_1ul
{
	[MangledName("_ZN19__llvm_libc_20_1_2_9multiword13inplace_binopIPFmmmmRmEmLm4ELm1EEET0_T_RNS_3cpp5arrayIS5_XT1_EEERKNS8_IS5_XT2_EEE")]
	[DemangledName("unsigned long __llvm_libc_20_1_2_::multiword::inplace_binop<unsigned long (*)(unsigned long, unsigned long, unsigned long, unsigned long&), unsigned long, 4ul, 1ul>(unsigned long (*)(unsigned long, unsigned long, unsigned long, unsigned long&), __llvm_libc_20_1_2_::cpp::array<unsigned long, 4ul>&, __llvm_libc_20_1_2_::cpp::array<unsigned long, 1ul> const&)")]
	[return: NativeType("unsigned long")]
	public unsafe static long Invoke([NativeType("unsigned long (*)(unsigned long, unsigned long, unsigned long, unsigned long&)")] void* op_with_carry, [NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned long, 4ul>&")] cpp_array_jgy3xh* dst, [NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned long, 1ul> const&")] cpp_array_rpgxvv* rhs)
	{
		long num = 0L;
		long num2 = 0L;
		sbyte b = 0;
		long num3 = 0L;
		long num4 = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num2);
		unchecked
		{
			for (num2 = 0L; (ulong)num2 < 4uL; num2++)
			{
				llvm_lifetime_start_p0.Invoke(1L, &b);
				b = (((ulong)num2 < 1uL) ? ((sbyte)1) : ((sbyte)0));
				llvm_lifetime_start_p0.Invoke(8L, &num3);
				num3 = (((b & 1) != 1) ? 0L : (*(long*)array_unsigned_long_1ul_Index_fk3nam.Invoke(rhs, num2)));
				llvm_lifetime_start_p0.Invoke(8L, &num4);
				num4 = num;
				long num5 = ((delegate*<long, long, long, long*, long>)op_with_carry)(*(long*)array_unsigned_long_4ul_Index_6jyt8f.Invoke(dst, num2), num3, num4, &num);
				*(long*)array_unsigned_long_4ul_Index_6jyt8f.Invoke(dst, num2) = num5;
				int num6 = (((b & 1) != 1 && num == 0L) ? 2 : 0);
				llvm_lifetime_end_p0.Invoke(8L, &num4);
				llvm_lifetime_end_p0.Invoke(8L, &num3);
				llvm_lifetime_end_p0.Invoke(1L, &b);
				switch (num6)
				{
				case 0:
					continue;
				}
				break;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			long result = num;
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
