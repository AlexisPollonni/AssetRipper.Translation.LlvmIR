using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Multiword_inplace_binop_unsigned_int_unsigned_int_unsigned_int_unsigned_int_unsigned_int_unsigned_int_1ul_1ul
{
	[MangledName("_ZN19__llvm_libc_20_1_2_9multiword13inplace_binopIPFjjjjRjEjLm1ELm1EEET0_T_RNS_3cpp5arrayIS5_XT1_EEERKNS8_IS5_XT2_EEE")]
	[DemangledName("unsigned int __llvm_libc_20_1_2_::multiword::inplace_binop<unsigned int (*)(unsigned int, unsigned int, unsigned int, unsigned int&), unsigned int, 1ul, 1ul>(unsigned int (*)(unsigned int, unsigned int, unsigned int, unsigned int&), __llvm_libc_20_1_2_::cpp::array<unsigned int, 1ul>&, __llvm_libc_20_1_2_::cpp::array<unsigned int, 1ul> const&)")]
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke([MangledName("op_with_carry")][NativeType("unsigned int (*)(unsigned int, unsigned int, unsigned int, unsigned int&)")] void* Op_with_carry, [MangledName("dst")][NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned int, 1ul>&")] Llvm_libc_20_1_2_cpp_array_2v7m9i* Dst, [MangledName("rhs")][NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned int, 1ul> const&")] Llvm_libc_20_1_2_cpp_array_2v7m9i* Rhs)
	{
		int num = 0;
		long num2 = 0L;
		sbyte b = 0;
		int num3 = 0;
		int num4 = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 0;
		Llvm_lifetime_start_p0.Invoke(8L, &num2);
		unchecked
		{
			for (num2 = 0L; (ulong)num2 < 1uL; num2++)
			{
				Llvm_lifetime_start_p0.Invoke(1L, &b);
				b = (((ulong)num2 < 1uL) ? ((sbyte)1) : ((sbyte)0));
				Llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = (((b & 1) == 1) ? (*(int*)Array_unsigned_int_1ul_Index_9mw8rm.Invoke(Rhs, num2)) : 0);
				Llvm_lifetime_start_p0.Invoke(4L, &num4);
				num4 = num;
				int num5 = ((delegate*<int, int, int, int*, int>)Op_with_carry)(*(int*)Array_unsigned_int_1ul_Index_ejbtjs.Invoke(Dst, num2), num3, num4, &num);
				*(int*)Array_unsigned_int_1ul_Index_ejbtjs.Invoke(Dst, num2) = num5;
				int num6 = (((b & 1) != 1 && num == 0) ? 2 : 0);
				Llvm_lifetime_end_p0.Invoke(4L, &num4);
				Llvm_lifetime_end_p0.Invoke(4L, &num3);
				Llvm_lifetime_end_p0.Invoke(1L, &b);
				switch (num6)
				{
				case 0:
					continue;
				}
				break;
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num2);
			int result = num;
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
