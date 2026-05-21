using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class scanf_core_convert
{
	[MangledName("_ZN19__llvm_libc_20_1_2_10scanf_core7convertEPNS0_6ReaderERKNS0_13FormatSectionE")]
	[DemangledName("__llvm_libc_20_1_2_::scanf_core::convert(__llvm_libc_20_1_2_::scanf_core::Reader*, __llvm_libc_20_1_2_::scanf_core::FormatSection const&)")]
	public unsafe static int Invoke([NativeType("__llvm_libc_20_1_2_::scanf_core::Reader*")] scanf_core_Reader* reader, [NativeType("__llvm_libc_20_1_2_::scanf_core::FormatSection const&")] scanf_core_FormatSection* to_conv)
	{
		int num = 0;
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		cpp_string_view cpp_string_view3 = default(cpp_string_view);
		cpp_string_view cpp_string_view4 = default(cpp_string_view);
		cpp_string_view cpp_string_view5 = default(cpp_string_view);
		cpp_string_view cpp_string_view6 = default(cpp_string_view);
		cpp_string_view cpp_string_view7 = default(cpp_string_view);
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 0;
		unchecked
		{
			int result;
			switch (to_conv->conv_name)
			{
			case 37:
				string_view_Constructor.Invoke(&cpp_string_view2, str_144.Pointer);
				result = scanf_core_raw_match.Invoke(reader, *(void**)(&cpp_string_view2), ((long*)(&cpp_string_view2))[1]);
				break;
			case 115:
				string_view_Constructor.Invoke(&cpp_string_view3, str_1_147.Pointer);
				num = scanf_core_raw_match.Invoke(reader, *(void**)(&cpp_string_view3), ((long*)(&cpp_string_view3))[1]);
				result = ((num == 0) ? scanf_core_convert_string.Invoke(reader, to_conv) : num);
				break;
			case 91:
			case 99:
				result = scanf_core_convert_string.Invoke(reader, to_conv);
				break;
			case 88:
			case 100:
			case 105:
			case 111:
			case 117:
			case 120:
				string_view_Constructor.Invoke(&cpp_string_view4, str_1_147.Pointer);
				num = scanf_core_raw_match.Invoke(reader, *(void**)(&cpp_string_view4), ((long*)(&cpp_string_view4))[1]);
				result = ((num == 0) ? scanf_core_convert_int.Invoke(reader, to_conv) : num);
				break;
			case 65:
			case 69:
			case 70:
			case 71:
			case 97:
			case 101:
			case 102:
			case 103:
				string_view_Constructor.Invoke(&cpp_string_view5, str_1_147.Pointer);
				num = scanf_core_raw_match.Invoke(reader, *(void**)(&cpp_string_view5), ((long*)(&cpp_string_view5))[1]);
				result = ((num == 0) ? scanf_core_convert_float.Invoke(reader, to_conv) : num);
				break;
			case 110:
				result = scanf_core_convert_current_pos.Invoke(reader, to_conv);
				break;
			case 112:
				string_view_Constructor.Invoke(&cpp_string_view6, str_1_147.Pointer);
				num = scanf_core_raw_match.Invoke(reader, *(void**)(&cpp_string_view6), ((long*)(&cpp_string_view6))[1]);
				result = ((num == 0) ? scanf_core_convert_pointer.Invoke(reader, to_conv) : num);
				break;
			default:
				llvm_memcpy_p0_p0_i64.Invoke(&cpp_string_view7, &to_conv->raw_string, 16L, isVolatile: false);
				result = scanf_core_raw_match.Invoke(reader, *(void**)(&cpp_string_view7), ((long*)(&cpp_string_view7))[1]);
				break;
			}
			llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
