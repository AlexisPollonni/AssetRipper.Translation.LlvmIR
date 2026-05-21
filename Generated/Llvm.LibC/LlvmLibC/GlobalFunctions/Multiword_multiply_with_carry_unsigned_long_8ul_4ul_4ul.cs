using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Multiword_multiply_with_carry_unsigned_long_8ul_4ul_4ul
{
	[MangledName("_ZN19__llvm_libc_20_1_2_9multiword19multiply_with_carryImLm8ELm4ELm4EEET_RNS_3cpp5arrayIS2_XT0_EEERKNS4_IS2_XT1_EEERKNS4_IS2_XT2_EEE")]
	[DemangledName("unsigned long __llvm_libc_20_1_2_::multiword::multiply_with_carry<unsigned long, 8ul, 4ul, 4ul>(__llvm_libc_20_1_2_::cpp::array<unsigned long, 8ul>&, __llvm_libc_20_1_2_::cpp::array<unsigned long, 4ul> const&, __llvm_libc_20_1_2_::cpp::array<unsigned long, 4ul> const&)")]
	[return: NativeType("unsigned long")]
	public unsafe static long Invoke([MangledName("dst")][NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned long, 8ul>&")] Llvm_libc_20_1_2_cpp_array_uibb79* Dst, [MangledName("lhs")][NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned long, 4ul> const&")] Llvm_libc_20_1_2_cpp_array_jgy3xh* Lhs, [MangledName("rhs")][NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned long, 4ul> const&")] Llvm_libc_20_1_2_cpp_array_jgy3xh* Rhs)
	{
		Llvm_libc_20_1_2_BigInt_qdkjbh llvm_libc_20_1_2_BigInt_qdkjbh = default(Llvm_libc_20_1_2_BigInt_qdkjbh);
		long num = 0L;
		long num2 = 0L;
		long num3 = 0L;
		long num4 = 0L;
		long num5 = 0L;
		Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh);
		unchecked
		{
			sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_BigInt_qdkjbh);
			*(long*)ptr = -6148914691236517206L;
			((long*)ptr)[1] = -6148914691236517206L;
			Accumulator_unsigned_long_Constructor.Invoke(&llvm_libc_20_1_2_BigInt_qdkjbh);
			Llvm_lifetime_start_p0.Invoke(8L, &num);
			for (num = 0L; (ulong)num < 8uL; num++)
			{
				Llvm_lifetime_start_p0.Invoke(8L, &num2);
				num2 = (((ulong)num >= 4uL) ? (num - 4L + 1L) : 0L);
				Llvm_lifetime_start_p0.Invoke(8L, &num3);
				num3 = (((ulong)num >= 4uL) ? 3L : num);
				Llvm_lifetime_start_p0.Invoke(8L, &num4);
				num4 = 0L;
				Llvm_lifetime_start_p0.Invoke(8L, &num5);
				for (num5 = num2; (ulong)num5 <= (ulong)num3; num5++)
				{
					long num6 = Multiword_mul_add_with_carry_unsigned_long_2ul.Invoke((Llvm_libc_20_1_2_cpp_array_i3937k*)(&llvm_libc_20_1_2_BigInt_qdkjbh), *(long*)Array_unsigned_long_4ul_Index_pwcpnu.Invoke(Lhs, num5), *(long*)Array_unsigned_long_4ul_Index_pwcpnu.Invoke(Rhs, num - num5));
					num4 += num6;
				}
				Llvm_lifetime_end_p0.Invoke(8L, &num5);
				long num7 = Accumulator_unsigned_long_advance.Invoke(&llvm_libc_20_1_2_BigInt_qdkjbh, num4);
				*(long*)Array_unsigned_long_8ul_Index_vpzmfd.Invoke(Dst, num) = num7;
				Llvm_lifetime_end_p0.Invoke(8L, &num4);
				Llvm_lifetime_end_p0.Invoke(8L, &num3);
				Llvm_lifetime_end_p0.Invoke(8L, &num2);
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			long result = Accumulator_unsigned_long_carry.Invoke(&llvm_libc_20_1_2_BigInt_qdkjbh);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh);
			return result;
		}
	}
}
