using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_nan_mantissa_from_ncharseq_float
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal26nan_mantissa_from_ncharseqIfEENS_6fputil6FPBitsIT_E11StorageTypeENS_3cpp11string_viewE")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::FPBits<float>::StorageType __llvm_libc_20_1_2_::internal::nan_mantissa_from_ncharseq<float>(__llvm_libc_20_1_2_::cpp::string_view)")]
	[return: NativeType("__llvm_libc_20_1_2_::fputil::FPBits<float>::StorageType")]
	public unsafe static int Invoke([MangledName("ncharseq.coerce0")] void* ncharseq, [MangledName("ncharseq.coerce1")][NativeType("__llvm_libc_20_1_2_::cpp::string_view")] long nan_mantissa)
	{
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		int num = 0;
		StrToNumResult_imtnam strToNumResult_imtnam = default(StrToNumResult_imtnam);
		unchecked
		{
			*(void**)(&cpp_string_view2) = ncharseq;
			((long*)(&cpp_string_view2))[1] = nan_mantissa;
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = 0;
			if (string_view_data.Invoke(&cpp_string_view2) != null && internal_isdigit_w5gm33.Invoke(*(sbyte*)string_view_Index.Invoke(&cpp_string_view2, 0L)))
			{
				llvm_lifetime_start_p0.Invoke(16L, &strToNumResult_imtnam);
				*(int*)(&strToNumResult_imtnam) = -1431655766;
				((int*)(&strToNumResult_imtnam))[1] = -1431655766;
				((long*)(&strToNumResult_imtnam))[1] = -6148914691236517206L;
				Struct_fiz2nb struct_fiz2nb = internal_strtointeger_unsigned_int.Invoke(string_view_data.Invoke(&cpp_string_view2), 0, integer_impl_unsigned_long_0ul_18446744073709551615ul_max.Invoke());
				StrToNumResult_imtnam* num2 = &strToNumResult_imtnam;
				Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
				*(long*)num2 = struct_fiz2nb2.field_0;
				byte* num3 = (byte*)(&strToNumResult_imtnam) + 8u;
				Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
				*(long*)num3 = struct_fiz2nb3.field_1;
				if (!StrToNumResult_unsigned_int_has_error.Invoke(&strToNumResult_imtnam))
				{
					num = strToNumResult_imtnam.value;
				}
				if (strToNumResult_imtnam.parsed_len != string_view_size.Invoke(&cpp_string_view2))
				{
					num = 0;
				}
				llvm_lifetime_end_p0.Invoke(16L, &strToNumResult_imtnam);
			}
			int result = num;
			llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
