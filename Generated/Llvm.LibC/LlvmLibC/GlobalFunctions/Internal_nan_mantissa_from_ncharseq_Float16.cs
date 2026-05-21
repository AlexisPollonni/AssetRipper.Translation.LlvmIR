using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_nan_mantissa_from_ncharseq_Float16
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal26nan_mantissa_from_ncharseqIDF16_EENS_6fputil6FPBitsIT_E11StorageTypeENS_3cpp11string_viewE")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::FPBits<_Float16>::StorageType __llvm_libc_20_1_2_::internal::nan_mantissa_from_ncharseq<_Float16>(__llvm_libc_20_1_2_::cpp::string_view)")]
	[return: NativeType("__llvm_libc_20_1_2_::fputil::FPBits<_Float16>::StorageType")]
	public unsafe static short Invoke([MangledName("ncharseq.coerce0")] void* Ncharseq, [MangledName("ncharseq.coerce1")][NativeType("__llvm_libc_20_1_2_::cpp::string_view")] long Nan_mantissa)
	{
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view = default(Llvm_libc_20_1_2_cpp_string_view);
		short num = 0;
		Llvm_libc_20_1_2_StrToNumResult_wwcts2 llvm_libc_20_1_2_StrToNumResult_wwcts = default(Llvm_libc_20_1_2_StrToNumResult_wwcts2);
		unchecked
		{
			*(void**)(&llvm_libc_20_1_2_cpp_string_view) = Ncharseq;
			((long*)(&llvm_libc_20_1_2_cpp_string_view))[1] = Nan_mantissa;
			Llvm_lifetime_start_p0.Invoke(2L, &num);
			num = 0;
			if (String_view_data.Invoke(&llvm_libc_20_1_2_cpp_string_view) != null && Internal_isdigit_gr65cp.Invoke(*(sbyte*)String_view_Index.Invoke(&llvm_libc_20_1_2_cpp_string_view, 0L)))
			{
				Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_StrToNumResult_wwcts);
				*(short*)(&llvm_libc_20_1_2_StrToNumResult_wwcts) = -21846;
				sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_StrToNumResult_wwcts) + 2;
				*ptr = -86;
				ptr[1] = -86;
				((int*)(&llvm_libc_20_1_2_StrToNumResult_wwcts))[1] = -1431655766;
				((long*)(&llvm_libc_20_1_2_StrToNumResult_wwcts))[1] = -6148914691236517206L;
				Struct_fiz2nb struct_fiz2nb = Internal_strtointeger_unsigned_short.Invoke(String_view_data.Invoke(&llvm_libc_20_1_2_cpp_string_view), 0, Integer_impl_unsigned_long_0ul_18446744073709551615ul_max.Invoke());
				Llvm_libc_20_1_2_StrToNumResult_wwcts2* num2 = &llvm_libc_20_1_2_StrToNumResult_wwcts;
				Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
				*(long*)num2 = struct_fiz2nb2.field_0;
				byte* num3 = (byte*)(&llvm_libc_20_1_2_StrToNumResult_wwcts) + 8u;
				Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
				*(long*)num3 = struct_fiz2nb3.field_1;
				if (!StrToNumResult_unsigned_short_has_error.Invoke(&llvm_libc_20_1_2_StrToNumResult_wwcts))
				{
					num = llvm_libc_20_1_2_StrToNumResult_wwcts.Value;
				}
				if (llvm_libc_20_1_2_StrToNumResult_wwcts.Parsed_len != String_view_size.Invoke(&llvm_libc_20_1_2_cpp_string_view))
				{
					num = 0;
				}
				Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_StrToNumResult_wwcts);
			}
			short result = num;
			Llvm_lifetime_end_p0.Invoke(2L, &num);
			return result;
		}
	}
}
