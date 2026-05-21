using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class WriteBuffer_flush_to_stream
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core11WriteBuffer15flush_to_streamENS_3cpp11string_viewE")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::WriteBuffer::flush_to_stream(__llvm_libc_20_1_2_::cpp::string_view)")]
	public unsafe static int Invoke([MangledName("this")] Llvm_libc_20_1_2_printf_core_WriteBuffer* This, [MangledName("new_str.coerce0")] void* New_str, [MangledName("new_str.coerce1")] long Retval)
	{
		int result = 0;
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view = default(Llvm_libc_20_1_2_cpp_string_view);
		int num = 0;
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view2 = default(Llvm_libc_20_1_2_cpp_string_view);
		int num2 = 0;
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view3 = default(Llvm_libc_20_1_2_cpp_string_view);
		unchecked
		{
			*(void**)(&llvm_libc_20_1_2_cpp_string_view) = New_str;
			((long*)(&llvm_libc_20_1_2_cpp_string_view))[1] = Retval;
			if ((ulong)This->Buff_cur > 0uL)
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num);
				void* stream_writer = This->Stream_writer;
				String_view_Constructor.Invoke(&llvm_libc_20_1_2_cpp_string_view2, This->Buff, This->Buff_cur);
				void* output_target = This->Output_target;
				num = ((delegate*<void*, long, void*, int>)stream_writer)(*(void**)(&llvm_libc_20_1_2_cpp_string_view2), ((long*)(&llvm_libc_20_1_2_cpp_string_view2))[1], output_target);
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
				Llvm_lifetime_end_p0.Invoke(4L, &num);
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
			if ((ulong)String_view_size.Invoke(&llvm_libc_20_1_2_cpp_string_view) > 0uL)
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num2);
				void* stream_writer2 = This->Stream_writer;
				Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_cpp_string_view3, &llvm_libc_20_1_2_cpp_string_view, 16L, isVolatile: false);
				void* output_target2 = This->Output_target;
				num2 = ((delegate*<void*, long, void*, int>)stream_writer2)(*(void**)(&llvm_libc_20_1_2_cpp_string_view3), ((long*)(&llvm_libc_20_1_2_cpp_string_view3))[1], output_target2);
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
				Llvm_lifetime_end_p0.Invoke(4L, &num2);
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
			This->Buff_cur = 0L;
			result = 0;
			goto IL_018a;
		}
		IL_018c:
		throw new NotImplementedException("Reached LLVM unreachable instruction.");
		IL_018a:
		return result;
	}
}
