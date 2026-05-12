using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal20strfromfloat_convertIfEEiPNS_11printf_core6WriterERKNS2_13FormatSectionE")]
[DemangledName("int __llvm_libc_20_1_2_::internal::strfromfloat_convert<float>(__llvm_libc_20_1_2_::printf_core::Writer*, __llvm_libc_20_1_2_::printf_core::FormatSection const&)")]
internal static partial class int_internal_strfromfloat_convert_float_printf_core_Writer_printf_core_FormatSection_const
{
	public unsafe static int Invoke(printf_core_Writer* writer, printf_core_FormatSection* section)
	{
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		int x = 0;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs4 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs5 = default(fputil_FPBits_5nkvcs);
		cpp_string_view cpp_string_view3 = default(cpp_string_view);
		unchecked
		{
			int result;
			if ((section->has_conv & 1) != 1)
			{
				llvm_memcpy_p0_p0_i64.Invoke(&cpp_string_view2, &section->raw_string, 16L, isVolatile: false);
				result = printf_core_Writer_write_cpp_string_view.Invoke(writer, *(void**)(&cpp_string_view2), ((long*)(&cpp_string_view2))[1]);
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(4L, &x);
				x = (int)section->conv_val_raw;
				llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
				*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
				fputil_FPBits_float_FPBits_unsigned_int_unsigned_int.Invoke(&fputil_FPBits_5nkvcs2, x);
				if (fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_inf_or_nan_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2)))
				{
					result = printf_core_convert_inf_nan_printf_core_Writer_printf_core_FormatSection_const.Invoke(writer, section);
				}
				else
				{
					switch (section->conv_name)
					{
					case 70:
					case 102:
						llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_5nkvcs3, &fputil_FPBits_5nkvcs2, 4L, isVolatile: false);
						result = int_printf_core_convert_float_decimal_typed_float_0_printf_core_Writer_printf_core_FormatSection_const_fputil_FPBits_float.Invoke(writer, section, fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0);
						break;
					case 69:
					case 101:
						llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_5nkvcs4, &fputil_FPBits_5nkvcs2, 4L, isVolatile: false);
						result = int_printf_core_convert_float_dec_exp_typed_float_0_printf_core_Writer_printf_core_FormatSection_const_fputil_FPBits_float.Invoke(writer, section, fputil_FPBits_5nkvcs4.FPRepImpl.FPRepSem.field_0.field_0);
						break;
					case 65:
					case 97:
						result = printf_core_convert_float_hex_exp_printf_core_Writer_printf_core_FormatSection_const.Invoke(writer, section);
						break;
					case 71:
					case 103:
						llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_5nkvcs5, &fputil_FPBits_5nkvcs2, 4L, isVolatile: false);
						result = int_printf_core_convert_float_dec_auto_typed_float_0_printf_core_Writer_printf_core_FormatSection_const_fputil_FPBits_float.Invoke(writer, section, fputil_FPBits_5nkvcs5.FPRepImpl.FPRepSem.field_0.field_0);
						break;
					default:
						llvm_memcpy_p0_p0_i64.Invoke(&cpp_string_view3, &section->raw_string, 16L, isVolatile: false);
						result = printf_core_Writer_write_cpp_string_view.Invoke(writer, *(void**)(&cpp_string_view3), ((long*)(&cpp_string_view3))[1]);
						break;
					}
				}
				llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
				llvm_lifetime_end_p0.Invoke(4L, &x);
			}
			return result;
		}
	}
}
