using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_10scanf_core21write_int_with_lengthEmRKNS0_13FormatSectionE")]
[DemangledName("__llvm_libc_20_1_2_::scanf_core::write_int_with_length(unsigned long, __llvm_libc_20_1_2_::scanf_core::FormatSection const&)")]
internal static partial class scanf_core_write_int_with_length_unsigned_long_scanf_core_FormatSection_const
{
	public unsafe static void Invoke(long output_val, scanf_core_FormatSection* to_conv)
	{
		void* ptr = null;
		int num = 0;
		unchecked
		{
			if (((byte)to_conv->flags & 1) != 0)
			{
				return;
			}
			llvm_lifetime_start_p0.Invoke(8L, &ptr);
			ptr = to_conv->output_ptr;
			int num2;
			if (to_conv->conv_name == 112)
			{
				*(IntPtr*)ptr = (nint)output_val;
				num2 = 1;
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(4L, &num);
				num = (int)to_conv->length_modifier;
				switch (num)
				{
				case 0:
					*(sbyte*)ptr = (sbyte)output_val;
					break;
				case 1:
					*(short*)ptr = (short)output_val;
					break;
				case 8:
					*(int*)ptr = (int)output_val;
					break;
				case 2:
					*(long*)ptr = output_val;
					break;
				case 3:
				case 7:
					*(long*)ptr = output_val;
					break;
				case 4:
					*(long*)ptr = output_val;
					break;
				case 5:
					*(long*)ptr = output_val;
					break;
				case 6:
					*(long*)ptr = output_val;
					break;
				}
				llvm_lifetime_end_p0.Invoke(4L, &num);
				num2 = 0;
			}
			llvm_lifetime_end_p0.Invoke(8L, &ptr);
			switch (num2)
			{
			case 0:
			case 1:
				return;
			}
			throw new NotImplementedException("Reached LLVM unreachable instruction.");
		}
	}
}
