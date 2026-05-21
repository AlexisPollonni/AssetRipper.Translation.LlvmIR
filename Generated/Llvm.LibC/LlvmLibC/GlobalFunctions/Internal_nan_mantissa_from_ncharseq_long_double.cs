using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_nan_mantissa_from_ncharseq_long_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal26nan_mantissa_from_ncharseqIeEENS_6fputil6FPBitsIT_E11StorageTypeENS_3cpp11string_viewE")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::FPBits<long double>::StorageType __llvm_libc_20_1_2_::internal::nan_mantissa_from_ncharseq<long double>(__llvm_libc_20_1_2_::cpp::string_view)")]
	[return: NativeType("__llvm_libc_20_1_2_::fputil::FPBits<long double>::StorageType")]
	public unsafe static Struct_fiz2nb Invoke([MangledName("ncharseq.coerce0")] void* Ncharseq, [MangledName("ncharseq.coerce1")][NativeType("__llvm_libc_20_1_2_::cpp::string_view")] long Nan_mantissa)
	{
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view = default(Llvm_libc_20_1_2_cpp_string_view);
		Int128 @int = default(Int128);
		Llvm_libc_20_1_2_StrToNumResult_i4jxtt llvm_libc_20_1_2_StrToNumResult_i4jxtt = default(Llvm_libc_20_1_2_StrToNumResult_i4jxtt);
		unchecked
		{
			*(void**)(&llvm_libc_20_1_2_cpp_string_view) = Ncharseq;
			((long*)(&llvm_libc_20_1_2_cpp_string_view))[1] = Nan_mantissa;
			Llvm_lifetime_start_p0.Invoke(16L, &@int);
			@int = 0L;
			if (String_view_data.Invoke(&llvm_libc_20_1_2_cpp_string_view) != null && Internal_isdigit_jh6ntz.Invoke(*(sbyte*)String_view_Index.Invoke(&llvm_libc_20_1_2_cpp_string_view, 0L)))
			{
				Llvm_lifetime_start_p0.Invoke(32L, &llvm_libc_20_1_2_StrToNumResult_i4jxtt);
				*(Int128*)(&llvm_libc_20_1_2_StrToNumResult_i4jxtt) = -6148914691236517206L;
				((int*)(&llvm_libc_20_1_2_StrToNumResult_i4jxtt))[4] = -1431655766;
				sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_StrToNumResult_i4jxtt) + 20;
				*ptr = -86;
				ptr[1] = -86;
				ptr[2] = -86;
				ptr[3] = -86;
				((long*)(&llvm_libc_20_1_2_StrToNumResult_i4jxtt))[3] = -6148914691236517206L;
				Internal_strtointeger_unsigned_int128.Invoke(&llvm_libc_20_1_2_StrToNumResult_i4jxtt, String_view_data.Invoke(&llvm_libc_20_1_2_cpp_string_view), 0, Integer_impl_unsigned_long_0ul_18446744073709551615ul_max.Invoke());
				if (!StrToNumResult_unsigned_int128_has_error.Invoke(&llvm_libc_20_1_2_StrToNumResult_i4jxtt))
				{
					@int = llvm_libc_20_1_2_StrToNumResult_i4jxtt.Value;
				}
				if (llvm_libc_20_1_2_StrToNumResult_i4jxtt.Parsed_len != String_view_size.Invoke(&llvm_libc_20_1_2_cpp_string_view))
				{
					@int = 0L;
				}
				Llvm_lifetime_end_p0.Invoke(32L, &llvm_libc_20_1_2_StrToNumResult_i4jxtt);
			}
			Int128 int2 = @int;
			Llvm_lifetime_end_p0.Invoke(16L, &@int);
			return *(Struct_fiz2nb*)(&int2);
		}
	}
}
