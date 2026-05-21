using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class PaddingWriter_write_right_padding
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core13PaddingWriter19write_right_paddingEPNS0_6WriterEm")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::PaddingWriter::write_right_padding(__llvm_libc_20_1_2_::printf_core::Writer*, unsigned long)")]
	public unsafe static int Invoke([MangledName("this")] Llvm_libc_20_1_2_printf_core_PaddingWriter* This, [MangledName("writer")][NativeType("__llvm_libc_20_1_2_::printf_core::Writer*")] Llvm_libc_20_1_2_printf_core_Writer* Writer, [MangledName("total_digits")][NativeType("unsigned long")] long Total_digits)
	{
		int result = 0;
		int num = 0;
		int num2 = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = unchecked((int)(This->Min_width - Total_digits - InstructionHelper.Select(This->Sign_char > 0, 1, 0)));
		if ((This->Left_justified & 1) == 1 && num > 0)
		{
			Llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = Writer_write.Invoke(Writer, 32, num);
			int num3;
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
				break;
			default:
				goto IL_00b8;
			}
		}
		result = 0;
		goto IL_00b8;
		IL_00b8:
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
