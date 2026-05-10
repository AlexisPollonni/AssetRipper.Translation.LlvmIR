using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal26nan_mantissa_from_ncharseqIDF16_EENS_6fputil6FPBitsIT_E11StorageTypeENS_3cpp11string_viewE")]
[DemangledName("__llvm_libc_20_1_2_::fputil::FPBits<_Float16>::StorageType __llvm_libc_20_1_2_::internal::nan_mantissa_from_ncharseq<_Float16>(__llvm_libc_20_1_2_::cpp::string_view)")]
internal static partial class fputil_FPBits_Float16_StorageType_internal_nan_mantissa_from_ncharseq_Float16_cpp_string_view
{
	public unsafe static short Invoke([MangledName("ncharseq.coerce0")] void* ncharseq, [MangledName("ncharseq.coerce1")] long nan_mantissa)
	{
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		short num = 0;
		StrToNumResult_wwcts2 strToNumResult_wwcts = default(StrToNumResult_wwcts2);
		unchecked
		{
			*(void**)(&cpp_string_view2) = ncharseq;
			((long*)(&cpp_string_view2))[1] = nan_mantissa;
			llvm_lifetime_start_p0.Invoke(2L, &num);
			num = 0;
			if (cpp_string_view_data_const.Invoke(&cpp_string_view2) != null && internal_isdigit_int_7.Invoke(*(sbyte*)cpp_string_view_operator_unsigned_long_const.Invoke(&cpp_string_view2, 0L)))
			{
				llvm_lifetime_start_p0.Invoke(16L, &strToNumResult_wwcts);
				*(short*)(&strToNumResult_wwcts) = -21846;
				sbyte* ptr = (sbyte*)(&strToNumResult_wwcts) + 2;
				*ptr = -86;
				ptr[1] = -86;
				((int*)(&strToNumResult_wwcts))[1] = -1431655766;
				((long*)(&strToNumResult_wwcts))[1] = -6148914691236517206L;
				Struct_fiz2nb struct_fiz2nb = StrToNumResult_unsigned_short_internal_strtointeger_unsigned_short_char_const_int_unsigned_long.Invoke(cpp_string_view_data_const.Invoke(&cpp_string_view2), 0, cpp_internal_integer_impl_unsigned_long_0ul_18446744073709551615ul_max.Invoke());
				StrToNumResult_wwcts2* num2 = &strToNumResult_wwcts;
				Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
				*(long*)num2 = struct_fiz2nb2.field_0;
				byte* num3 = (byte*)(&strToNumResult_wwcts) + 8u;
				Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
				*(long*)num3 = struct_fiz2nb3.field_1;
				if (!StrToNumResult_unsigned_short_has_error.Invoke(&strToNumResult_wwcts))
				{
					num = strToNumResult_wwcts.value;
				}
				if (strToNumResult_wwcts.parsed_len != cpp_string_view_size_const.Invoke(&cpp_string_view2))
				{
					num = 0;
				}
				llvm_lifetime_end_p0.Invoke(16L, &strToNumResult_wwcts);
			}
			short result = num;
			llvm_lifetime_end_p0.Invoke(2L, &num);
			return result;
		}
	}
}
