using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Scanf_core_convert_pointer
{
	[MangledName("_ZN19__llvm_libc_20_1_2_10scanf_core15convert_pointerEPNS0_6ReaderERKNS0_13FormatSectionE")]
	[DemangledName("__llvm_libc_20_1_2_::scanf_core::convert_pointer(__llvm_libc_20_1_2_::scanf_core::Reader*, __llvm_libc_20_1_2_::scanf_core::FormatSection const&)")]
	public unsafe static int Invoke([MangledName("reader")][NativeType("__llvm_libc_20_1_2_::scanf_core::Reader*")] Llvm_libc_20_1_2_scanf_core_Reader* Reader, [MangledName("to_conv")][NativeType("__llvm_libc_20_1_2_::scanf_core::FormatSection const&")] Llvm_libc_20_1_2_scanf_core_FormatSection* To_conv)
	{
		sbyte b = 0;
		long num = 0L;
		Llvm_lifetime_start_p0.Invoke(1L, &b);
		b = Reader_getc.Invoke(Reader);
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		unchecked
		{
			for (num = 0L; (ulong)num < 9uL; num++)
			{
				int num2 = Internal_tolower_ec4z38.Invoke(b);
				long num3 = num;
				if (num2 != ((sbyte*)Llvm_libc_20_1_2_scanf_core_convert_pointer_scanf_core_Reader_scanf_core_FormatSection_const_nullptr_string.Pointer)[num3])
				{
					break;
				}
				b = Reader_getc.Invoke(Reader);
			}
			int result;
			switch (num)
			{
			case 9L:
				*(IntPtr*)To_conv->Output_ptr = (nint)0;
				result = 0;
				break;
			default:
				result = -3;
				break;
			case 0L:
				Reader_ungetc.Invoke(Reader, b);
				result = Scanf_core_convert_int.Invoke(Reader, To_conv);
				break;
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			Llvm_lifetime_end_p0.Invoke(1L, &b);
			return result;
		}
	}
}
