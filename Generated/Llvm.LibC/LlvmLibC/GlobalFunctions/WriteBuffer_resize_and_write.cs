using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class WriteBuffer_resize_and_write
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core11WriteBuffer16resize_and_writeENS_3cpp11string_viewE")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::WriteBuffer::resize_and_write(__llvm_libc_20_1_2_::cpp::string_view)")]
	public unsafe static int Invoke([MangledName("this")] Printf_core_WriteBuffer* This, [MangledName("new_str.coerce0")] void* New_str, [MangledName("new_str.coerce1")] long New_str_coerce1)
	{
		Cpp_string_view cpp_string_view = default(Cpp_string_view);
		Cpp_string_view cpp_string_view2 = default(Cpp_string_view);
		unchecked
		{
			*(void**)(&cpp_string_view) = New_str;
			((long*)(&cpp_string_view))[1] = New_str_coerce1;
			void* stream_writer = This->Stream_writer;
			Llvm_memcpy_p0_p0_i64.Invoke(&cpp_string_view2, &cpp_string_view, 16L, isVolatile: false);
			void* output_target = This->Output_target;
			return ((delegate*<void*, long, void*, int>)stream_writer)(*(void**)(&cpp_string_view2), ((long*)(&cpp_string_view2))[1], output_target);
		}
	}
}
