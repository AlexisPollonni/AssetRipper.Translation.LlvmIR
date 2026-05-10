using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_10scanf_core16vfscanf_internalEP8_IO_FILEPKcRNS_8internal7ArgListE")]
[DemangledName("__llvm_libc_20_1_2_::scanf_core::vfscanf_internal(_IO_FILE*, char const*, __llvm_libc_20_1_2_::internal::ArgList&)")]
internal static partial class scanf_core_vfscanf_internal_IO_FILE_char_const_internal_ArgList
{
	public unsafe static int Invoke(void* stream, void* format, void* args)
	{
		scanf_core_Reader scanf_core_Reader2 = default(scanf_core_Reader);
		int num = 0;
		internal_flockfile_IO_FILE.Invoke(stream);
		llvm_lifetime_start_p0.Invoke(40L, &scanf_core_Reader2);
		llvm_memset_p0_i64.Invoke(&scanf_core_Reader2, 0, 40L, isVolatile: false);
		unchecked
		{
			scanf_core_Reader2.rb = (void*)12297829382473034410uL;
			scanf_core_Reader2.input_stream = (void*)12297829382473034410uL;
			scanf_core_Reader2.stream_getc = (void*)12297829382473034410uL;
			scanf_core_Reader2.stream_ungetc = (void*)12297829382473034410uL;
			scanf_core_Reader2.cur_chars_read = -6148914691236517206L;
			scanf_core_Reader_Reader_void_int_void_void_int_void_scanf_core_ReadBuffer.Invoke(&scanf_core_Reader2, stream, internal_getc_void.__pointer, internal_ungetc_int_void.__pointer, null);
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = scanf_core_scanf_main_scanf_core_Reader_char_const_internal_ArgList.Invoke(&scanf_core_Reader2, format, args);
			if (num == 0 && internal_ferror_unlocked_IO_FILE.Invoke(stream) != 0)
			{
				num = -1;
			}
			internal_funlockfile_IO_FILE.Invoke(stream);
			int result = num;
			llvm_lifetime_end_p0.Invoke(4L, &num);
			llvm_lifetime_end_p0.Invoke(40L, &scanf_core_Reader2);
			return result;
		}
	}
}
