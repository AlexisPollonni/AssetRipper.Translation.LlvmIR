using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_nan_mantissa_from_ncharseq_float
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal26nan_mantissa_from_ncharseqIfEENS_6fputil6FPBitsIT_E11StorageTypeENS_3cpp11string_viewE")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::FPBits<float>::StorageType __llvm_libc_20_1_2_::internal::nan_mantissa_from_ncharseq<float>(__llvm_libc_20_1_2_::cpp::string_view)")]
	[return: NativeType("__llvm_libc_20_1_2_::fputil::FPBits<float>::StorageType")]
	public unsafe static int Invoke([MangledName("ncharseq.coerce0")] void* Ncharseq, [MangledName("ncharseq.coerce1")][NativeType("__llvm_libc_20_1_2_::cpp::string_view")] long Nan_mantissa)
	{
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view = default(Llvm_libc_20_1_2_cpp_string_view);
		int num = 0;
		Llvm_libc_20_1_2_StrToNumResult_imtnam llvm_libc_20_1_2_StrToNumResult_imtnam = default(Llvm_libc_20_1_2_StrToNumResult_imtnam);
		unchecked
		{
			*(void**)(&llvm_libc_20_1_2_cpp_string_view) = Ncharseq;
			((long*)(&llvm_libc_20_1_2_cpp_string_view))[1] = Nan_mantissa;
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = 0;
			if (String_view_data.Invoke(&llvm_libc_20_1_2_cpp_string_view) != null && Internal_isdigit_w5gm33.Invoke(*(sbyte*)String_view_Index.Invoke(&llvm_libc_20_1_2_cpp_string_view, 0L)))
			{
				Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_StrToNumResult_imtnam);
				*(int*)(&llvm_libc_20_1_2_StrToNumResult_imtnam) = -1431655766;
				((int*)(&llvm_libc_20_1_2_StrToNumResult_imtnam))[1] = -1431655766;
				((long*)(&llvm_libc_20_1_2_StrToNumResult_imtnam))[1] = -6148914691236517206L;
				Struct_fiz2nb struct_fiz2nb = Internal_strtointeger_unsigned_int.Invoke(String_view_data.Invoke(&llvm_libc_20_1_2_cpp_string_view), 0, Integer_impl_unsigned_long_0ul_18446744073709551615ul_max.Invoke());
				Llvm_libc_20_1_2_StrToNumResult_imtnam* num2 = &llvm_libc_20_1_2_StrToNumResult_imtnam;
				Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
				*(long*)num2 = struct_fiz2nb2.field_0;
				byte* num3 = (byte*)(&llvm_libc_20_1_2_StrToNumResult_imtnam) + 8u;
				Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
				*(long*)num3 = struct_fiz2nb3.field_1;
				if (!StrToNumResult_unsigned_int_has_error.Invoke(&llvm_libc_20_1_2_StrToNumResult_imtnam))
				{
					num = llvm_libc_20_1_2_StrToNumResult_imtnam.Value;
				}
				if (llvm_libc_20_1_2_StrToNumResult_imtnam.Parsed_len != String_view_size.Invoke(&llvm_libc_20_1_2_cpp_string_view))
				{
					num = 0;
				}
				Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_StrToNumResult_imtnam);
			}
			int result = num;
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
