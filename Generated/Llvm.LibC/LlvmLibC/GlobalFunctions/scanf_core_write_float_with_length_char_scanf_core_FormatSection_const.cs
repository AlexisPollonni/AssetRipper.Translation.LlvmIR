using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_10scanf_core23write_float_with_lengthEPcRKNS0_13FormatSectionE")]
[DemangledName("__llvm_libc_20_1_2_::scanf_core::write_float_with_length(char*, __llvm_libc_20_1_2_::scanf_core::FormatSection const&)")]
internal static partial class scanf_core_write_float_with_length_char_scanf_core_FormatSection_const
{
	public unsafe static void Invoke(void* str, scanf_core_FormatSection* to_conv)
	{
		void* ptr = null;
		int num = 0;
		StrToNumResult_r53a3q strToNumResult_r53a3q = default(StrToNumResult_r53a3q);
		StrToNumResult_6sg7zz strToNumResult_6sg7zz = default(StrToNumResult_6sg7zz);
		StrToNumResult_jptppf strToNumResult_jptppf = default(StrToNumResult_jptppf);
		unchecked
		{
			if (((byte)to_conv->flags & 1) == 0)
			{
				llvm_lifetime_start_p0.Invoke(8L, &ptr);
				ptr = to_conv->output_ptr;
				llvm_lifetime_start_p0.Invoke(4L, &num);
				num = (int)to_conv->length_modifier;
				switch (num)
				{
				case 2:
				{
					llvm_lifetime_start_p0.Invoke(24L, &strToNumResult_r53a3q);
					*(double*)(&strToNumResult_r53a3q) = double.NaN;
					((int*)(&strToNumResult_r53a3q))[2] = -1431655766;
					sbyte* ptr3 = (sbyte*)(&strToNumResult_r53a3q) + 12;
					*ptr3 = -86;
					ptr3[1] = -86;
					ptr3[2] = -86;
					ptr3[3] = -86;
					((long*)(&strToNumResult_r53a3q))[2] = -6148914691236517206L;
					StrToNumResult_double_internal_strtofloatingpoint_double_char_const.Invoke(&strToNumResult_r53a3q, str);
					double num6 = StrToNumResult_double_operator_double.Invoke(&strToNumResult_r53a3q);
					*(double*)ptr = num6;
					llvm_lifetime_end_p0.Invoke(24L, &strToNumResult_r53a3q);
					break;
				}
				case 7:
				{
					llvm_lifetime_start_p0.Invoke(32L, &strToNumResult_6sg7zz);
					*(double*)(&strToNumResult_6sg7zz) = double.NaN;
					((int*)(&strToNumResult_6sg7zz))[4] = -1431655766;
					sbyte* ptr2 = (sbyte*)(&strToNumResult_6sg7zz) + 20;
					*ptr2 = -86;
					ptr2[1] = -86;
					ptr2[2] = -86;
					ptr2[3] = -86;
					((long*)(&strToNumResult_6sg7zz))[3] = -6148914691236517206L;
					StrToNumResult_long_double_internal_strtofloatingpoint_long_double_char_const.Invoke(&strToNumResult_6sg7zz, str);
					double num5 = StrToNumResult_long_double_operator_long_double.Invoke(&strToNumResult_6sg7zz);
					*(double*)ptr = num5;
					llvm_lifetime_end_p0.Invoke(32L, &strToNumResult_6sg7zz);
					break;
				}
				default:
				{
					llvm_lifetime_start_p0.Invoke(16L, &strToNumResult_jptppf);
					*(float*)(&strToNumResult_jptppf) = float.NaN;
					((int*)(&strToNumResult_jptppf))[1] = -1431655766;
					((long*)(&strToNumResult_jptppf))[1] = -6148914691236517206L;
					Struct_fiz2nb struct_fiz2nb = StrToNumResult_float_internal_strtofloatingpoint_float_char_const.Invoke(str);
					StrToNumResult_jptppf* num2 = &strToNumResult_jptppf;
					Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
					*(long*)num2 = struct_fiz2nb2.field_0;
					byte* num3 = (byte*)(&strToNumResult_jptppf) + 8u;
					Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
					*(long*)num3 = struct_fiz2nb3.field_1;
					float num4 = StrToNumResult_float_operator_float.Invoke(&strToNumResult_jptppf);
					*(float*)ptr = num4;
					llvm_lifetime_end_p0.Invoke(16L, &strToNumResult_jptppf);
					break;
				}
				}
				llvm_lifetime_end_p0.Invoke(4L, &num);
				llvm_lifetime_end_p0.Invoke(8L, &ptr);
			}
		}
	}
}
