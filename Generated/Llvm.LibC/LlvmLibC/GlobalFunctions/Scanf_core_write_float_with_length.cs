using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Scanf_core_write_float_with_length
{
	[MangledName("_ZN19__llvm_libc_20_1_2_10scanf_core23write_float_with_lengthEPcRKNS0_13FormatSectionE")]
	[DemangledName("__llvm_libc_20_1_2_::scanf_core::write_float_with_length(char*, __llvm_libc_20_1_2_::scanf_core::FormatSection const&)")]
	public unsafe static void Invoke([MangledName("str")][NativeType("char*")] void* Str, [MangledName("to_conv")][NativeType("__llvm_libc_20_1_2_::scanf_core::FormatSection const&")] Scanf_core_FormatSection* To_conv)
	{
		void* ptr = null;
		int num = 0;
		StrToNumResult_k826n6 strToNumResult_k826n = default(StrToNumResult_k826n6);
		StrToNumResult_uytq62 strToNumResult_uytq = default(StrToNumResult_uytq62);
		StrToNumResult_cqc3yy strToNumResult_cqc3yy = default(StrToNumResult_cqc3yy);
		unchecked
		{
			if (((byte)To_conv->Flags & 1) == 0)
			{
				Llvm_lifetime_start_p0.Invoke(8L, &ptr);
				ptr = To_conv->Output_ptr;
				Llvm_lifetime_start_p0.Invoke(4L, &num);
				num = (int)To_conv->Length_modifier;
				switch (num)
				{
				case 2:
				{
					Llvm_lifetime_start_p0.Invoke(24L, &strToNumResult_k826n);
					*(double*)(&strToNumResult_k826n) = double.NaN;
					((int*)(&strToNumResult_k826n))[2] = -1431655766;
					sbyte* ptr3 = (sbyte*)(&strToNumResult_k826n) + 12;
					*ptr3 = -86;
					ptr3[1] = -86;
					ptr3[2] = -86;
					ptr3[3] = -86;
					((long*)(&strToNumResult_k826n))[2] = -6148914691236517206L;
					Internal_strtofloatingpoint_double.Invoke(&strToNumResult_k826n, Str);
					double num6 = StrToNumResult_double_ToDouble.Invoke(&strToNumResult_k826n);
					*(double*)ptr = num6;
					Llvm_lifetime_end_p0.Invoke(24L, &strToNumResult_k826n);
					break;
				}
				case 7:
				{
					Llvm_lifetime_start_p0.Invoke(32L, &strToNumResult_uytq);
					*(double*)(&strToNumResult_uytq) = double.NaN;
					((int*)(&strToNumResult_uytq))[4] = -1431655766;
					sbyte* ptr2 = (sbyte*)(&strToNumResult_uytq) + 20;
					*ptr2 = -86;
					ptr2[1] = -86;
					ptr2[2] = -86;
					ptr2[3] = -86;
					((long*)(&strToNumResult_uytq))[3] = -6148914691236517206L;
					Internal_strtofloatingpoint_long_double.Invoke(&strToNumResult_uytq, Str);
					double num5 = StrToNumResult_long_double_Long_double.Invoke(&strToNumResult_uytq);
					*(double*)ptr = num5;
					Llvm_lifetime_end_p0.Invoke(32L, &strToNumResult_uytq);
					break;
				}
				default:
				{
					Llvm_lifetime_start_p0.Invoke(16L, &strToNumResult_cqc3yy);
					*(float*)(&strToNumResult_cqc3yy) = float.NaN;
					((int*)(&strToNumResult_cqc3yy))[1] = -1431655766;
					((long*)(&strToNumResult_cqc3yy))[1] = -6148914691236517206L;
					Struct_fiz2nb struct_fiz2nb = Internal_strtofloatingpoint_float.Invoke(Str);
					StrToNumResult_cqc3yy* num2 = &strToNumResult_cqc3yy;
					Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
					*(long*)num2 = struct_fiz2nb2.field_0;
					byte* num3 = (byte*)(&strToNumResult_cqc3yy) + 8u;
					Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
					*(long*)num3 = struct_fiz2nb3.field_1;
					float num4 = StrToNumResult_float_ToSingle.Invoke(&strToNumResult_cqc3yy);
					*(float*)ptr = num4;
					Llvm_lifetime_end_p0.Invoke(16L, &strToNumResult_cqc3yy);
					break;
				}
				}
				Llvm_lifetime_end_p0.Invoke(4L, &num);
				Llvm_lifetime_end_p0.Invoke(8L, &ptr);
			}
		}
	}
}
