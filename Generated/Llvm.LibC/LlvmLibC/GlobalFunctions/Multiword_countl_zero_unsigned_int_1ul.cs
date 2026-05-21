using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Multiword_countl_zero_unsigned_int_1ul
{
	[MangledName("_ZN19__llvm_libc_20_1_2_9multiword11countl_zeroIjLm1EEEiRKNS_3cpp5arrayIT_XT0_EEE")]
	[DemangledName("int __llvm_libc_20_1_2_::multiword::countl_zero<unsigned int, 1ul>(__llvm_libc_20_1_2_::cpp::array<unsigned int, 1ul> const&)")]
	[return: NativeType("int")]
	public unsafe static int Invoke([MangledName("val")][NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned int, 1ul> const&")] Llvm_libc_20_1_2_cpp_array_2v7m9i* Val)
	{
		int num = 0;
		long num2 = 0L;
		int num3 = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 0;
		Llvm_lifetime_start_p0.Invoke(8L, &num2);
		unchecked
		{
			for (num2 = 0L; (ulong)num2 < 1uL; num2++)
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = Cpp_countl_zero_unsigned_int.Invoke(*(int*)Array_unsigned_int_1ul_Index_9mw8rm.Invoke(Val, 1L - num2 - 1L));
				num = checked(num + num3);
				int num4 = ((num3 != 32) ? 2 : 0);
				Llvm_lifetime_end_p0.Invoke(4L, &num3);
				switch (num4)
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
