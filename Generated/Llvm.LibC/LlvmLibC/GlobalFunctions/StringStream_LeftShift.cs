using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class StringStream_LeftShift
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp12StringStreamlsENS0_11string_viewE")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::StringStream::operator<<(__llvm_libc_20_1_2_::cpp::string_view)")]
	public unsafe static void* Invoke([MangledName("this")] void* This, [MangledName("str.coerce0")] void* Str, [MangledName("str.coerce1")] long Str_coerce1)
	{
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view = default(Llvm_libc_20_1_2_cpp_string_view);
		unchecked
		{
			*(void**)(&llvm_libc_20_1_2_cpp_string_view) = Str;
			((long*)(&llvm_libc_20_1_2_cpp_string_view))[1] = Str_coerce1;
			StringStream_write.Invoke(This, String_view_data.Invoke(&llvm_libc_20_1_2_cpp_string_view), String_view_size.Invoke(&llvm_libc_20_1_2_cpp_string_view));
			return This;
		}
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp12StringStreamlsEPKc")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::StringStream::operator<<(char const*)")]
	public unsafe static void* Invoke([MangledName("this")] void* This, [MangledName("str")][NativeType("char const*")] void* Str)
	{
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view = default(Llvm_libc_20_1_2_cpp_string_view);
		String_view_Constructor.Invoke(&llvm_libc_20_1_2_cpp_string_view, Str);
		return unchecked(Invoke(This, *(void**)(&llvm_libc_20_1_2_cpp_string_view), ((long*)(&llvm_libc_20_1_2_cpp_string_view))[1]));
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp12StringStreamlsEc")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::StringStream::operator<<(char)")]
	public unsafe static void* Invoke([MangledName("this")] void* This, [MangledName("a")][NativeType("char")] sbyte A)
	{
		sbyte b = A;
		StringStream_write.Invoke(This, &b, 1L);
		return This;
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp12StringStreamlsIiTnNS0_9enable_ifIX13is_integral_vIT_EEiE4typeELi0EEERS1_S4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::StringStream& __llvm_libc_20_1_2_::cpp::StringStream::operator<<<int, 0>(int)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::StringStream&")]
	public unsafe static void* Invoke([MangledName("this")] void* This, [MangledName("val")][NativeType("int")] int Val)
	{
		Llvm_libc_20_1_2_IntegerToString_bz5c8a llvm_libc_20_1_2_IntegerToString_bz5c8a = default(Llvm_libc_20_1_2_IntegerToString_bz5c8a);
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view = default(Llvm_libc_20_1_2_cpp_string_view);
		Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_IntegerToString_bz5c8a);
		unchecked
		{
			sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_IntegerToString_bz5c8a);
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
			sbyte* ptr2 = (sbyte*)(&llvm_libc_20_1_2_IntegerToString_bz5c8a) + 11;
			*ptr2 = -86;
			ptr2[1] = -86;
			ptr2[2] = -86;
			ptr2[3] = -86;
			ptr2[4] = -86;
			((long*)(&llvm_libc_20_1_2_IntegerToString_bz5c8a))[2] = -6148914691236517206L;
			IntegerToString_int_details_Fmt_unsigned_char_10_false_false_false_1ul_Constructor.Invoke(&llvm_libc_20_1_2_IntegerToString_bz5c8a, Val);
			Struct_kqhe8i struct_kqhe8i = IntegerToString_int_details_Fmt_unsigned_char_10_false_false_false_1ul_view.Invoke(&llvm_libc_20_1_2_IntegerToString_bz5c8a);
			Llvm_libc_20_1_2_cpp_string_view* num = &llvm_libc_20_1_2_cpp_string_view;
			Struct_kqhe8i struct_kqhe8i2 = struct_kqhe8i;
			*(void**)num = struct_kqhe8i2.field_0;
			byte* num2 = (byte*)(&llvm_libc_20_1_2_cpp_string_view) + 8u;
			Struct_kqhe8i struct_kqhe8i3 = struct_kqhe8i;
			*(long*)num2 = struct_kqhe8i3.field_1;
			void* result = Invoke(This, *(void**)(&llvm_libc_20_1_2_cpp_string_view), ((long*)(&llvm_libc_20_1_2_cpp_string_view))[1]);
			Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_IntegerToString_bz5c8a);
			return result;
		}
	}
}
