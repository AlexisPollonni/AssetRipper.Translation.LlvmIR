using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_10scanf_core9raw_matchEPNS0_6ReaderENS_3cpp11string_viewE")]
[DemangledName("__llvm_libc_20_1_2_::scanf_core::raw_match(__llvm_libc_20_1_2_::scanf_core::Reader*, __llvm_libc_20_1_2_::cpp::string_view)")]
internal static partial class scanf_core_raw_match_scanf_core_Reader_cpp_string_view
{
	public unsafe static int Invoke(void* reader, [MangledName("raw_string.coerce0")] void* raw_string, [MangledName("raw_string.coerce1")] long cur_char)
	{
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		sbyte b = 0;
		int num = 0;
		long num2 = 0L;
		unchecked
		{
			*(void**)(&cpp_string_view2) = raw_string;
			((long*)(&cpp_string_view2))[1] = cur_char;
			llvm_lifetime_start_p0.Invoke(1L, &b);
			b = scanf_core_Reader_getc.Invoke(reader);
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = 0;
			llvm_lifetime_start_p0.Invoke(8L, &num2);
			for (num2 = 0L; (ulong)num2 < (ulong)cpp_string_view_size_const.Invoke(&cpp_string_view2); num2++)
			{
				if (internal_isspace_int_146.Invoke(*(sbyte*)cpp_string_view_operator_unsigned_long_const.Invoke(&cpp_string_view2, num2)))
				{
					while (internal_isspace_int_146.Invoke(b))
					{
						b = scanf_core_Reader_getc.Invoke(reader);
					}
					continue;
				}
				if (*(sbyte*)cpp_string_view_operator_unsigned_long_const.Invoke(&cpp_string_view2, num2) == b)
				{
					b = scanf_core_Reader_getc.Invoke(reader);
					continue;
				}
				num = -3;
				break;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			scanf_core_Reader_ungetc_char.Invoke(reader, b);
			int result = num;
			llvm_lifetime_end_p0.Invoke(4L, &num);
			llvm_lifetime_end_p0.Invoke(1L, &b);
			return result;
		}
	}
}
