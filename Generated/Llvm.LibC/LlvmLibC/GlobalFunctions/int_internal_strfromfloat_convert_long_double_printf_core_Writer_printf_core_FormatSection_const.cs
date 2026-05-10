using System;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal20strfromfloat_convertIeEEiPNS_11printf_core6WriterERKNS2_13FormatSectionE")]
[DemangledName("int __llvm_libc_20_1_2_::internal::strfromfloat_convert<long double>(__llvm_libc_20_1_2_::printf_core::Writer*, __llvm_libc_20_1_2_::printf_core::FormatSection const&)")]
internal static partial class int_internal_strfromfloat_convert_long_double_printf_core_Writer_printf_core_FormatSection_const
{
	public unsafe static int Invoke(void* writer, void* section)
	{
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		Int128 @int = default(Int128);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(fputil_FPBits_ubgsi2);
		Int128 int2 = default(Int128);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi4 = default(fputil_FPBits_ubgsi2);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi5 = default(fputil_FPBits_ubgsi2);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi6 = default(fputil_FPBits_ubgsi2);
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
				llvm_lifetime_start_p0.Invoke(16L, &@int);
				@int = ((printf_core_FormatSection*)section)->conv_val_raw;
				llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
				*(Int128*)(&fputil_FPBits_ubgsi3) = -6148914691236517206L;
				int2 = @int;
				fputil_FPBits_long_double_FPBits_unsigned_int128_unsigned_int128.Invoke(&fputil_FPBits_ubgsi3, *(long*)(&int2), ((long*)(&int2))[1]);
				if (fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_is_inf_or_nan_const.Invoke(&fputil_FPBits_ubgsi3))
				{
					result = printf_core_convert_inf_nan_printf_core_Writer_printf_core_FormatSection_const.Invoke(writer, section);
				}
				else
				{
					switch (((printf_core_FormatSection*)section)->conv_name)
					{
					case 70:
					case 102:
						llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi4, &fputil_FPBits_ubgsi3, 16L, isVolatile: false);
						result = int_printf_core_convert_float_decimal_typed_long_double_0_printf_core_Writer_printf_core_FormatSection_const_fputil_FPBits_long_double.Invoke(writer, section, *(long*)(&fputil_FPBits_ubgsi4), ((long*)(&fputil_FPBits_ubgsi4))[1]);
						break;
					case 69:
					case 101:
						llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi5, &fputil_FPBits_ubgsi3, 16L, isVolatile: false);
						result = int_printf_core_convert_float_dec_exp_typed_long_double_0_printf_core_Writer_printf_core_FormatSection_const_fputil_FPBits_long_double.Invoke(writer, section, *(long*)(&fputil_FPBits_ubgsi5), ((long*)(&fputil_FPBits_ubgsi5))[1]);
						break;
					case 65:
					case 97:
						result = printf_core_convert_float_hex_exp_printf_core_Writer_printf_core_FormatSection_const.Invoke(writer, section);
						break;
					case 71:
					case 103:
						llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi6, &fputil_FPBits_ubgsi3, 16L, isVolatile: false);
						result = int_printf_core_convert_float_dec_auto_typed_long_double_0_printf_core_Writer_printf_core_FormatSection_const_fputil_FPBits_long_double.Invoke(writer, section, *(long*)(&fputil_FPBits_ubgsi6), ((long*)(&fputil_FPBits_ubgsi6))[1]);
						break;
					default:
						llvm_memcpy_p0_p0_i64.Invoke(&cpp_string_view3, &((printf_core_FormatSection*)section)->raw_string, 16L, isVolatile: false);
						result = printf_core_Writer_write_cpp_string_view.Invoke(writer, *(void**)(&cpp_string_view3), ((long*)(&cpp_string_view3))[1]);
						break;
					}
				}
				llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
				llvm_lifetime_end_p0.Invoke(16L, &@int);
			}
			return result;
		}
	}
}
