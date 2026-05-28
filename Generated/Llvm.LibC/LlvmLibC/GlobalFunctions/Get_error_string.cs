using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Get_error_string
{
	[MangledName("_ZN19__llvm_libc_20_1_2_16get_error_stringEi")]
	[DemangledName("__llvm_libc_20_1_2_::get_error_string(int)")]
	public unsafe static Struct_kqhe8i Invoke([MangledName("err_num")][NativeType("int")] int Err_num)
	{
		Cpp_string_view cpp_string_view = default(Cpp_string_view);
		Cpp_string_view cpp_string_view2 = default(Cpp_string_view);
		Span_char_Constructor.Invoke(&cpp_string_view2, Llvm_threadlocal_address_p0.Invoke(Internal_error_buffer.Pointer), 26L);
		unchecked
		{
			Struct_kqhe8i struct_kqhe8i = Invoke(Err_num, *(void**)(&cpp_string_view2), ((long*)(&cpp_string_view2))[1]);
			Cpp_string_view* num = &cpp_string_view;
			Struct_kqhe8i struct_kqhe8i2 = struct_kqhe8i;
			*(void**)num = struct_kqhe8i2.field_0;
			byte* num2 = (byte*)(&cpp_string_view) + 8u;
			Struct_kqhe8i struct_kqhe8i3 = struct_kqhe8i;
			*(long*)num2 = struct_kqhe8i3.field_1;
			return *(Struct_kqhe8i*)(&cpp_string_view);
		}
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_16get_error_stringEiNS_3cpp4spanIcEE")]
	[DemangledName("__llvm_libc_20_1_2_::get_error_string(int, __llvm_libc_20_1_2_::cpp::span<char>)")]
	public unsafe static Struct_kqhe8i Invoke([MangledName("err_num")] int Err_num, [MangledName("buffer.coerce0")][NativeType("int")] void* Buffer, [MangledName("buffer.coerce1")][NativeType("__llvm_libc_20_1_2_::cpp::span<char>")] long Opt_str)
	{
		Cpp_string_view cpp_string_view = default(Cpp_string_view);
		Cpp_string_view cpp_string_view2 = default(Cpp_string_view);
		Cpp_optional_bnt67x cpp_optional_bnt67x = default(Cpp_optional_bnt67x);
		Cpp_string_view cpp_string_view3 = default(Cpp_string_view);
		unchecked
		{
			*(void**)(&cpp_string_view2) = Buffer;
			((long*)(&cpp_string_view2))[1] = Opt_str;
			Llvm_lifetime_start_p0.Invoke(24L, &cpp_optional_bnt67x);
			sbyte* ptr = (sbyte*)(&cpp_optional_bnt67x);
			sbyte* ptr2 = ptr;
			*(IntPtr*)ptr2 = unchecked((nint)(-6148914691236517206L));
			((long*)ptr2)[1] = -6148914691236517206L;
			ptr[16] = -86;
			sbyte* ptr3 = ptr + 17;
			*ptr3 = -86;
			ptr3[1] = -86;
			ptr3[2] = -86;
			ptr3[3] = -86;
			ptr3[4] = -86;
			ptr3[5] = -86;
			ptr3[6] = -86;
			MessageMapper_134ul_3113ul_get_str.Invoke(&cpp_optional_bnt67x, (MessageMapper_8a2hs7*)Internal_ERROR_MAPPER.Pointer, Err_num);
			if (Optional_cpp_string_view_ToBoolean.Invoke(&cpp_optional_bnt67x))
			{
				Llvm_memcpy_p0_p0_i64.Invoke(&cpp_string_view, Optional_cpp_string_view_Multiply.Invoke(&cpp_optional_bnt67x), 16L, isVolatile: false);
			}
			else
			{
				Span_char_span_char_true.Invoke(&cpp_string_view3, &cpp_string_view2);
				Struct_kqhe8i struct_kqhe8i = Internal_build_error_string.Invoke(Err_num, *(void**)(&cpp_string_view3), ((long*)(&cpp_string_view3))[1]);
				Cpp_string_view* num = &cpp_string_view;
				Struct_kqhe8i struct_kqhe8i2 = struct_kqhe8i;
				*(void**)num = struct_kqhe8i2.field_0;
				byte* num2 = (byte*)(&cpp_string_view) + 8u;
				Struct_kqhe8i struct_kqhe8i3 = struct_kqhe8i;
				*(long*)num2 = struct_kqhe8i3.field_1;
			}
			Llvm_lifetime_end_p0.Invoke(24L, &cpp_optional_bnt67x);
			return *(Struct_kqhe8i*)(&cpp_string_view);
		}
	}
}
