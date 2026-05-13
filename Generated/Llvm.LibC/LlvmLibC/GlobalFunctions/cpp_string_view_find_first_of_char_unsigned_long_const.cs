using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp11string_view13find_first_ofEcm")]
[DemangledName("__llvm_libc_20_1_2_::cpp::string_view::find_first_of(char, unsigned long) const")]
internal static partial class cpp_string_view_find_first_of_char_unsigned_long_const
{
	public unsafe static long Invoke(void* @this, sbyte c, long From)
	{
		long result = 0L;
		long num = 0L;
		sbyte b = c;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = From;
		unchecked
		{
			int num2;
			while (true)
			{
				if ((ulong)num >= (ulong)cpp_string_view_size_const.Invoke(@this))
				{
					num2 = 2;
					break;
				}
				if (*(sbyte*)cpp_string_view_operator_unsigned_long_const.Invoke(@this, num) == b)
				{
					result = num;
					num2 = 1;
					break;
				}
				num++;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
			int num3 = num2;
			if (num3 != 2)
			{
				if (num3 != 1)
				{
					throw new NotImplementedException("Reached LLVM unreachable instruction.");
				}
			}
			else
			{
				result = -1L;
			}
			return result;
		}
	}
}
