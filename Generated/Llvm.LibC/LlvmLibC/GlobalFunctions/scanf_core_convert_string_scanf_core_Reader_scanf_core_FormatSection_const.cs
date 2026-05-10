using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_10scanf_core14convert_stringEPNS0_6ReaderERKNS0_13FormatSectionE")]
[DemangledName("__llvm_libc_20_1_2_::scanf_core::convert_string(__llvm_libc_20_1_2_::scanf_core::Reader*, __llvm_libc_20_1_2_::scanf_core::FormatSection const&)")]
internal static partial class scanf_core_convert_string_scanf_core_Reader_scanf_core_FormatSection_const
{
	public unsafe static int Invoke(void* reader, void* to_conv)
	{
		long num = 0L;
		void* ptr = null;
		sbyte b = 0;
		long num2 = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = 0L;
		unchecked
		{
			num = ((((scanf_core_FormatSection*)to_conv)->max_width <= 0) ? ((((scanf_core_FormatSection*)to_conv)->conv_name != 99) ? cpp_internal_integer_impl_unsigned_long_0ul_18446744073709551615ul_max.Invoke() : 1L) : ((scanf_core_FormatSection*)to_conv)->max_width);
			llvm_lifetime_start_p0.Invoke(8L, &ptr);
			ptr = ((scanf_core_FormatSection*)to_conv)->output_ptr;
			llvm_lifetime_start_p0.Invoke(1L, &b);
			b = scanf_core_Reader_getc.Invoke(reader);
			llvm_lifetime_start_p0.Invoke(8L, &num2);
			for (num2 = 0L; (ulong)num2 < (ulong)num; num2++)
			{
				if (b == 0)
				{
					break;
				}
				if (((scanf_core_FormatSection*)to_conv)->conv_name == 115 && internal_isspace_int_134.Invoke(b))
				{
					break;
				}
				if (((scanf_core_FormatSection*)to_conv)->conv_name == 91 && !cpp_bitset_256ul_test_unsigned_long_const.Invoke(&((scanf_core_FormatSection*)to_conv)->scan_set, b))
				{
					break;
				}
				if (((byte)((scanf_core_FormatSection*)to_conv)->flags & 1) == 0)
				{
					((sbyte*)ptr)[num2] = b;
				}
				b = scanf_core_Reader_getc.Invoke(reader);
			}
			scanf_core_Reader_ungetc_char.Invoke(reader, b);
			if (((scanf_core_FormatSection*)to_conv)->conv_name != 99 && ((byte)((scanf_core_FormatSection*)to_conv)->flags & 1) == 0)
			{
				((sbyte*)ptr)[num2] = 0;
			}
			int result = ((num2 == 0L) ? (-3) : 0);
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			llvm_lifetime_end_p0.Invoke(1L, &b);
			llvm_lifetime_end_p0.Invoke(8L, &ptr);
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
