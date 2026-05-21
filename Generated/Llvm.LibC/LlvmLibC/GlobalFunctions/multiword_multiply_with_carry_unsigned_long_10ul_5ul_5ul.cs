using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class multiword_multiply_with_carry_unsigned_long_10ul_5ul_5ul
{
	[MangledName("_ZN19__llvm_libc_20_1_2_9multiword19multiply_with_carryImLm10ELm5ELm5EEET_RNS_3cpp5arrayIS2_XT0_EEERKNS4_IS2_XT1_EEERKNS4_IS2_XT2_EEE")]
	[DemangledName("unsigned long __llvm_libc_20_1_2_::multiword::multiply_with_carry<unsigned long, 10ul, 5ul, 5ul>(__llvm_libc_20_1_2_::cpp::array<unsigned long, 10ul>&, __llvm_libc_20_1_2_::cpp::array<unsigned long, 5ul> const&, __llvm_libc_20_1_2_::cpp::array<unsigned long, 5ul> const&)")]
	[return: NativeType("unsigned long")]
	public unsafe static long Invoke([NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned long, 10ul>&")] cpp_array_f7mn55* dst, [NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned long, 5ul> const&")] cpp_array_msasyg* lhs, [NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned long, 5ul> const&")] cpp_array_msasyg* rhs)
	{
		BigInt_qdkjbh bigInt_qdkjbh = default(BigInt_qdkjbh);
		long num = 0L;
		long num2 = 0L;
		long num3 = 0L;
		long num4 = 0L;
		long num5 = 0L;
		llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh);
		unchecked
		{
			sbyte* ptr = (sbyte*)(&bigInt_qdkjbh);
			*(long*)ptr = -6148914691236517206L;
			((long*)ptr)[1] = -6148914691236517206L;
			Accumulator_unsigned_long_Constructor.Invoke(&bigInt_qdkjbh);
			llvm_lifetime_start_p0.Invoke(8L, &num);
			for (num = 0L; (ulong)num < 10uL; num++)
			{
				llvm_lifetime_start_p0.Invoke(8L, &num2);
				num2 = (((ulong)num >= 5uL) ? (num - 5L + 1L) : 0L);
				llvm_lifetime_start_p0.Invoke(8L, &num3);
				num3 = (((ulong)num >= 5uL) ? 4L : num);
				llvm_lifetime_start_p0.Invoke(8L, &num4);
				num4 = 0L;
				llvm_lifetime_start_p0.Invoke(8L, &num5);
				for (num5 = num2; (ulong)num5 <= (ulong)num3; num5++)
				{
					long num6 = multiword_mul_add_with_carry_unsigned_long_2ul.Invoke((cpp_array_i3937k*)(&bigInt_qdkjbh), *(long*)array_unsigned_long_5ul_Index_wxken3.Invoke(lhs, num5), *(long*)array_unsigned_long_5ul_Index_wxken3.Invoke(rhs, num - num5));
					num4 += num6;
				}
				llvm_lifetime_end_p0.Invoke(8L, &num5);
				long num7 = Accumulator_unsigned_long_advance.Invoke(&bigInt_qdkjbh, num4);
				*(long*)array_unsigned_long_10ul_Index_nyet86.Invoke(dst, num) = num7;
				llvm_lifetime_end_p0.Invoke(8L, &num4);
				llvm_lifetime_end_p0.Invoke(8L, &num3);
				llvm_lifetime_end_p0.Invoke(8L, &num2);
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
			long result = Accumulator_unsigned_long_carry.Invoke(&bigInt_qdkjbh);
			llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh);
			return result;
		}
	}
}
