using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class String_view_find_first_not_of
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp11string_view17find_first_not_ofEcm")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::string_view::find_first_not_of(char, unsigned long) const")]
	public unsafe static long Invoke([MangledName("this")] void* This, [MangledName("c")][NativeType("char")] sbyte C, [NativeType("unsigned long")] long From)
	{
		long result = 0L;
		long num = 0L;
		sbyte b = C;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = From;
		unchecked
		{
			int num2;
			while (true)
			{
				if ((ulong)num >= (ulong)String_view_size.Invoke(This))
				{
					num2 = 2;
					break;
				}
				if (*(sbyte*)String_view_Index.Invoke(This, num) != b)
				{
					result = num;
					num2 = 1;
					break;
				}
				num++;
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num);
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
