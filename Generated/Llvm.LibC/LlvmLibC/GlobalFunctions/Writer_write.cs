using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Writer_write
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core6Writer5writeENS_3cpp11string_viewE")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::Writer::write(__llvm_libc_20_1_2_::cpp::string_view)")]
	public unsafe static int Invoke(printf_core_Writer* @this, [MangledName("new_string.coerce0")] void* new_string, [MangledName("new_string.coerce1")] long new_string_coerce1)
	{
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		cpp_string_view cpp_string_view3 = default(cpp_string_view);
		int num;
		unchecked
		{
			*(void**)(&cpp_string_view2) = new_string;
			((long*)(&cpp_string_view2))[1] = new_string_coerce1;
			num = (int)string_view_size.Invoke(&cpp_string_view2);
		}
		@this->chars_written += num;
		unchecked
		{
			if (details_expects_bool_condition_bool.Invoke((ulong)(@this->wb->buff_cur + string_view_size.Invoke(&cpp_string_view2)) <= (ulong)@this->wb->buff_len, expected: true))
			{
				inline_memcpy.Invoke((byte*)@this->wb->buff + @this->wb->buff_cur, string_view_data.Invoke(&cpp_string_view2), string_view_size.Invoke(&cpp_string_view2));
				long num2 = string_view_size.Invoke(&cpp_string_view2);
				@this->wb->buff_cur += num2;
				return 0;
			}
			printf_core_WriteBuffer* wb = @this->wb;
			llvm_memcpy_p0_p0_i64.Invoke(&cpp_string_view3, &cpp_string_view2, 16L, isVolatile: false);
			return WriteBuffer_overflow_write.Invoke(wb, *(void**)(&cpp_string_view3), ((long*)(&cpp_string_view3))[1]);
		}
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core6Writer5writeEc")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::Writer::write(char)")]
	public unsafe static int Invoke(printf_core_Writer* @this, [NativeType("char")] sbyte new_char)
	{
		sbyte b = 0;
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		cpp_string_view cpp_string_view3 = default(cpp_string_view);
		b = new_char;
		@this->chars_written++;
		unchecked
		{
			int result;
			if (details_expects_bool_condition_bool.Invoke((ulong)(@this->wb->buff_cur + 1L) <= (ulong)@this->wb->buff_len, expected: true))
			{
				sbyte b2 = b;
				((sbyte*)@this->wb->buff)[@this->wb->buff_cur] = b2;
				@this->wb->buff_cur++;
				result = 0;
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(16L, &cpp_string_view2);
				*(IntPtr*)(&cpp_string_view2) = unchecked((nint)(-6148914691236517206L));
				((long*)(&cpp_string_view2))[1] = -6148914691236517206L;
				string_view_Constructor.Invoke(&cpp_string_view2, &b, 1L);
				printf_core_WriteBuffer* wb = @this->wb;
				llvm_memcpy_p0_p0_i64.Invoke(&cpp_string_view3, &cpp_string_view2, 16L, isVolatile: false);
				result = WriteBuffer_overflow_write.Invoke(wb, *(void**)(&cpp_string_view3), ((long*)(&cpp_string_view3))[1]);
				llvm_lifetime_end_p0.Invoke(16L, &cpp_string_view2);
			}
			return result;
		}
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core6Writer5writeEcm")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::Writer::write(char, unsigned long)")]
	public unsafe static int Invoke(printf_core_Writer* @this, [NativeType("char")] sbyte new_char, [NativeType("unsigned long")] long length)
	{
		sbyte b = new_char;
		@this->chars_written += unchecked((int)length);
		unchecked
		{
			if (details_expects_bool_condition_bool.Invoke((ulong)(@this->wb->buff_cur + length) <= (ulong)@this->wb->buff_len, expected: true))
			{
				inline_memset_n6zrms.Invoke((byte*)@this->wb->buff + @this->wb->buff_cur, b, length);
				@this->wb->buff_cur += length;
				return 0;
			}
			return Writer_pad.Invoke(@this, b, length);
		}
	}
}
