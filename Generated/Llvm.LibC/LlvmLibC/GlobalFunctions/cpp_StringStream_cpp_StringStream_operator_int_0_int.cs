using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp12StringStreamlsIiTnNS0_9enable_ifIX13is_integral_vIT_EEiE4typeELi0EEERS1_S4_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::StringStream& __llvm_libc_20_1_2_::cpp::StringStream::operator<<<int, 0>(int)")]
internal static partial class cpp_StringStream_cpp_StringStream_operator_int_0_int
{
	public unsafe static void* Invoke(void* @this, int val)
	{
		IntegerToString_exzmu4 integerToString_exzmu = default(IntegerToString_exzmu4);
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		llvm_lifetime_start_p0.Invoke(24L, &integerToString_exzmu);
		unchecked
		{
			sbyte* ptr = (sbyte*)(&integerToString_exzmu);
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
			sbyte* ptr2 = (sbyte*)(&integerToString_exzmu) + 11;
			*ptr2 = -86;
			ptr2[1] = -86;
			ptr2[2] = -86;
			ptr2[3] = -86;
			ptr2[4] = -86;
			((long*)(&integerToString_exzmu))[2] = -6148914691236517206L;
			IntegerToString_int_details_Fmt_unsigned_char_10_false_false_false_1ul_IntegerToString_int.Invoke(&integerToString_exzmu, val);
			Struct_kqhe8i struct_kqhe8i = IntegerToString_int_details_Fmt_unsigned_char_10_false_false_false_1ul_view_const.Invoke(&integerToString_exzmu);
			cpp_string_view* num = &cpp_string_view2;
			Struct_kqhe8i struct_kqhe8i2 = struct_kqhe8i;
			*(void**)num = struct_kqhe8i2.field_0;
			byte* num2 = (byte*)(&cpp_string_view2) + 8u;
			Struct_kqhe8i struct_kqhe8i3 = struct_kqhe8i;
			*(long*)num2 = struct_kqhe8i3.field_1;
			void* result = cpp_StringStream_operator_cpp_string_view.Invoke(@this, *(void**)(&cpp_string_view2), ((long*)(&cpp_string_view2))[1]);
			llvm_lifetime_end_p0.Invoke(24L, &integerToString_exzmu);
			return result;
		}
	}
}
