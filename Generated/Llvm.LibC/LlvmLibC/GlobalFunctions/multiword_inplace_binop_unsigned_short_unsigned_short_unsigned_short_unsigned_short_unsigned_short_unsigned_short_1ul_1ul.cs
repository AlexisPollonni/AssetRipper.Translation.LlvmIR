using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class multiword_inplace_binop_unsigned_short_unsigned_short_unsigned_short_unsigned_short_unsigned_short_unsigned_short_1ul_1ul
{
	[MangledName("_ZN19__llvm_libc_20_1_2_9multiword13inplace_binopIPFttttRtEtLm1ELm1EEET0_T_RNS_3cpp5arrayIS5_XT1_EEERKNS8_IS5_XT2_EEE")]
	[DemangledName("unsigned short __llvm_libc_20_1_2_::multiword::inplace_binop<unsigned short (*)(unsigned short, unsigned short, unsigned short, unsigned short&), unsigned short, 1ul, 1ul>(unsigned short (*)(unsigned short, unsigned short, unsigned short, unsigned short&), __llvm_libc_20_1_2_::cpp::array<unsigned short, 1ul>&, __llvm_libc_20_1_2_::cpp::array<unsigned short, 1ul> const&)")]
	[return: NativeType("unsigned short")]
	public unsafe static short Invoke([NativeType("unsigned short (*)(unsigned short, unsigned short, unsigned short, unsigned short&)")] void* op_with_carry, [NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned short, 1ul>&")] cpp_array_knh6hw* dst, [NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned short, 1ul> const&")] cpp_array_knh6hw* rhs)
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
				num3 = (short)(((b & 1) == 1) ? ((ushort)(*(short*)array_unsigned_short_1ul_Index_25c283.Invoke(rhs, num2))) : 0);
				llvm_lifetime_start_p0.Invoke(2L, &num4);
				num4 = num;
				short num5 = ((delegate*<short, short, short, short*, short>)op_with_carry)(*(short*)array_unsigned_short_1ul_Index_yq9pn3.Invoke(dst, num2), num3, num4, &num);
				*(short*)array_unsigned_short_1ul_Index_yq9pn3.Invoke(dst, num2) = num5;
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
