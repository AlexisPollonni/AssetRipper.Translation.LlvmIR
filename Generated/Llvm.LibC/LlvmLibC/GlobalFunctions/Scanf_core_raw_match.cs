using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Scanf_core_raw_match
{
	[MangledName("_ZN19__llvm_libc_20_1_2_10scanf_core9raw_matchEPNS0_6ReaderENS_3cpp11string_viewE")]
	[DemangledName("__llvm_libc_20_1_2_::scanf_core::raw_match(__llvm_libc_20_1_2_::scanf_core::Reader*, __llvm_libc_20_1_2_::cpp::string_view)")]
	public unsafe static int Invoke([MangledName("reader")] Llvm_libc_20_1_2_scanf_core_Reader* Reader, [MangledName("raw_string.coerce0")][NativeType("__llvm_libc_20_1_2_::scanf_core::Reader*")] void* Raw_string, [MangledName("raw_string.coerce1")][NativeType("__llvm_libc_20_1_2_::cpp::string_view")] long Cur_char)
	{
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view = default(Llvm_libc_20_1_2_cpp_string_view);
		sbyte b = 0;
		int num = 0;
		long num2 = 0L;
		unchecked
		{
			*(void**)(&llvm_libc_20_1_2_cpp_string_view) = Raw_string;
			((long*)(&llvm_libc_20_1_2_cpp_string_view))[1] = Cur_char;
			Llvm_lifetime_start_p0.Invoke(1L, &b);
			b = Reader_getc.Invoke(Reader);
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = 0;
			Llvm_lifetime_start_p0.Invoke(8L, &num2);
			for (num2 = 0L; (ulong)num2 < (ulong)String_view_size.Invoke(&llvm_libc_20_1_2_cpp_string_view); num2++)
			{
				if (Internal_isspace_mng365.Invoke(*(sbyte*)String_view_Index.Invoke(&llvm_libc_20_1_2_cpp_string_view, num2)))
				{
					while (Internal_isspace_mng365.Invoke(b))
					{
						b = Reader_getc.Invoke(Reader);
					}
					continue;
				}
				if (*(sbyte*)String_view_Index.Invoke(&llvm_libc_20_1_2_cpp_string_view, num2) == b)
				{
					b = Reader_getc.Invoke(Reader);
					continue;
				}
				num = -3;
				break;
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num2);
			Reader_ungetc.Invoke(Reader, b);
			int result = num;
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			Llvm_lifetime_end_p0.Invoke(1L, &b);
			return result;
		}
	}
}
