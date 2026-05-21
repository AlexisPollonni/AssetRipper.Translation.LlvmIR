using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FloatWriter_write_middle_block
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core11FloatWriter18write_middle_blockEj")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::FloatWriter::write_middle_block(unsigned int)")]
	public unsafe static int Invoke([MangledName("this")] Llvm_libc_20_1_2_printf_core_FloatWriter* This, [MangledName("block")][NativeType("unsigned int")] int Block)
	{
		int result = 0;
		int num = 0;
		Llvm_libc_20_1_2_IntegerToString_uuwdyc llvm_libc_20_1_2_IntegerToString_uuwdyc = default(Llvm_libc_20_1_2_IntegerToString_uuwdyc);
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view = default(Llvm_libc_20_1_2_cpp_string_view);
		long num2 = 0L;
		unchecked
		{
			if (Block == 999999999)
			{
				This->Max_block_count++;
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num);
				num = FloatWriter_flush_buffer.Invoke(This, Round_up_max_blocks: false);
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
					goto IL_02aa;
				default:
					throw new NotImplementedException("Reached LLVM unreachable instruction.");
				}
				Llvm_lifetime_start_p0.Invoke(32L, &llvm_libc_20_1_2_IntegerToString_uuwdyc);
				sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_IntegerToString_uuwdyc);
				*ptr = -86;
				ptr[1] = -86;
				ptr[2] = -86;
				ptr[3] = -86;
				ptr[4] = -86;
				ptr[5] = -86;
				ptr[6] = -86;
				ptr[7] = -86;
				ptr[8] = -86;
				ptr[9] = -86;
				ptr[10] = -86;
				ptr[11] = -86;
				ptr[12] = -86;
				ptr[13] = -86;
				ptr[14] = -86;
				ptr[15] = -86;
				ptr[16] = -86;
				ptr[17] = -86;
				ptr[18] = -86;
				ptr[19] = -86;
				ptr[20] = -86;
				sbyte* ptr2 = (sbyte*)(&llvm_libc_20_1_2_IntegerToString_uuwdyc) + 21;
				*ptr2 = -86;
				ptr2[1] = -86;
				ptr2[2] = -86;
				((long*)(&llvm_libc_20_1_2_IntegerToString_uuwdyc))[3] = -6148914691236517206L;
				IntegerToString_long_details_Fmt_unsigned_char_10_false_false_false_1ul_Constructor.Invoke(&llvm_libc_20_1_2_IntegerToString_uuwdyc, (uint)(Block + 1000000000));
				Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_string_view);
				*(IntPtr*)(&llvm_libc_20_1_2_cpp_string_view) = unchecked((nint)(-6148914691236517206L));
				((long*)(&llvm_libc_20_1_2_cpp_string_view))[1] = -6148914691236517206L;
				Struct_kqhe8i struct_kqhe8i = IntegerToString_long_details_Fmt_unsigned_char_10_false_false_false_1ul_view.Invoke(&llvm_libc_20_1_2_IntegerToString_uuwdyc);
				Llvm_libc_20_1_2_cpp_string_view* num4 = &llvm_libc_20_1_2_cpp_string_view;
				Struct_kqhe8i struct_kqhe8i2 = struct_kqhe8i;
				*(void**)num4 = struct_kqhe8i2.field_0;
				byte* num5 = (byte*)(&llvm_libc_20_1_2_cpp_string_view) + 8u;
				Struct_kqhe8i struct_kqhe8i3 = struct_kqhe8i;
				*(long*)num5 = struct_kqhe8i3.field_1;
				Llvm_lifetime_start_p0.Invoke(8L, &num2);
				for (num2 = 0L; (ulong)num2 < 9uL; num2++)
				{
					sbyte b = *(sbyte*)String_view_Index.Invoke(&llvm_libc_20_1_2_cpp_string_view, num2 + 1L);
					((sbyte*)(&This->Block_buffer))[num2] = b;
				}
				Llvm_lifetime_end_p0.Invoke(8L, &num2);
				This->Buffered_digits = 9L;
				Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_string_view);
				Llvm_lifetime_end_p0.Invoke(32L, &llvm_libc_20_1_2_IntegerToString_uuwdyc);
			}
			result = 0;
			goto IL_02aa;
		}
		IL_02aa:
		return result;
	}
}
