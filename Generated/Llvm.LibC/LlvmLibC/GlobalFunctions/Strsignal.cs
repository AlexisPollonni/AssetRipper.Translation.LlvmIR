using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Strsignal
{
	[MangledName("strsignal")]
	[DemangledName("strsignal")]
	public unsafe static void* Invoke([MangledName("sig_num")] int Sig_num)
	{
		Cpp_string_view cpp_string_view = default(Cpp_string_view);
		Llvm_lifetime_start_p0.Invoke(16L, &cpp_string_view);
		Struct_kqhe8i struct_kqhe8i = Get_signal_string.Invoke(Sig_num);
		Cpp_string_view* num = &cpp_string_view;
		Struct_kqhe8i struct_kqhe8i2 = struct_kqhe8i;
		unchecked
		{
			*(void**)num = struct_kqhe8i2.field_0;
			byte* num2 = (byte*)(&cpp_string_view) + 8u;
			Struct_kqhe8i struct_kqhe8i3 = struct_kqhe8i;
			*(long*)num2 = struct_kqhe8i3.field_1;
			void* result = String_view_data.Invoke(&cpp_string_view);
			Llvm_lifetime_end_p0.Invoke(16L, &cpp_string_view);
			return result;
		}
	}
}
