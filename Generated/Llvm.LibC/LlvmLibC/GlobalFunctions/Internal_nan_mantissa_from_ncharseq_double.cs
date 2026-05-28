using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_nan_mantissa_from_ncharseq_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal26nan_mantissa_from_ncharseqIdEENS_6fputil6FPBitsIT_E11StorageTypeENS_3cpp11string_viewE")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::FPBits<double>::StorageType __llvm_libc_20_1_2_::internal::nan_mantissa_from_ncharseq<double>(__llvm_libc_20_1_2_::cpp::string_view)")]
	[return: NativeType("__llvm_libc_20_1_2_::fputil::FPBits<double>::StorageType")]
	public unsafe static long Invoke([MangledName("ncharseq.coerce0")] void* Ncharseq, [MangledName("ncharseq.coerce1")][NativeType("__llvm_libc_20_1_2_::cpp::string_view")] long Nan_mantissa)
	{
		Cpp_string_view cpp_string_view = default(Cpp_string_view);
		long num = 0L;
		StrToNumResult_gbeb3a strToNumResult_gbeb3a = default(StrToNumResult_gbeb3a);
		unchecked
		{
			*(void**)(&cpp_string_view) = Ncharseq;
			((long*)(&cpp_string_view))[1] = Nan_mantissa;
			Llvm_lifetime_start_p0.Invoke(8L, &num);
			num = 0L;
			if (String_view_data.Invoke(&cpp_string_view) != null && Internal_isdigit_uq275v.Invoke(*(sbyte*)String_view_Index.Invoke(&cpp_string_view, 0L)))
			{
				Llvm_lifetime_start_p0.Invoke(24L, &strToNumResult_gbeb3a);
				*(long*)(&strToNumResult_gbeb3a) = -6148914691236517206L;
				((int*)(&strToNumResult_gbeb3a))[2] = -1431655766;
				sbyte* ptr = (sbyte*)(&strToNumResult_gbeb3a) + 12;
				*ptr = -86;
				ptr[1] = -86;
				ptr[2] = -86;
				ptr[3] = -86;
				((long*)(&strToNumResult_gbeb3a))[2] = -6148914691236517206L;
				Internal_strtointeger_unsigned_long.Invoke(&strToNumResult_gbeb3a, String_view_data.Invoke(&cpp_string_view), 0, Integer_impl_unsigned_long_0ul_18446744073709551615ul_max.Invoke());
				if (!StrToNumResult_unsigned_long_has_error.Invoke(&strToNumResult_gbeb3a))
				{
					num = strToNumResult_gbeb3a.Value;
				}
				if (strToNumResult_gbeb3a.Parsed_len != String_view_size.Invoke(&cpp_string_view))
				{
					num = 0L;
				}
				Llvm_lifetime_end_p0.Invoke(24L, &strToNumResult_gbeb3a);
			}
			long result = num;
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
