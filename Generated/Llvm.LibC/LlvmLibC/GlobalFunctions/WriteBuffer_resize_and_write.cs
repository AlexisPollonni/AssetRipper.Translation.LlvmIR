using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class WriteBuffer_resize_and_write
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core11WriteBuffer16resize_and_writeENS_3cpp11string_viewE")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::WriteBuffer::resize_and_write(__llvm_libc_20_1_2_::cpp::string_view)")]
	public unsafe static int Invoke([MangledName("this")] Llvm_libc_20_1_2_printf_core_WriteBuffer* This, [MangledName("new_str.coerce0")] void* New_str, [MangledName("new_str.coerce1")] long New_str_coerce1)
	{
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view = default(Llvm_libc_20_1_2_cpp_string_view);
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view2 = default(Llvm_libc_20_1_2_cpp_string_view);
		unchecked
		{
			*(void**)(&llvm_libc_20_1_2_cpp_string_view) = New_str;
			((long*)(&llvm_libc_20_1_2_cpp_string_view))[1] = New_str_coerce1;
			void* stream_writer = This->Stream_writer;
			Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_cpp_string_view2, &llvm_libc_20_1_2_cpp_string_view, 16L, isVolatile: false);
			void* output_target = This->Output_target;
			return ((delegate*<void*, long, void*, int>)stream_writer)(*(void**)(&llvm_libc_20_1_2_cpp_string_view2), ((long*)(&llvm_libc_20_1_2_cpp_string_view2))[1], output_target);
		}
	}
}
