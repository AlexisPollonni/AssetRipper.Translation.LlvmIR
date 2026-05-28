using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Multiword_countl_zero_unsigned_long_258ul
{
	[MangledName("_ZN19__llvm_libc_20_1_2_9multiword11countl_zeroImLm258EEEiRKNS_3cpp5arrayIT_XT0_EEE")]
	[DemangledName("int __llvm_libc_20_1_2_::multiword::countl_zero<unsigned long, 258ul>(__llvm_libc_20_1_2_::cpp::array<unsigned long, 258ul> const&)")]
	[return: NativeType("int")]
	public unsafe static int Invoke([MangledName("val")][NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned long, 258ul> const&")] Cpp_array_anzbtp* Val)
	{
		int num = 0;
		long num2 = 0L;
		int num3 = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 0;
		Llvm_lifetime_start_p0.Invoke(8L, &num2);
		unchecked
		{
			for (num2 = 0L; (ulong)num2 < 258uL; num2++)
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = Cpp_countl_zero_unsigned_long.Invoke(*(long*)Array_unsigned_long_258ul_Index_7gdq4k.Invoke(Val, 258L - num2 - 1L));
				num = checked(num + num3);
				int num4 = ((num3 != 64) ? 2 : 0);
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
