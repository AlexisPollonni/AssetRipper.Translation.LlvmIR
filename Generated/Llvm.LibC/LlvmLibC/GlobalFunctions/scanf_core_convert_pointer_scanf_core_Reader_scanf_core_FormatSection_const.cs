using System;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_10scanf_core15convert_pointerEPNS0_6ReaderERKNS0_13FormatSectionE")]
[DemangledName("__llvm_libc_20_1_2_::scanf_core::convert_pointer(__llvm_libc_20_1_2_::scanf_core::Reader*, __llvm_libc_20_1_2_::scanf_core::FormatSection const&)")]
internal static partial class scanf_core_convert_pointer_scanf_core_Reader_scanf_core_FormatSection_const
{
	public unsafe static int Invoke(void* reader, void* to_conv)
	{
		sbyte b = 0;
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(1L, &b);
		b = scanf_core_Reader_getc.Invoke(reader);
		llvm_lifetime_start_p0.Invoke(8L, &num);
		unchecked
		{
			for (num = 0L; (ulong)num < 9uL; num++)
			{
				int num2 = internal_tolower_int_117.Invoke(b);
				long num3 = num;
				if (num2 != ((sbyte*)scanf_core_convert_pointer_scanf_core_Reader_scanf_core_FormatSection_const_nullptr_string.Pointer)[num3])
				{
					break;
				}
				b = scanf_core_Reader_getc.Invoke(reader);
			}
			int result;
			switch (num)
			{
			case 9L:
				*(IntPtr*)((scanf_core_FormatSection*)to_conv)->output_ptr = (nint)0;
				result = 0;
				break;
			default:
				result = -3;
				break;
			case 0L:
				scanf_core_Reader_ungetc_char.Invoke(reader, b);
				result = scanf_core_convert_int_scanf_core_Reader_scanf_core_FormatSection_const.Invoke(reader, to_conv);
				break;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
			llvm_lifetime_end_p0.Invoke(1L, &b);
			return result;
		}
	}
}
