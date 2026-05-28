using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class WriteBuffer_overflow_write
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core11WriteBuffer14overflow_writeENS_3cpp11string_viewE")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::WriteBuffer::overflow_write(__llvm_libc_20_1_2_::cpp::string_view)")]
	public unsafe static int Invoke([MangledName("this")] Printf_core_WriteBuffer* This, [MangledName("new_str.coerce0")] void* New_str, [MangledName("new_str.coerce1")] long New_str_coerce1)
	{
		Cpp_string_view cpp_string_view = default(Cpp_string_view);
		Cpp_string_view cpp_string_view2 = default(Cpp_string_view);
		Cpp_string_view cpp_string_view3 = default(Cpp_string_view);
		Cpp_string_view cpp_string_view4 = default(Cpp_string_view);
		unchecked
		{
			*(void**)(&cpp_string_view) = New_str;
			((long*)(&cpp_string_view))[1] = New_str_coerce1;
			switch (This->Write_mode)
			{
			case WriteMode.FILL_BUFF_AND_DROP_OVERFLOW:
				Llvm_memcpy_p0_p0_i64.Invoke(&cpp_string_view2, &cpp_string_view, 16L, isVolatile: false);
				return WriteBuffer_fill_remaining_to_buff.Invoke(This, *(void**)(&cpp_string_view2), ((long*)(&cpp_string_view2))[1]);
			case WriteMode.FLUSH_TO_STREAM:
				Llvm_memcpy_p0_p0_i64.Invoke(&cpp_string_view3, &cpp_string_view, 16L, isVolatile: false);
				return WriteBuffer_flush_to_stream.Invoke(This, *(void**)(&cpp_string_view3), ((long*)(&cpp_string_view3))[1]);
			case WriteMode.RESIZE_AND_FILL_BUFF:
				Llvm_memcpy_p0_p0_i64.Invoke(&cpp_string_view4, &cpp_string_view, 16L, isVolatile: false);
				return WriteBuffer_resize_and_write.Invoke(This, *(void**)(&cpp_string_view4), ((long*)(&cpp_string_view4))[1]);
			default:
				throw new NotImplementedException("Reached LLVM unreachable instruction.");
			}
		}
	}
}
