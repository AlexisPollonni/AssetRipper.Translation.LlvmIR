using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core6Writer5writeENS_3cpp11string_viewE")]
[DemangledName("__llvm_libc_20_1_2_::printf_core::Writer::write(__llvm_libc_20_1_2_::cpp::string_view)")]
internal static partial class printf_core_Writer_write_cpp_string_view
{
	public unsafe static int Invoke(printf_core_Writer* @this, [MangledName("new_string.coerce0")] void* new_string, [MangledName("new_string.coerce1")] long new_string_coerce1)
	{
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		cpp_string_view cpp_string_view3 = default(cpp_string_view);
		int num;
		unchecked
		{
			*(void**)(&cpp_string_view2) = new_string;
			((long*)(&cpp_string_view2))[1] = new_string_coerce1;
			num = (int)cpp_string_view_size_const.Invoke(&cpp_string_view2);
		}
		@this->chars_written += num;
		unchecked
		{
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((ulong)(@this->wb->buff_cur + cpp_string_view_size_const.Invoke(&cpp_string_view2)) <= (ulong)@this->wb->buff_len, expected: true))
			{
				inline_memcpy_void_void_const_unsigned_long.Invoke((byte*)@this->wb->buff + @this->wb->buff_cur, cpp_string_view_data_const.Invoke(&cpp_string_view2), cpp_string_view_size_const.Invoke(&cpp_string_view2));
				long num2 = cpp_string_view_size_const.Invoke(&cpp_string_view2);
				@this->wb->buff_cur += num2;
				return 0;
			}
			printf_core_WriteBuffer* wb = @this->wb;
			llvm_memcpy_p0_p0_i64.Invoke(&cpp_string_view3, &cpp_string_view2, 16L, isVolatile: false);
			return printf_core_WriteBuffer_overflow_write_cpp_string_view.Invoke(wb, *(void**)(&cpp_string_view3), ((long*)(&cpp_string_view3))[1]);
		}
	}
}
