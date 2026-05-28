using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class PaddingWriter_write_left_padding
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core13PaddingWriter18write_left_paddingEPNS0_6WriterEm")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::PaddingWriter::write_left_padding(__llvm_libc_20_1_2_::printf_core::Writer*, unsigned long)")]
	public unsafe static int Invoke([MangledName("this")] Printf_core_PaddingWriter* This, [MangledName("writer")][NativeType("__llvm_libc_20_1_2_::printf_core::Writer*")] Printf_core_Writer* Writer, [MangledName("total_digits")][NativeType("unsigned long")] long Total_digits)
	{
		int result = 0;
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = unchecked((int)(This->Min_width - Total_digits - InstructionHelper.Select(This->Sign_char > 0, 1, 0)));
		if ((This->Left_justified & 1) == 1 || num < 0)
		{
			if (This->Sign_char > 0)
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num2);
				num2 = Writer_write.Invoke(Writer, This->Sign_char);
				int num6;
				if (num2 < 0)
				{
					result = num2;
					num6 = 1;
				}
				else
				{
					num6 = 0;
				}
				Llvm_lifetime_end_p0.Invoke(4L, &num2);
				switch (num6)
				{
				case 0:
					break;
				default:
					goto IL_0205;
				}
			}
			result = 0;
		}
		else
		{
			if ((This->Leading_zeroes & 1) != 1)
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = Writer_write.Invoke(Writer, 32, num);
				int num6;
				if (num3 < 0)
				{
					result = num3;
					num6 = 1;
				}
				else
				{
					num6 = 0;
				}
				Llvm_lifetime_end_p0.Invoke(4L, &num3);
				switch (num6)
				{
				case 0:
					break;
				default:
					goto IL_0205;
				}
			}
			if (This->Sign_char > 0)
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num4);
				num4 = Writer_write.Invoke(Writer, This->Sign_char);
				int num6;
				if (num4 < 0)
				{
					result = num4;
					num6 = 1;
				}
				else
				{
					num6 = 0;
				}
				Llvm_lifetime_end_p0.Invoke(4L, &num4);
				switch (num6)
				{
				case 0:
					break;
				default:
					goto IL_0205;
				}
			}
			if ((This->Leading_zeroes & 1) == 1)
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num5);
				num5 = Writer_write.Invoke(Writer, 48, num);
				int num6;
				if (num5 < 0)
				{
					result = num5;
					num6 = 1;
				}
				else
				{
					num6 = 0;
				}
				Llvm_lifetime_end_p0.Invoke(4L, &num5);
				switch (num6)
				{
				case 0:
					break;
				default:
					goto IL_0205;
				}
			}
			result = 0;
		}
		goto IL_0205;
		IL_0205:
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
