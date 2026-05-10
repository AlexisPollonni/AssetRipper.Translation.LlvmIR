using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class strerror
{
	public unsafe static void* Invoke(int err_num)
	{
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		llvm_lifetime_start_p0.Invoke(16L, &cpp_string_view2);
		Struct_kqhe8i struct_kqhe8i = Get_error_string_int.Invoke(err_num);
		cpp_string_view* num = &cpp_string_view2;
		Struct_kqhe8i struct_kqhe8i2 = struct_kqhe8i;
		unchecked
		{
			*(void**)num = struct_kqhe8i2.field_0;
			byte* num2 = (byte*)(&cpp_string_view2) + 8u;
			Struct_kqhe8i struct_kqhe8i3 = struct_kqhe8i;
			*(long*)num2 = struct_kqhe8i3.field_1;
			void* result = cpp_string_view_data_const.Invoke(&cpp_string_view2);
			llvm_lifetime_end_p0.Invoke(16L, &cpp_string_view2);
			return result;
		}
	}
}
