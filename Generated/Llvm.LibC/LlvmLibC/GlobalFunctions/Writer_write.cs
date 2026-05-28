using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Writer_write
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core6Writer5writeENS_3cpp11string_viewE")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::Writer::write(__llvm_libc_20_1_2_::cpp::string_view)")]
	public unsafe static int Invoke([MangledName("this")] Printf_core_Writer* This, [MangledName("new_string.coerce0")] void* New_string, [MangledName("new_string.coerce1")] long New_string_coerce1)
	{
		Cpp_string_view cpp_string_view = default(Cpp_string_view);
		Cpp_string_view cpp_string_view2 = default(Cpp_string_view);
		int num;
		unchecked
		{
			*(void**)(&cpp_string_view) = New_string;
			((long*)(&cpp_string_view))[1] = New_string_coerce1;
			num = (int)String_view_size.Invoke(&cpp_string_view);
		}
		This->Chars_written += num;
		unchecked
		{
			if (Details_expects_bool_condition_bool.Invoke((ulong)(This->Wb->Buff_cur + String_view_size.Invoke(&cpp_string_view)) <= (ulong)This->Wb->Buff_len, Expected: true))
			{
				Inline_memcpy.Invoke((byte*)This->Wb->Buff + This->Wb->Buff_cur, String_view_data.Invoke(&cpp_string_view), String_view_size.Invoke(&cpp_string_view));
				long num2 = String_view_size.Invoke(&cpp_string_view);
				This->Wb->Buff_cur += num2;
				return 0;
			}
			Printf_core_WriteBuffer* wb = This->Wb;
			Llvm_memcpy_p0_p0_i64.Invoke(&cpp_string_view2, &cpp_string_view, 16L, isVolatile: false);
			return WriteBuffer_overflow_write.Invoke(wb, *(void**)(&cpp_string_view2), ((long*)(&cpp_string_view2))[1]);
		}
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core6Writer5writeEc")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::Writer::write(char)")]
	public unsafe static int Invoke([MangledName("this")] Printf_core_Writer* This, [MangledName("new_char")][NativeType("char")] sbyte New_char)
	{
		sbyte b = 0;
		Cpp_string_view cpp_string_view = default(Cpp_string_view);
		Cpp_string_view cpp_string_view2 = default(Cpp_string_view);
		b = New_char;
		This->Chars_written++;
		unchecked
		{
			int result;
			if (Details_expects_bool_condition_bool.Invoke((ulong)(This->Wb->Buff_cur + 1L) <= (ulong)This->Wb->Buff_len, Expected: true))
			{
				sbyte b2 = b;
				((sbyte*)This->Wb->Buff)[This->Wb->Buff_cur] = b2;
				This->Wb->Buff_cur++;
				result = 0;
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(16L, &cpp_string_view);
				*(IntPtr*)(&cpp_string_view) = unchecked((nint)(-6148914691236517206L));
				((long*)(&cpp_string_view))[1] = -6148914691236517206L;
				String_view_Constructor.Invoke(&cpp_string_view, &b, 1L);
				Printf_core_WriteBuffer* wb = This->Wb;
				Llvm_memcpy_p0_p0_i64.Invoke(&cpp_string_view2, &cpp_string_view, 16L, isVolatile: false);
				result = WriteBuffer_overflow_write.Invoke(wb, *(void**)(&cpp_string_view2), ((long*)(&cpp_string_view2))[1]);
				Llvm_lifetime_end_p0.Invoke(16L, &cpp_string_view);
			}
			return result;
		}
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core6Writer5writeEcm")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::Writer::write(char, unsigned long)")]
	public unsafe static int Invoke([MangledName("this")] Printf_core_Writer* This, [MangledName("new_char")][NativeType("char")] sbyte New_char, [MangledName("length")][NativeType("unsigned long")] long Length)
	{
		sbyte b = New_char;
		This->Chars_written += unchecked((int)Length);
		unchecked
		{
			if (Details_expects_bool_condition_bool.Invoke((ulong)(This->Wb->Buff_cur + Length) <= (ulong)This->Wb->Buff_len, Expected: true))
			{
				Inline_memset_n6zrms.Invoke((byte*)This->Wb->Buff + This->Wb->Buff_cur, b, Length);
				This->Wb->Buff_cur += Length;
				return 0;
			}
			return Writer_pad.Invoke(This, b, Length);
		}
	}
}
