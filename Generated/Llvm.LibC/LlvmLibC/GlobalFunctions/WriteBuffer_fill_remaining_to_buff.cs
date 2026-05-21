using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class WriteBuffer_fill_remaining_to_buff
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core11WriteBuffer22fill_remaining_to_buffENS_3cpp11string_viewE")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::WriteBuffer::fill_remaining_to_buff(__llvm_libc_20_1_2_::cpp::string_view)")]
	public unsafe static int Invoke(printf_core_WriteBuffer* @this, [MangledName("new_str.coerce0")] void* new_str, [MangledName("new_str.coerce1")] long bytes_to_write)
	{
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		long num = 0L;
		unchecked
		{
			*(void**)(&cpp_string_view2) = new_str;
			((long*)(&cpp_string_view2))[1] = bytes_to_write;
			if ((ulong)@this->buff_cur < (ulong)@this->buff_len)
			{
				llvm_lifetime_start_p0.Invoke(8L, &num);
				num = @this->buff_len - @this->buff_cur;
				if ((ulong)num > (ulong)string_view_size.Invoke(&cpp_string_view2))
				{
					num = string_view_size.Invoke(&cpp_string_view2);
				}
				inline_memcpy.Invoke((byte*)@this->buff + @this->buff_cur, string_view_data.Invoke(&cpp_string_view2), num);
				@this->buff_cur += num;
				llvm_lifetime_end_p0.Invoke(8L, &num);
			}
			return 0;
		}
	}
}
