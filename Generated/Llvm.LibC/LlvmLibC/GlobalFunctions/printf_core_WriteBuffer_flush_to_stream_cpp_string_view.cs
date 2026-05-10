using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core11WriteBuffer15flush_to_streamENS_3cpp11string_viewE")]
[DemangledName("__llvm_libc_20_1_2_::printf_core::WriteBuffer::flush_to_stream(__llvm_libc_20_1_2_::cpp::string_view)")]
internal static partial class printf_core_WriteBuffer_flush_to_stream_cpp_string_view
{
	public unsafe static int Invoke(void* @this, [MangledName("new_str.coerce0")] void* new_str, [MangledName("new_str.coerce1")] long retval)
	{
		int result = 0;
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		int num = 0;
		cpp_string_view cpp_string_view3 = default(cpp_string_view);
		int num2 = 0;
		cpp_string_view cpp_string_view4 = default(cpp_string_view);
		unchecked
		{
			*(void**)(&cpp_string_view2) = new_str;
			((long*)(&cpp_string_view2))[1] = retval;
			if ((ulong)((printf_core_WriteBuffer*)@this)->buff_cur > 0uL)
			{
				llvm_lifetime_start_p0.Invoke(4L, &num);
				void* stream_writer = ((printf_core_WriteBuffer*)@this)->stream_writer;
				cpp_string_view_string_view_char_const_unsigned_long.Invoke(&cpp_string_view3, ((printf_core_WriteBuffer*)@this)->buff, ((printf_core_WriteBuffer*)@this)->buff_cur);
				void* output_target = ((printf_core_WriteBuffer*)@this)->output_target;
				num = ((delegate*<void*, long, void*, int>)stream_writer)(*(void**)(&cpp_string_view3), ((long*)(&cpp_string_view3))[1], output_target);
				int num3;
				if (num < 0)
				{
					result = num;
					num3 = 1;
				}
				else
				{
					num3 = 0;
				}
				llvm_lifetime_end_p0.Invoke(4L, &num);
				switch (num3)
				{
				case 0:
					break;
				case 1:
					goto IL_018a;
				default:
					goto IL_018c;
				}
			}
			if ((ulong)cpp_string_view_size_const.Invoke(&cpp_string_view2) > 0uL)
			{
				llvm_lifetime_start_p0.Invoke(4L, &num2);
				void* stream_writer2 = ((printf_core_WriteBuffer*)@this)->stream_writer;
				llvm_memcpy_p0_p0_i64.Invoke(&cpp_string_view4, &cpp_string_view2, 16L, isVolatile: false);
				void* output_target2 = ((printf_core_WriteBuffer*)@this)->output_target;
				num2 = ((delegate*<void*, long, void*, int>)stream_writer2)(*(void**)(&cpp_string_view4), ((long*)(&cpp_string_view4))[1], output_target2);
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
				llvm_lifetime_end_p0.Invoke(4L, &num2);
				switch (num3)
				{
				case 0:
					break;
				case 1:
					goto IL_018a;
				default:
					goto IL_018c;
				}
			}
			((printf_core_WriteBuffer*)@this)->buff_cur = 0L;
			result = 0;
			goto IL_018a;
		}
		IL_018c:
		throw null;
		IL_018a:
		return result;
	}
}
