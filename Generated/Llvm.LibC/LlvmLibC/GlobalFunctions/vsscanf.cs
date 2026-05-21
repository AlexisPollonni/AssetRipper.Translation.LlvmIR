using System;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class vsscanf
{
	public unsafe static int Invoke(void* buffer, void* format, va_list_tag* vlist)
	{
		internal_ArgList internal_ArgList2 = default(internal_ArgList);
		scanf_core_ReadBuffer scanf_core_ReadBuffer2 = default(scanf_core_ReadBuffer);
		scanf_core_Reader scanf_core_Reader2 = default(scanf_core_Reader);
		int num = 0;
		llvm_lifetime_start_p0.Invoke(24L, &internal_ArgList2);
		unchecked
		{
			va_list_tag* ptr = (va_list_tag*)(&internal_ArgList2);
			*(int*)ptr = -1431655766;
			((int*)ptr)[1] = -1431655766;
			*(IntPtr*)((byte*)ptr + 8) = unchecked((nint)(-6148914691236517206L));
			*(IntPtr*)((byte*)ptr + 16) = unchecked((nint)(-6148914691236517206L));
			ArgList_Constructor_7zbjxz.Invoke(&internal_ArgList2, vlist);
			llvm_lifetime_start_p0.Invoke(24L, &scanf_core_ReadBuffer2);
			*(IntPtr*)(&scanf_core_ReadBuffer2) = unchecked((nint)(-6148914691236517206L));
			((long*)(&scanf_core_ReadBuffer2))[1] = -6148914691236517206L;
			((long*)(&scanf_core_ReadBuffer2))[2] = -6148914691236517206L;
			scanf_core_ReadBuffer2.buffer = buffer;
			scanf_core_ReadBuffer2.buff_len = integer_impl_unsigned_long_0ul_18446744073709551615ul_max.Invoke();
			scanf_core_ReadBuffer2.buff_cur = 0L;
			llvm_lifetime_start_p0.Invoke(40L, &scanf_core_Reader2);
			llvm_memset_p0_i64.Invoke(&scanf_core_Reader2, 0, 40L, isVolatile: false);
			scanf_core_Reader2.rb = (scanf_core_ReadBuffer*)12297829382473034410uL;
			scanf_core_Reader2.input_stream = (void*)12297829382473034410uL;
			scanf_core_Reader2.stream_getc = (void*)12297829382473034410uL;
			scanf_core_Reader2.stream_ungetc = (void*)12297829382473034410uL;
			scanf_core_Reader2.cur_chars_read = -6148914691236517206L;
			Reader_Constructor.Invoke(&scanf_core_Reader2, &scanf_core_ReadBuffer2);
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = scanf_core_scanf_main.Invoke(&scanf_core_Reader2, format, &internal_ArgList2);
			int result = ((num != -1) ? num : (-1));
			llvm_lifetime_end_p0.Invoke(4L, &num);
			llvm_lifetime_end_p0.Invoke(40L, &scanf_core_Reader2);
			llvm_lifetime_end_p0.Invoke(24L, &scanf_core_ReadBuffer2);
			ArgList_Destructor.Invoke(&internal_ArgList2);
			llvm_lifetime_end_p0.Invoke(24L, &internal_ArgList2);
			return result;
		}
	}
}
