using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class HighPrecisionDecimal_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal20HighPrecisionDecimalC2EPKcm")]
	[DemangledName("__llvm_libc_20_1_2_::internal::HighPrecisionDecimal::HighPrecisionDecimal(char const*, unsigned long)")]
	public unsafe static void Invoke([MangledName("this")] Internal_HighPrecisionDecimal* This, [MangledName("num_string")][NativeType("char const*")] void* Num_string, [MangledName("num_len")][NativeType("unsigned long")] long Num_len)
	{
		sbyte b = 0;
		long num = 0L;
		int num2 = 0;
		StrToNumResult_imtnam strToNumResult_imtnam = default(StrToNumResult_imtnam);
		int num3 = 0;
		long num4 = 0L;
		This->Num_digits = 0;
		This->Decimal_point = 0;
		This->Truncated = 0;
		Llvm_lifetime_start_p0.Invoke(1L, &b);
		b = 0;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = 0L;
		Llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = 0;
		unchecked
		{
			while ((ulong)num < (ulong)Num_len && (Internal_isdigit_u2vjuj.Invoke(((sbyte*)Num_string)[num]) || ((sbyte*)Num_string)[num] == 46))
			{
				if (((sbyte*)Num_string)[num] == 46)
				{
					if ((b & 1) == 1)
					{
						break;
					}
					This->Decimal_point = num2;
					b = 1;
				}
				else
				{
					if (((sbyte*)Num_string)[num] == 48 && This->Num_digits == 0)
					{
						checked
						{
							This->Decimal_point += -1;
						}
						num++;
						continue;
					}
					num2++;
					if ((uint)This->Num_digits < 800u)
					{
						sbyte b2 = (sbyte)Internal_b36_char_to_int_kxqrdt.Invoke(((sbyte*)Num_string)[num]);
						((sbyte*)(&This->Digits))[(uint)This->Num_digits] = b2;
						This->Num_digits++;
					}
					else if (((sbyte*)Num_string)[num] != 48)
					{
						This->Truncated = 1;
					}
				}
				num++;
			}
			if ((b & 1) != 1)
			{
				This->Decimal_point = num2;
			}
			if ((ulong)num < (ulong)Num_len && (((sbyte*)Num_string)[num] == 101 || ((sbyte*)Num_string)[num] == 69))
			{
				num++;
				if (Internal_isdigit_u2vjuj.Invoke(((sbyte*)Num_string)[num]) || ((sbyte*)Num_string)[num] == 43 || ((sbyte*)Num_string)[num] == 45)
				{
					Llvm_lifetime_start_p0.Invoke(16L, &strToNumResult_imtnam);
					*(int*)(&strToNumResult_imtnam) = -1431655766;
					((int*)(&strToNumResult_imtnam))[1] = -1431655766;
					((long*)(&strToNumResult_imtnam))[1] = -6148914691236517206L;
					Struct_fiz2nb struct_fiz2nb = Internal_strtointeger_int.Invoke((byte*)Num_string + num, 10, Num_len - num);
					StrToNumResult_imtnam* num5 = &strToNumResult_imtnam;
					Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
					*(long*)num5 = struct_fiz2nb2.field_0;
					byte* num6 = (byte*)(&strToNumResult_imtnam) + 8u;
					Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
					*(long*)num6 = struct_fiz2nb3.field_1;
					if (!StrToNumResult_int_has_error.Invoke(&strToNumResult_imtnam))
					{
					}
					Llvm_lifetime_start_p0.Invoke(4L, &num3);
					num3 = strToNumResult_imtnam.Value;
					Llvm_lifetime_start_p0.Invoke(8L, &num4);
					checked
					{
						num4 = unchecked((long)This->Decimal_point) + unchecked((long)num3);
						if (num4 > 1073741824L)
						{
							num4 = 1073741824L;
						}
						else if (num4 < -1073741824L)
						{
							num4 = -1073741824L;
						}
					}
					This->Decimal_point = (int)num4;
					Llvm_lifetime_end_p0.Invoke(8L, &num4);
					Llvm_lifetime_end_p0.Invoke(4L, &num3);
					Llvm_lifetime_end_p0.Invoke(16L, &strToNumResult_imtnam);
				}
			}
			HighPrecisionDecimal_trim_trailing_zeroes.Invoke(This);
			Llvm_lifetime_end_p0.Invoke(4L, &num2);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			Llvm_lifetime_end_p0.Invoke(1L, &b);
		}
	}
}
