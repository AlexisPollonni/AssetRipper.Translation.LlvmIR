using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class scanf_core_raw_match
{
	[MangledName("_ZN19__llvm_libc_20_1_2_10scanf_core9raw_matchEPNS0_6ReaderENS_3cpp11string_viewE")]
	[DemangledName("__llvm_libc_20_1_2_::scanf_core::raw_match(__llvm_libc_20_1_2_::scanf_core::Reader*, __llvm_libc_20_1_2_::cpp::string_view)")]
	public unsafe static int Invoke(scanf_core_Reader* reader, [MangledName("raw_string.coerce0")][NativeType("__llvm_libc_20_1_2_::scanf_core::Reader*")] void* raw_string, [MangledName("raw_string.coerce1")][NativeType("__llvm_libc_20_1_2_::cpp::string_view")] long cur_char)
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
			b = Reader_getc.Invoke(reader);
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = 0;
			llvm_lifetime_start_p0.Invoke(8L, &num2);
			for (num2 = 0L; (ulong)num2 < (ulong)string_view_size.Invoke(&cpp_string_view2); num2++)
			{
				if (internal_isspace_mng365.Invoke(*(sbyte*)string_view_Index.Invoke(&cpp_string_view2, num2)))
				{
					while (internal_isspace_mng365.Invoke(b))
					{
						b = Reader_getc.Invoke(reader);
					}
					continue;
				}
				if (*(sbyte*)string_view_Index.Invoke(&cpp_string_view2, num2) == b)
				{
					b = Reader_getc.Invoke(reader);
					continue;
				}
				num = -3;
				break;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			Reader_ungetc.Invoke(reader, b);
			int result = num;
			llvm_lifetime_end_p0.Invoke(4L, &num);
			llvm_lifetime_end_p0.Invoke(1L, &b);
			return result;
		}
	}
}
