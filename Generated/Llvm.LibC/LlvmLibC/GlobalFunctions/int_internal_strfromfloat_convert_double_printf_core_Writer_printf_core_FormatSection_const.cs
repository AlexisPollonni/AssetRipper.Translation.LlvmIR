using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal20strfromfloat_convertIdEEiPNS_11printf_core6WriterERKNS2_13FormatSectionE")]
[DemangledName("int __llvm_libc_20_1_2_::internal::strfromfloat_convert<double>(__llvm_libc_20_1_2_::printf_core::Writer*, __llvm_libc_20_1_2_::printf_core::FormatSection const&)")]
internal static partial class int_internal_strfromfloat_convert_double_printf_core_Writer_printf_core_FormatSection_const
{
	public unsafe static int Invoke(void* writer, void* section)
	{
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		long x = 0L;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm4 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm5 = default(fputil_FPBits_wjhbrm);
		cpp_string_view cpp_string_view3 = default(cpp_string_view);
		unchecked
		{
			int result;
			if ((((printf_core_FormatSection*)section)->has_conv & 1) != 1)
			{
				llvm_memcpy_p0_p0_i64.Invoke(&cpp_string_view2, &((printf_core_FormatSection*)section)->raw_string, 16L, isVolatile: false);
				result = printf_core_Writer_write_cpp_string_view.Invoke(writer, *(void**)(&cpp_string_view2), ((long*)(&cpp_string_view2))[1]);
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(8L, &x);
				x = (long)((printf_core_FormatSection*)section)->conv_val_raw;
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
				*(long*)(&fputil_FPBits_wjhbrm2) = -6148914691236517206L;
				fputil_FPBits_double_FPBits_unsigned_long_unsigned_long.Invoke(&fputil_FPBits_wjhbrm2, x);
				if (fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_inf_or_nan_const.Invoke(&fputil_FPBits_wjhbrm2))
				{
					result = printf_core_convert_inf_nan_printf_core_Writer_printf_core_FormatSection_const.Invoke(writer, section);
				}
				else
				{
					switch (((printf_core_FormatSection*)section)->conv_name)
					{
					case 70:
					case 102:
						llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_wjhbrm3, &fputil_FPBits_wjhbrm2, 8L, isVolatile: false);
						result = int_printf_core_convert_float_decimal_typed_double_0_printf_core_Writer_printf_core_FormatSection_const_fputil_FPBits_double.Invoke(writer, section, fputil_FPBits_wjhbrm3.FPRepImpl.FPRepSem.FPStorage.val);
						break;
					case 69:
					case 101:
						llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_wjhbrm4, &fputil_FPBits_wjhbrm2, 8L, isVolatile: false);
						result = int_printf_core_convert_float_dec_exp_typed_double_0_printf_core_Writer_printf_core_FormatSection_const_fputil_FPBits_double.Invoke(writer, section, fputil_FPBits_wjhbrm4.FPRepImpl.FPRepSem.FPStorage.val);
						break;
					case 65:
					case 97:
						result = printf_core_convert_float_hex_exp_printf_core_Writer_printf_core_FormatSection_const.Invoke(writer, section);
						break;
					case 71:
					case 103:
						llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_wjhbrm5, &fputil_FPBits_wjhbrm2, 8L, isVolatile: false);
						result = int_printf_core_convert_float_dec_auto_typed_double_0_printf_core_Writer_printf_core_FormatSection_const_fputil_FPBits_double.Invoke(writer, section, fputil_FPBits_wjhbrm5.FPRepImpl.FPRepSem.FPStorage.val);
						break;
					default:
						llvm_memcpy_p0_p0_i64.Invoke(&cpp_string_view3, &((printf_core_FormatSection*)section)->raw_string, 16L, isVolatile: false);
						result = printf_core_Writer_write_cpp_string_view.Invoke(writer, *(void**)(&cpp_string_view3), ((long*)(&cpp_string_view3))[1]);
						break;
					}
				}
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
				llvm_lifetime_end_p0.Invoke(8L, &x);
			}
			return result;
		}
	}
}
