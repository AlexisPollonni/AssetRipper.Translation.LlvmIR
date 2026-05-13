using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core11WriteBuffer16resize_and_writeENS_3cpp11string_viewE")]
[DemangledName("__llvm_libc_20_1_2_::printf_core::WriteBuffer::resize_and_write(__llvm_libc_20_1_2_::cpp::string_view)")]
internal static partial class printf_core_WriteBuffer_resize_and_write_cpp_string_view
{
	public unsafe static int Invoke(printf_core_WriteBuffer* @this, [MangledName("new_str.coerce0")] void* new_str, [MangledName("new_str.coerce1")] long new_str_coerce1)
	{
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		cpp_string_view cpp_string_view3 = default(cpp_string_view);
		unchecked
		{
			*(void**)(&cpp_string_view2) = new_str;
			((long*)(&cpp_string_view2))[1] = new_str_coerce1;
			void* stream_writer = @this->stream_writer;
			llvm_memcpy_p0_p0_i64.Invoke(&cpp_string_view3, &cpp_string_view2, 16L, isVolatile: false);
			void* output_target = @this->output_target;
			return ((delegate*<void*, long, void*, int>)stream_writer)(*(void**)(&cpp_string_view3), ((long*)(&cpp_string_view3))[1], output_target);
		}
	}
}
