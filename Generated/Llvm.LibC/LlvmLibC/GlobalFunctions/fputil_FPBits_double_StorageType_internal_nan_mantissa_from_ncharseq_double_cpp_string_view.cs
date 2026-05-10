using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal26nan_mantissa_from_ncharseqIdEENS_6fputil6FPBitsIT_E11StorageTypeENS_3cpp11string_viewE")]
[DemangledName("__llvm_libc_20_1_2_::fputil::FPBits<double>::StorageType __llvm_libc_20_1_2_::internal::nan_mantissa_from_ncharseq<double>(__llvm_libc_20_1_2_::cpp::string_view)")]
internal static partial class fputil_FPBits_double_StorageType_internal_nan_mantissa_from_ncharseq_double_cpp_string_view
{
	public unsafe static long Invoke([MangledName("ncharseq.coerce0")] void* ncharseq, [MangledName("ncharseq.coerce1")] long nan_mantissa)
	{
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		long num = 0L;
		StrToNumResult_aztiru strToNumResult_aztiru = default(StrToNumResult_aztiru);
		unchecked
		{
			*(void**)(&cpp_string_view2) = ncharseq;
			((long*)(&cpp_string_view2))[1] = nan_mantissa;
			llvm_lifetime_start_p0.Invoke(8L, &num);
			num = 0L;
			if (cpp_string_view_data_const.Invoke(&cpp_string_view2) != null && internal_isdigit_int_28.Invoke(*(sbyte*)cpp_string_view_operator_unsigned_long_const.Invoke(&cpp_string_view2, 0L)))
			{
				llvm_lifetime_start_p0.Invoke(24L, &strToNumResult_aztiru);
				*(long*)(&strToNumResult_aztiru) = -6148914691236517206L;
				((int*)(&strToNumResult_aztiru))[2] = -1431655766;
				sbyte* ptr = (sbyte*)(&strToNumResult_aztiru) + 12;
				*ptr = -86;
				ptr[1] = -86;
				ptr[2] = -86;
				ptr[3] = -86;
				((long*)(&strToNumResult_aztiru))[2] = -6148914691236517206L;
				StrToNumResult_unsigned_long_internal_strtointeger_unsigned_long_char_const_int_unsigned_long.Invoke(&strToNumResult_aztiru, cpp_string_view_data_const.Invoke(&cpp_string_view2), 0, cpp_internal_integer_impl_unsigned_long_0ul_18446744073709551615ul_max.Invoke());
				if (!StrToNumResult_unsigned_long_has_error.Invoke(&strToNumResult_aztiru))
				{
					num = strToNumResult_aztiru.value;
				}
				if (strToNumResult_aztiru.parsed_len != cpp_string_view_size_const.Invoke(&cpp_string_view2))
				{
					num = 0L;
				}
				llvm_lifetime_end_p0.Invoke(24L, &strToNumResult_aztiru);
			}
			long result = num;
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
