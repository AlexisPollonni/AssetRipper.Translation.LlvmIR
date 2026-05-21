using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class WriteBuffer_fill_remaining_to_buff
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core11WriteBuffer22fill_remaining_to_buffENS_3cpp11string_viewE")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::WriteBuffer::fill_remaining_to_buff(__llvm_libc_20_1_2_::cpp::string_view)")]
	public unsafe static int Invoke([MangledName("this")] Llvm_libc_20_1_2_printf_core_WriteBuffer* This, [MangledName("new_str.coerce0")] void* New_str, [MangledName("new_str.coerce1")] long Bytes_to_write)
	{
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view = default(Llvm_libc_20_1_2_cpp_string_view);
		long num = 0L;
		unchecked
		{
			*(void**)(&llvm_libc_20_1_2_cpp_string_view) = New_str;
			((long*)(&llvm_libc_20_1_2_cpp_string_view))[1] = Bytes_to_write;
			if ((ulong)This->Buff_cur < (ulong)This->Buff_len)
			{
				Llvm_lifetime_start_p0.Invoke(8L, &num);
				num = This->Buff_len - This->Buff_cur;
				if ((ulong)num > (ulong)String_view_size.Invoke(&llvm_libc_20_1_2_cpp_string_view))
				{
					num = String_view_size.Invoke(&llvm_libc_20_1_2_cpp_string_view);
				}
				Llvm_libc_20_1_2_inline_memcpy.Invoke((byte*)This->Buff + This->Buff_cur, String_view_data.Invoke(&llvm_libc_20_1_2_cpp_string_view), num);
				This->Buff_cur += num;
				Llvm_lifetime_end_p0.Invoke(8L, &num);
			}
			return 0;
		}
	}
}
