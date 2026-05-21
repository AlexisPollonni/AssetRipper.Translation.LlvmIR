using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class HighPrecisionDecimal_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal20HighPrecisionDecimalC2EPKcm")]
	[DemangledName("__llvm_libc_20_1_2_::internal::HighPrecisionDecimal::HighPrecisionDecimal(char const*, unsigned long)")]
	public unsafe static void Invoke(internal_HighPrecisionDecimal* @this, [NativeType("char const*")] void* num_string, [NativeType("unsigned long")] long num_len)
	{
		sbyte b = 0;
		long num = 0L;
		int num2 = 0;
		StrToNumResult_imtnam strToNumResult_imtnam = default(StrToNumResult_imtnam);
		int num3 = 0;
		long num4 = 0L;
		@this->num_digits = 0;
		@this->decimal_point = 0;
		@this->truncated = 0;
		llvm_lifetime_start_p0.Invoke(1L, &b);
		b = 0;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = 0L;
		llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = 0;
		unchecked
		{
			while ((ulong)num < (ulong)num_len && ((!internal_isdigit_u2vjuj.Invoke(((sbyte*)num_string)[num])) ? (((sbyte*)num_string)[num] == 46) : true))
			{
				if (((sbyte*)num_string)[num] == 46)
				{
					if ((b & 1) == 1)
					{
						break;
					}
					@this->decimal_point = num2;
					b = 1;
				}
				else
				{
					if (((sbyte*)num_string)[num] == 48 && @this->num_digits == 0)
					{
						checked
						{
							@this->decimal_point += -1;
						}
						num++;
						continue;
					}
					num2++;
					if ((uint)@this->num_digits < 800u)
					{
						sbyte b2 = (sbyte)internal_b36_char_to_int_kxqrdt.Invoke(((sbyte*)num_string)[num]);
						((sbyte*)(&@this->digits))[(uint)@this->num_digits] = b2;
						@this->num_digits++;
					}
					else if (((sbyte*)num_string)[num] != 48)
					{
						@this->truncated = 1;
					}
				}
				num++;
			}
			if ((b & 1) != 1)
			{
				@this->decimal_point = num2;
			}
			if ((ulong)num < (ulong)num_len && (((sbyte*)num_string)[num] == 101 || ((sbyte*)num_string)[num] == 69))
			{
				num++;
				if (internal_isdigit_u2vjuj.Invoke(((sbyte*)num_string)[num]) || ((sbyte*)num_string)[num] == 43 || ((sbyte*)num_string)[num] == 45)
				{
					llvm_lifetime_start_p0.Invoke(16L, &strToNumResult_imtnam);
					*(int*)(&strToNumResult_imtnam) = -1431655766;
					((int*)(&strToNumResult_imtnam))[1] = -1431655766;
					((long*)(&strToNumResult_imtnam))[1] = -6148914691236517206L;
					Struct_fiz2nb struct_fiz2nb = internal_strtointeger_int.Invoke((byte*)num_string + num, 10, num_len - num);
					StrToNumResult_imtnam* num5 = &strToNumResult_imtnam;
					Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
					*(long*)num5 = struct_fiz2nb2.field_0;
					byte* num6 = (byte*)(&strToNumResult_imtnam) + 8u;
					Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
					*(long*)num6 = struct_fiz2nb3.field_1;
					if (!StrToNumResult_int_has_error.Invoke(&strToNumResult_imtnam))
					{
					}
					llvm_lifetime_start_p0.Invoke(4L, &num3);
					num3 = strToNumResult_imtnam.value;
					llvm_lifetime_start_p0.Invoke(8L, &num4);
					checked
					{
						num4 = unchecked((long)@this->decimal_point) + unchecked((long)num3);
						if (num4 > 1073741824L)
						{
							num4 = 1073741824L;
						}
						else if (num4 < -1073741824L)
						{
							num4 = -1073741824L;
						}
					}
					@this->decimal_point = (int)num4;
					llvm_lifetime_end_p0.Invoke(8L, &num4);
					llvm_lifetime_end_p0.Invoke(4L, &num3);
					llvm_lifetime_end_p0.Invoke(16L, &strToNumResult_imtnam);
				}
			}
			HighPrecisionDecimal_trim_trailing_zeroes.Invoke(@this);
			llvm_lifetime_end_p0.Invoke(4L, &num2);
			llvm_lifetime_end_p0.Invoke(8L, &num);
			llvm_lifetime_end_p0.Invoke(1L, &b);
		}
	}
}
