using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FloatWriter_write_zeroes
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core11FloatWriter12write_zeroesEj")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::FloatWriter::write_zeroes(unsigned int)")]
	public unsafe static int Invoke([MangledName("this")] Printf_core_FloatWriter* This, [MangledName("num_zeroes")][NativeType("unsigned int")] int Num_zeroes)
	{
		int result = 0;
		int num = 0;
		int num2 = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = FloatWriter_flush_buffer.Invoke(This, Round_up_max_blocks: false);
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
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		switch (num3)
		{
		case 0:
			Llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = Writer_write.Invoke(This->Writer, 48, unchecked((uint)Num_zeroes));
			if (num2 < 0)
			{
				result = num2;
				num3 = 1;
			}
			else
			{
				num3 = 0;
			}
			Llvm_lifetime_end_p0.Invoke(4L, &num2);
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
