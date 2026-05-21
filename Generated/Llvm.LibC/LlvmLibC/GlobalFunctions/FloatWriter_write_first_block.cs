using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FloatWriter_write_first_block
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core11FloatWriter17write_first_blockEjb")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::FloatWriter::write_first_block(unsigned int, bool)")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_printf_core_FloatWriter* This, [MangledName("block")][NativeType("unsigned int")] int Block, [MangledName("exp_format")][NativeType("bool")] bool Exp_format)
	{
		Llvm_libc_20_1_2_IntegerToString_uuwdyc llvm_libc_20_1_2_IntegerToString_uuwdyc = default(Llvm_libc_20_1_2_IntegerToString_uuwdyc);
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view = default(Llvm_libc_20_1_2_cpp_string_view);
		long num = 0L;
		long num2 = 0L;
		sbyte b = (Exp_format ? ((sbyte)1) : ((sbyte)0));
		Llvm_lifetime_start_p0.Invoke(32L, &llvm_libc_20_1_2_IntegerToString_uuwdyc);
		unchecked
		{
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
			IntegerToString_long_details_Fmt_unsigned_char_10_false_false_false_1ul_Constructor.Invoke(&llvm_libc_20_1_2_IntegerToString_uuwdyc, (uint)Block);
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_string_view);
			*(IntPtr*)(&llvm_libc_20_1_2_cpp_string_view) = unchecked((nint)(-6148914691236517206L));
			((long*)(&llvm_libc_20_1_2_cpp_string_view))[1] = -6148914691236517206L;
			Struct_kqhe8i struct_kqhe8i = IntegerToString_long_details_Fmt_unsigned_char_10_false_false_false_1ul_view.Invoke(&llvm_libc_20_1_2_IntegerToString_uuwdyc);
			Llvm_libc_20_1_2_cpp_string_view* num3 = &llvm_libc_20_1_2_cpp_string_view;
			Struct_kqhe8i struct_kqhe8i2 = struct_kqhe8i;
			*(void**)num3 = struct_kqhe8i2.field_0;
			byte* num4 = (byte*)(&llvm_libc_20_1_2_cpp_string_view) + 8u;
			Struct_kqhe8i struct_kqhe8i3 = struct_kqhe8i;
			*(long*)num4 = struct_kqhe8i3.field_1;
			Llvm_lifetime_start_p0.Invoke(8L, &num);
			num = String_view_size.Invoke(&llvm_libc_20_1_2_cpp_string_view);
			Llvm_lifetime_start_p0.Invoke(8L, &num2);
			for (num2 = 0L; (ulong)num2 < (ulong)num; num2++)
			{
				sbyte b2 = *(sbyte*)String_view_Index.Invoke(&llvm_libc_20_1_2_cpp_string_view, num2);
				((sbyte*)(&This->Block_buffer))[num2] = b2;
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num2);
			This->Buffered_digits = num;
			if ((b & 1) != 1)
			{
				This->Total_digits += num;
				This->Digits_before_decimal += num;
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_string_view);
			Llvm_lifetime_end_p0.Invoke(32L, &llvm_libc_20_1_2_IntegerToString_uuwdyc);
		}
	}
}
