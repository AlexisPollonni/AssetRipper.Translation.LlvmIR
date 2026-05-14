using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_17get_signal_stringEi")]
[DemangledName("__llvm_libc_20_1_2_::get_signal_string(int)")]
internal static partial class Get_signal_string_int
{
	public unsafe static Struct_kqhe8i Invoke(int sig_num)
	{
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		cpp_string_view cpp_string_view3 = default(cpp_string_view);
		cpp_span_char_span_char_unsigned_long.Invoke(&cpp_string_view3, llvm_threadlocal_address_p0.Invoke(internal_signal_buffer.Pointer), 29L);
		unchecked
		{
			Struct_kqhe8i struct_kqhe8i = Get_signal_string_int_cpp_span_char.Invoke(sig_num, *(void**)(&cpp_string_view3), ((long*)(&cpp_string_view3))[1]);
			cpp_string_view* num = &cpp_string_view2;
			Struct_kqhe8i struct_kqhe8i2 = struct_kqhe8i;
			*(void**)num = struct_kqhe8i2.field_0;
			byte* num2 = (byte*)(&cpp_string_view2) + 8u;
			Struct_kqhe8i struct_kqhe8i3 = struct_kqhe8i;
			*(long*)num2 = struct_kqhe8i3.field_1;
			return *(Struct_kqhe8i*)(&cpp_string_view2);
		}
	}
}
