using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_9multiword11countl_zeroImLm258EEEiRKNS_3cpp5arrayIT_XT0_EEE")]
[DemangledName("int __llvm_libc_20_1_2_::multiword::countl_zero<unsigned long, 258ul>(__llvm_libc_20_1_2_::cpp::array<unsigned long, 258ul> const&)")]
internal static partial class int_multiword_countl_zero_unsigned_long_258ul_cpp_array_unsigned_long_258ul_const
{
	public unsafe static int Invoke(cpp_array_vnnqx8* val)
	{
		int num = 0;
		long num2 = 0L;
		int num3 = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 0;
		llvm_lifetime_start_p0.Invoke(8L, &num2);
		unchecked
		{
			for (num2 = 0L; (ulong)num2 < 258uL; num2++)
			{
				llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = cpp_enable_if_cpp_is_unsigned_v_unsigned_long_int_type_cpp_countl_zero_unsigned_long_unsigned_long.Invoke(*(long*)cpp_array_unsigned_long_258ul_operator_unsigned_long_const.Invoke(val, 258L - num2 - 1L));
				num = checked(num + num3);
				int num4 = ((num3 != 64) ? 2 : 0);
				llvm_lifetime_end_p0.Invoke(4L, &num3);
				switch (num4)
				{
				case 0:
					continue;
				}
				break;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			int result = num;
			llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
