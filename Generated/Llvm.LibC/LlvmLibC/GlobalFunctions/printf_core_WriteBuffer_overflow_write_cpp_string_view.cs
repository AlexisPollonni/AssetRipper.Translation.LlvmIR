using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core11WriteBuffer14overflow_writeENS_3cpp11string_viewE")]
[DemangledName("__llvm_libc_20_1_2_::printf_core::WriteBuffer::overflow_write(__llvm_libc_20_1_2_::cpp::string_view)")]
internal static partial class printf_core_WriteBuffer_overflow_write_cpp_string_view
{
	public unsafe static int Invoke(void* @this, [MangledName("new_str.coerce0")] void* new_str, [MangledName("new_str.coerce1")] long new_str_coerce1)
	{
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		cpp_string_view cpp_string_view3 = default(cpp_string_view);
		cpp_string_view cpp_string_view4 = default(cpp_string_view);
		cpp_string_view cpp_string_view5 = default(cpp_string_view);
		unchecked
		{
			*(void**)(&cpp_string_view2) = new_str;
			((long*)(&cpp_string_view2))[1] = new_str_coerce1;
			switch (((printf_core_WriteBuffer*)@this)->write_mode)
			{
			case 0:
				llvm_memcpy_p0_p0_i64.Invoke(&cpp_string_view3, &cpp_string_view2, 16L, isVolatile: false);
				return printf_core_WriteBuffer_fill_remaining_to_buff_cpp_string_view.Invoke(@this, *(void**)(&cpp_string_view3), ((long*)(&cpp_string_view3))[1]);
			case 1:
				llvm_memcpy_p0_p0_i64.Invoke(&cpp_string_view4, &cpp_string_view2, 16L, isVolatile: false);
				return printf_core_WriteBuffer_flush_to_stream_cpp_string_view.Invoke(@this, *(void**)(&cpp_string_view4), ((long*)(&cpp_string_view4))[1]);
			case 2:
				llvm_memcpy_p0_p0_i64.Invoke(&cpp_string_view5, &cpp_string_view2, 16L, isVolatile: false);
				return printf_core_WriteBuffer_resize_and_write_cpp_string_view.Invoke(@this, *(void**)(&cpp_string_view5), ((long*)(&cpp_string_view5))[1]);
			default:
				throw null;
			}
		}
	}
}
