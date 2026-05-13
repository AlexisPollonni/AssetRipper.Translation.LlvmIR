using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp11string_view13compareMemoryEPKcS3_m")]
[DemangledName("__llvm_libc_20_1_2_::cpp::string_view::compareMemory(char const*, char const*, unsigned long)")]
internal static partial class cpp_string_view_compareMemory_char_const_char_const_unsigned_long
{
	public unsafe static int Invoke(void* Lhs, void* Rhs, long Length)
	{
		int result = 0;
		long num = 0L;
		int num2 = 0;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = 0L;
		int num3;
		while (true)
		{
			if (unchecked((ulong)num >= (ulong)Length))
			{
				num3 = 2;
				break;
			}
			llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = unchecked((sbyte*)Lhs)[num] - unchecked((sbyte*)Rhs)[num];
			if (num2 != 0)
			{
				result = num2;
				num3 = 1;
			}
			else
			{
				num3 = 0;
			}
			llvm_lifetime_end_p0.Invoke(4L, &num2);
			switch (num3)
			{
			case 0:
				goto IL_0087;
			}
			break;
			IL_0087:
			num = unchecked(num + 1L);
		}
		llvm_lifetime_end_p0.Invoke(8L, &num);
		int num4 = num3;
		if (num4 != 2)
		{
			if (num4 != 1)
			{
				throw new NotImplementedException("Reached LLVM unreachable instruction.");
			}
		}
		else
		{
			result = 0;
		}
		return result;
	}
}
