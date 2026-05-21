using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Multiword_inplace_binop_unsigned_long_unsigned_long_unsigned_long_unsigned_long_unsigned_long_unsigned_long_1ul_1ul
{
	[MangledName("_ZN19__llvm_libc_20_1_2_9multiword13inplace_binopIPFmmmmRmEmLm1ELm1EEET0_T_RNS_3cpp5arrayIS5_XT1_EEERKNS8_IS5_XT2_EEE")]
	[DemangledName("unsigned long __llvm_libc_20_1_2_::multiword::inplace_binop<unsigned long (*)(unsigned long, unsigned long, unsigned long, unsigned long&), unsigned long, 1ul, 1ul>(unsigned long (*)(unsigned long, unsigned long, unsigned long, unsigned long&), __llvm_libc_20_1_2_::cpp::array<unsigned long, 1ul>&, __llvm_libc_20_1_2_::cpp::array<unsigned long, 1ul> const&)")]
	[return: NativeType("unsigned long")]
	public unsafe static long Invoke([MangledName("op_with_carry")][NativeType("unsigned long (*)(unsigned long, unsigned long, unsigned long, unsigned long&)")] void* Op_with_carry, [MangledName("dst")][NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned long, 1ul>&")] Llvm_libc_20_1_2_cpp_array_rpgxvv* Dst, [MangledName("rhs")][NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned long, 1ul> const&")] Llvm_libc_20_1_2_cpp_array_rpgxvv* Rhs)
	{
		long num = 0L;
		long num2 = 0L;
		sbyte b = 0;
		long num3 = 0L;
		long num4 = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &num2);
		unchecked
		{
			for (num2 = 0L; (ulong)num2 < 1uL; num2++)
			{
				Llvm_lifetime_start_p0.Invoke(1L, &b);
				b = (((ulong)num2 < 1uL) ? ((sbyte)1) : ((sbyte)0));
				Llvm_lifetime_start_p0.Invoke(8L, &num3);
				num3 = (((b & 1) != 1) ? 0L : (*(long*)Array_unsigned_long_1ul_Index_fk3nam.Invoke(Rhs, num2)));
				Llvm_lifetime_start_p0.Invoke(8L, &num4);
				num4 = num;
				long num5 = ((delegate*<long, long, long, long*, long>)Op_with_carry)(*(long*)Array_unsigned_long_1ul_Index_3erz3i.Invoke(Dst, num2), num3, num4, &num);
				*(long*)Array_unsigned_long_1ul_Index_3erz3i.Invoke(Dst, num2) = num5;
				int num6 = (((b & 1) != 1 && num == 0L) ? 2 : 0);
				Llvm_lifetime_end_p0.Invoke(8L, &num4);
				Llvm_lifetime_end_p0.Invoke(8L, &num3);
				Llvm_lifetime_end_p0.Invoke(1L, &b);
				switch (num6)
				{
				case 0:
					continue;
				}
				break;
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num2);
			long result = num;
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
