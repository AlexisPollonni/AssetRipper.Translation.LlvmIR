using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_nan_mantissa_from_ncharseq_float128
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal26nan_mantissa_from_ncharseqIgEENS_6fputil6FPBitsIT_E11StorageTypeENS_3cpp11string_viewE")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::FPBits<__float128>::StorageType __llvm_libc_20_1_2_::internal::nan_mantissa_from_ncharseq<__float128>(__llvm_libc_20_1_2_::cpp::string_view)")]
	[return: NativeType("__llvm_libc_20_1_2_::fputil::FPBits<__float128>::StorageType")]
	public unsafe static Struct_fiz2nb Invoke([MangledName("ncharseq.coerce0")] void* ncharseq, [MangledName("ncharseq.coerce1")][NativeType("__llvm_libc_20_1_2_::cpp::string_view")] long nan_mantissa)
	{
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		Int128 @int = default(Int128);
		StrToNumResult_i4jxtt strToNumResult_i4jxtt = default(StrToNumResult_i4jxtt);
		unchecked
		{
			*(void**)(&cpp_string_view2) = ncharseq;
			((long*)(&cpp_string_view2))[1] = nan_mantissa;
			llvm_lifetime_start_p0.Invoke(16L, &@int);
			@int = 0L;
			if (string_view_data.Invoke(&cpp_string_view2) != null && internal_isdigit_cwzqa5.Invoke(*(sbyte*)string_view_Index.Invoke(&cpp_string_view2, 0L)))
			{
				llvm_lifetime_start_p0.Invoke(32L, &strToNumResult_i4jxtt);
				*(Int128*)(&strToNumResult_i4jxtt) = -6148914691236517206L;
				((int*)(&strToNumResult_i4jxtt))[4] = -1431655766;
				sbyte* ptr = (sbyte*)(&strToNumResult_i4jxtt) + 20;
				*ptr = -86;
				ptr[1] = -86;
				ptr[2] = -86;
				ptr[3] = -86;
				((long*)(&strToNumResult_i4jxtt))[3] = -6148914691236517206L;
				internal_strtointeger_unsigned_int128.Invoke(&strToNumResult_i4jxtt, string_view_data.Invoke(&cpp_string_view2), 0, integer_impl_unsigned_long_0ul_18446744073709551615ul_max.Invoke());
				if (!StrToNumResult_unsigned_int128_has_error.Invoke(&strToNumResult_i4jxtt))
				{
					@int = strToNumResult_i4jxtt.value;
				}
				if (strToNumResult_i4jxtt.parsed_len != string_view_size.Invoke(&cpp_string_view2))
				{
					@int = 0L;
				}
				llvm_lifetime_end_p0.Invoke(32L, &strToNumResult_i4jxtt);
			}
			Int128 int2 = @int;
			llvm_lifetime_end_p0.Invoke(16L, &@int);
			return *(Struct_fiz2nb*)(&int2);
		}
	}
}
