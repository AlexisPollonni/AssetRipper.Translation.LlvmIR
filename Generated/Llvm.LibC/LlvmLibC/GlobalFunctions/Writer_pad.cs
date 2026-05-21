using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Writer_pad
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core6Writer3padEcm")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::Writer::pad(char, unsigned long)")]
	public unsafe static int Invoke([MangledName("this")] Llvm_libc_20_1_2_printf_core_Writer* This, [MangledName("new_char")][NativeType("char")] sbyte New_char, [MangledName("length")][NativeType("unsigned long")] long Length)
	{
		int result = 0;
		long num = 0L;
		long num2 = 0L;
		long num3 = 0L;
		InlineArray64_SByte inlineArray64_SByte = default(InlineArray64_SByte);
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view = default(Llvm_libc_20_1_2_cpp_string_view);
		int num4 = 0;
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view2 = default(Llvm_libc_20_1_2_cpp_string_view);
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view3 = default(Llvm_libc_20_1_2_cpp_string_view);
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view4 = default(Llvm_libc_20_1_2_cpp_string_view);
		sbyte value = New_char;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &num2);
		unchecked
		{
			num2 = This->Wb->Buff_len - This->Wb->Buff_cur;
			if ((ulong)num2 > 0uL)
			{
				Llvm_libc_20_1_2_inline_memset_fthuvz.Invoke((byte*)This->Wb->Buff + This->Wb->Buff_cur, value, num2);
				long num5 = num2;
				This->Wb->Buff_cur += num5;
				num = num2;
			}
			Llvm_lifetime_start_p0.Invoke(8L, &num3);
			num3 = 64L;
			Llvm_lifetime_start_p0.Invoke(64L, &inlineArray64_SByte);
			Llvm_memset_p0_i64.Invoke(&inlineArray64_SByte, -86, 64L, isVolatile: false);
			Llvm_libc_20_1_2_inline_memset_fthuvz.Invoke(&inlineArray64_SByte, value, 64L);
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_string_view);
			*(IntPtr*)(&llvm_libc_20_1_2_cpp_string_view) = unchecked((nint)(-6148914691236517206L));
			((long*)(&llvm_libc_20_1_2_cpp_string_view))[1] = -6148914691236517206L;
			String_view_Constructor.Invoke(&llvm_libc_20_1_2_cpp_string_view, &inlineArray64_SByte, 64L);
			while (true)
			{
				if ((ulong)(num + 64L) < (ulong)Length)
				{
					Llvm_lifetime_start_p0.Invoke(4L, &num4);
					Llvm_libc_20_1_2_printf_core_WriteBuffer* wb = This->Wb;
					Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_cpp_string_view2, &llvm_libc_20_1_2_cpp_string_view, 16L, isVolatile: false);
					num4 = WriteBuffer_overflow_write.Invoke(wb, *(void**)(&llvm_libc_20_1_2_cpp_string_view2), ((long*)(&llvm_libc_20_1_2_cpp_string_view2))[1]);
					int num6;
					if (num4 != 0)
					{
						result = num4;
						num6 = 1;
					}
					else
					{
						num += 64L;
						num6 = 0;
					}
					Llvm_lifetime_end_p0.Invoke(4L, &num4);
					switch (num6)
					{
					case 0:
						continue;
					}
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_string_view3);
					*(IntPtr*)(&llvm_libc_20_1_2_cpp_string_view3) = unchecked((nint)(-6148914691236517206L));
					((long*)(&llvm_libc_20_1_2_cpp_string_view3))[1] = -6148914691236517206L;
					Struct_kqhe8i struct_kqhe8i = String_view_substr.Invoke(&llvm_libc_20_1_2_cpp_string_view, 0L, Length - num);
					Llvm_libc_20_1_2_cpp_string_view* num7 = &llvm_libc_20_1_2_cpp_string_view3;
					Struct_kqhe8i struct_kqhe8i2 = struct_kqhe8i;
					*(void**)num7 = struct_kqhe8i2.field_0;
					byte* num8 = (byte*)(&llvm_libc_20_1_2_cpp_string_view3) + 8u;
					Struct_kqhe8i struct_kqhe8i3 = struct_kqhe8i;
					*(long*)num8 = struct_kqhe8i3.field_1;
					Llvm_libc_20_1_2_printf_core_WriteBuffer* wb2 = This->Wb;
					Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_cpp_string_view4, &llvm_libc_20_1_2_cpp_string_view3, 16L, isVolatile: false);
					result = WriteBuffer_overflow_write.Invoke(wb2, *(void**)(&llvm_libc_20_1_2_cpp_string_view4), ((long*)(&llvm_libc_20_1_2_cpp_string_view4))[1]);
					Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_string_view3);
				}
				break;
			}
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_string_view);
			Llvm_lifetime_end_p0.Invoke(64L, &inlineArray64_SByte);
			Llvm_lifetime_end_p0.Invoke(8L, &num3);
			Llvm_lifetime_end_p0.Invoke(8L, &num2);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
