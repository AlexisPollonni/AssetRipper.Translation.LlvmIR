using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Scanf_core_convert
{
	[MangledName("_ZN19__llvm_libc_20_1_2_10scanf_core7convertEPNS0_6ReaderERKNS0_13FormatSectionE")]
	[DemangledName("__llvm_libc_20_1_2_::scanf_core::convert(__llvm_libc_20_1_2_::scanf_core::Reader*, __llvm_libc_20_1_2_::scanf_core::FormatSection const&)")]
	public unsafe static int Invoke([MangledName("reader")][NativeType("__llvm_libc_20_1_2_::scanf_core::Reader*")] Scanf_core_Reader* Reader, [MangledName("to_conv")][NativeType("__llvm_libc_20_1_2_::scanf_core::FormatSection const&")] Scanf_core_FormatSection* To_conv)
	{
		int num = 0;
		Cpp_string_view cpp_string_view = default(Cpp_string_view);
		Cpp_string_view cpp_string_view2 = default(Cpp_string_view);
		Cpp_string_view cpp_string_view3 = default(Cpp_string_view);
		Cpp_string_view cpp_string_view4 = default(Cpp_string_view);
		Cpp_string_view cpp_string_view5 = default(Cpp_string_view);
		Cpp_string_view cpp_string_view6 = default(Cpp_string_view);
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 0;
		unchecked
		{
			int result;
			switch (To_conv->Conv_name)
			{
			case 37:
				String_view_Constructor.Invoke(&cpp_string_view, Str_144.Pointer);
				result = Scanf_core_raw_match.Invoke(Reader, *(void**)(&cpp_string_view), ((long*)(&cpp_string_view))[1]);
				break;
			case 115:
				String_view_Constructor.Invoke(&cpp_string_view2, Str_1_147.Pointer);
				num = Scanf_core_raw_match.Invoke(Reader, *(void**)(&cpp_string_view2), ((long*)(&cpp_string_view2))[1]);
				result = ((num == 0) ? Scanf_core_convert_string.Invoke(Reader, To_conv) : num);
				break;
			case 91:
			case 99:
				result = Scanf_core_convert_string.Invoke(Reader, To_conv);
				break;
			case 88:
			case 100:
			case 105:
			case 111:
			case 117:
			case 120:
				String_view_Constructor.Invoke(&cpp_string_view3, Str_1_147.Pointer);
				num = Scanf_core_raw_match.Invoke(Reader, *(void**)(&cpp_string_view3), ((long*)(&cpp_string_view3))[1]);
				result = ((num == 0) ? Scanf_core_convert_int.Invoke(Reader, To_conv) : num);
				break;
			case 65:
			case 69:
			case 70:
			case 71:
			case 97:
			case 101:
			case 102:
			case 103:
				String_view_Constructor.Invoke(&cpp_string_view4, Str_1_147.Pointer);
				num = Scanf_core_raw_match.Invoke(Reader, *(void**)(&cpp_string_view4), ((long*)(&cpp_string_view4))[1]);
				result = ((num == 0) ? Scanf_core_convert_float.Invoke(Reader, To_conv) : num);
				break;
			case 110:
				result = Scanf_core_convert_current_pos.Invoke(Reader, To_conv);
				break;
			case 112:
				String_view_Constructor.Invoke(&cpp_string_view5, Str_1_147.Pointer);
				num = Scanf_core_raw_match.Invoke(Reader, *(void**)(&cpp_string_view5), ((long*)(&cpp_string_view5))[1]);
				result = ((num == 0) ? Scanf_core_convert_pointer.Invoke(Reader, To_conv) : num);
				break;
			default:
				Llvm_memcpy_p0_p0_i64.Invoke(&cpp_string_view6, &To_conv->Raw_string, 16L, isVolatile: false);
				result = Scanf_core_raw_match.Invoke(Reader, *(void**)(&cpp_string_view6), ((long*)(&cpp_string_view6))[1]);
				break;
			}
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
