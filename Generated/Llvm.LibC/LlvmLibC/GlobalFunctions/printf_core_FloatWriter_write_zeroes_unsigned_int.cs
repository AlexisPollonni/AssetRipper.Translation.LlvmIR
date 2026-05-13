using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core11FloatWriter12write_zeroesEj")]
[DemangledName("__llvm_libc_20_1_2_::printf_core::FloatWriter::write_zeroes(unsigned int)")]
internal static partial class printf_core_FloatWriter_write_zeroes_unsigned_int
{
	public unsafe static int Invoke(printf_core_FloatWriter* @this, int num_zeroes)
	{
		int result = 0;
		int num = 0;
		int num2 = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = printf_core_FloatWriter_flush_buffer_bool.Invoke(@this, round_up_max_blocks: false);
		int num3;
		if (num < 0)
		{
			result = num;
			num3 = 1;
		}
		else
		{
			num3 = 0;
		}
		llvm_lifetime_end_p0.Invoke(4L, &num);
		switch (num3)
		{
		case 0:
			llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = printf_core_Writer_write_char_unsigned_long.Invoke(@this->writer, 48, unchecked((uint)num_zeroes));
			if (num2 < 0)
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
				result = 0;
				break;
			case 1:
				break;
			default:
				goto end_IL_004a;
			}
			goto case 1;
		case 1:
			{
				return result;
			}
			end_IL_004a:
			break;
		}
		throw new NotImplementedException("Reached LLVM unreachable instruction.");
	}
}
