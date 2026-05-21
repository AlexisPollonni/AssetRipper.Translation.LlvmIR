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
	public unsafe static int Invoke(printf_core_Writer* @this, [NativeType("char")] sbyte new_char, [NativeType("unsigned long")] long length)
	{
		int result = 0;
		long num = 0L;
		long num2 = 0L;
		long num3 = 0L;
		InlineArray64_SByte inlineArray64_SByte = default(InlineArray64_SByte);
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		int num4 = 0;
		cpp_string_view cpp_string_view3 = default(cpp_string_view);
		cpp_string_view cpp_string_view4 = default(cpp_string_view);
		cpp_string_view cpp_string_view5 = default(cpp_string_view);
		sbyte value = new_char;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num2);
		unchecked
		{
			num2 = @this->wb->buff_len - @this->wb->buff_cur;
			if ((ulong)num2 > 0uL)
			{
				inline_memset_fthuvz.Invoke((byte*)@this->wb->buff + @this->wb->buff_cur, value, num2);
				long num5 = num2;
				@this->wb->buff_cur += num5;
				num = num2;
			}
			llvm_lifetime_start_p0.Invoke(8L, &num3);
			num3 = 64L;
			llvm_lifetime_start_p0.Invoke(64L, &inlineArray64_SByte);
			llvm_memset_p0_i64.Invoke(&inlineArray64_SByte, -86, 64L, isVolatile: false);
			inline_memset_fthuvz.Invoke(&inlineArray64_SByte, value, 64L);
			llvm_lifetime_start_p0.Invoke(16L, &cpp_string_view2);
			*(IntPtr*)(&cpp_string_view2) = unchecked((nint)(-6148914691236517206L));
			((long*)(&cpp_string_view2))[1] = -6148914691236517206L;
			string_view_Constructor.Invoke(&cpp_string_view2, &inlineArray64_SByte, 64L);
			while (true)
			{
				if ((ulong)(num + 64L) < (ulong)length)
				{
					llvm_lifetime_start_p0.Invoke(4L, &num4);
					printf_core_WriteBuffer* wb = @this->wb;
					llvm_memcpy_p0_p0_i64.Invoke(&cpp_string_view3, &cpp_string_view2, 16L, isVolatile: false);
					num4 = WriteBuffer_overflow_write.Invoke(wb, *(void**)(&cpp_string_view3), ((long*)(&cpp_string_view3))[1]);
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
					llvm_lifetime_end_p0.Invoke(4L, &num4);
					switch (num6)
					{
					case 0:
						continue;
					}
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(16L, &cpp_string_view4);
					*(IntPtr*)(&cpp_string_view4) = unchecked((nint)(-6148914691236517206L));
					((long*)(&cpp_string_view4))[1] = -6148914691236517206L;
					Struct_kqhe8i struct_kqhe8i = string_view_substr.Invoke(&cpp_string_view2, 0L, length - num);
					cpp_string_view* num7 = &cpp_string_view4;
					Struct_kqhe8i struct_kqhe8i2 = struct_kqhe8i;
					*(void**)num7 = struct_kqhe8i2.field_0;
					byte* num8 = (byte*)(&cpp_string_view4) + 8u;
					Struct_kqhe8i struct_kqhe8i3 = struct_kqhe8i;
					*(long*)num8 = struct_kqhe8i3.field_1;
					printf_core_WriteBuffer* wb2 = @this->wb;
					llvm_memcpy_p0_p0_i64.Invoke(&cpp_string_view5, &cpp_string_view4, 16L, isVolatile: false);
					result = WriteBuffer_overflow_write.Invoke(wb2, *(void**)(&cpp_string_view5), ((long*)(&cpp_string_view5))[1]);
					llvm_lifetime_end_p0.Invoke(16L, &cpp_string_view4);
				}
				break;
			}
			llvm_lifetime_end_p0.Invoke(16L, &cpp_string_view2);
			llvm_lifetime_end_p0.Invoke(64L, &inlineArray64_SByte);
			llvm_lifetime_end_p0.Invoke(8L, &num3);
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
