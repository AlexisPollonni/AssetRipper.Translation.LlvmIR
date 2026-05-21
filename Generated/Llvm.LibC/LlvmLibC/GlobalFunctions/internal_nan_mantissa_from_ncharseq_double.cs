using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_nan_mantissa_from_ncharseq_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal26nan_mantissa_from_ncharseqIdEENS_6fputil6FPBitsIT_E11StorageTypeENS_3cpp11string_viewE")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::FPBits<double>::StorageType __llvm_libc_20_1_2_::internal::nan_mantissa_from_ncharseq<double>(__llvm_libc_20_1_2_::cpp::string_view)")]
	[return: NativeType("__llvm_libc_20_1_2_::fputil::FPBits<double>::StorageType")]
	public unsafe static long Invoke([MangledName("ncharseq.coerce0")] void* ncharseq, [MangledName("ncharseq.coerce1")][NativeType("__llvm_libc_20_1_2_::cpp::string_view")] long nan_mantissa)
	{
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		long num = 0L;
		StrToNumResult_gbeb3a strToNumResult_gbeb3a = default(StrToNumResult_gbeb3a);
		unchecked
		{
			*(void**)(&cpp_string_view2) = ncharseq;
			((long*)(&cpp_string_view2))[1] = nan_mantissa;
			llvm_lifetime_start_p0.Invoke(8L, &num);
			num = 0L;
			if (string_view_data.Invoke(&cpp_string_view2) != null && internal_isdigit_uq275v.Invoke(*(sbyte*)string_view_Index.Invoke(&cpp_string_view2, 0L)))
			{
				llvm_lifetime_start_p0.Invoke(24L, &strToNumResult_gbeb3a);
				*(long*)(&strToNumResult_gbeb3a) = -6148914691236517206L;
				((int*)(&strToNumResult_gbeb3a))[2] = -1431655766;
				sbyte* ptr = (sbyte*)(&strToNumResult_gbeb3a) + 12;
				*ptr = -86;
				ptr[1] = -86;
				ptr[2] = -86;
				ptr[3] = -86;
				((long*)(&strToNumResult_gbeb3a))[2] = -6148914691236517206L;
				internal_strtointeger_unsigned_long.Invoke(&strToNumResult_gbeb3a, string_view_data.Invoke(&cpp_string_view2), 0, integer_impl_unsigned_long_0ul_18446744073709551615ul_max.Invoke());
				if (!StrToNumResult_unsigned_long_has_error.Invoke(&strToNumResult_gbeb3a))
				{
					num = strToNumResult_gbeb3a.value;
				}
				if (strToNumResult_gbeb3a.parsed_len != string_view_size.Invoke(&cpp_string_view2))
				{
					num = 0L;
				}
				llvm_lifetime_end_p0.Invoke(24L, &strToNumResult_gbeb3a);
			}
			long result = num;
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
