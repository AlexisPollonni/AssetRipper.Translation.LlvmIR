using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal26nan_mantissa_from_ncharseqIfEENS_6fputil6FPBitsIT_E11StorageTypeENS_3cpp11string_viewE")]
[DemangledName("__llvm_libc_20_1_2_::fputil::FPBits<float>::StorageType __llvm_libc_20_1_2_::internal::nan_mantissa_from_ncharseq<float>(__llvm_libc_20_1_2_::cpp::string_view)")]
internal static partial class fputil_FPBits_float_StorageType_internal_nan_mantissa_from_ncharseq_float_cpp_string_view
{
	public unsafe static int Invoke([MangledName("ncharseq.coerce0")] void* ncharseq, [MangledName("ncharseq.coerce1")] long nan_mantissa)
	{
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		int num = 0;
		StrToNumResult_yrtfty strToNumResult_yrtfty = default(StrToNumResult_yrtfty);
		unchecked
		{
			*(void**)(&cpp_string_view2) = ncharseq;
			((long*)(&cpp_string_view2))[1] = nan_mantissa;
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = 0;
			if (cpp_string_view_data_const.Invoke(&cpp_string_view2) != null && internal_isdigit_int_25.Invoke(*(sbyte*)cpp_string_view_operator_unsigned_long_const.Invoke(&cpp_string_view2, 0L)))
			{
				llvm_lifetime_start_p0.Invoke(16L, &strToNumResult_yrtfty);
				*(int*)(&strToNumResult_yrtfty) = -1431655766;
				((int*)(&strToNumResult_yrtfty))[1] = -1431655766;
				((long*)(&strToNumResult_yrtfty))[1] = -6148914691236517206L;
				Struct_fiz2nb struct_fiz2nb = StrToNumResult_unsigned_int_internal_strtointeger_unsigned_int_char_const_int_unsigned_long.Invoke(cpp_string_view_data_const.Invoke(&cpp_string_view2), 0, cpp_internal_integer_impl_unsigned_long_0ul_18446744073709551615ul_max.Invoke());
				StrToNumResult_yrtfty* num2 = &strToNumResult_yrtfty;
				Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
				*(long*)num2 = struct_fiz2nb2.field_0;
				byte* num3 = (byte*)(&strToNumResult_yrtfty) + 8u;
				Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
				*(long*)num3 = struct_fiz2nb3.field_1;
				if (!StrToNumResult_unsigned_int_has_error.Invoke(&strToNumResult_yrtfty))
				{
					num = strToNumResult_yrtfty.value;
				}
				if (strToNumResult_yrtfty.parsed_len != cpp_string_view_size_const.Invoke(&cpp_string_view2))
				{
					num = 0;
				}
				llvm_lifetime_end_p0.Invoke(16L, &strToNumResult_yrtfty);
			}
			int result = num;
			llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
