using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal12strtointegerIoEENS_14StrToNumResultIT_EEPKcim")]
[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<unsigned __int128> __llvm_libc_20_1_2_::internal::strtointeger<unsigned __int128>(char const*, int, unsigned long)")]
internal static partial class StrToNumResult_unsigned_int128_internal_strtointeger_unsigned_int128_char_const_int_unsigned_long
{
	public unsafe static void Invoke([MangledName("agg.result")] StrToNumResult_i4jxtt* agg_result, void* src, int @base, long src_len)
	{
		Int128 @int = default(Int128);
		sbyte b = 0;
		long num = 0L;
		int num2 = 0;
		Int128 int2 = default(Int128);
		Int128 int3 = default(Int128);
		sbyte b2 = 0;
		sbyte b3 = 0;
		sbyte b4 = 0;
		Int128 int4 = default(Int128);
		Int128 int5 = default(Int128);
		Int128 trueValue = default(Int128);
		Int128 y = default(Int128);
		int num3 = 0;
		long num4 = 0L;
		Int128 int6 = default(Int128);
		Int128 int7 = default(Int128);
		Int128 int8 = default(Int128);
		Int128 int9 = default(Int128);
		Int128 int10 = default(Int128);
		int num5 = @base;
		llvm_lifetime_start_p0.Invoke(16L, &@int);
		@int = 0L;
		llvm_lifetime_start_p0.Invoke(1L, &b);
		b = 0;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = 0L;
		llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = 0;
		unchecked
		{
			if (src_len == 0L)
			{
				int2 = 0L;
				StrToNumResult_unsigned_int128_StrToNumResult_unsigned_int128_long_int.Invoke(agg_result, *(long*)(&int2), ((long*)(&int2))[1], 0L, 0);
			}
			else if (num5 < 0 || num5 == 1 || num5 > 36)
			{
				int3 = 0L;
				StrToNumResult_unsigned_int128_StrToNumResult_unsigned_int128_long_int.Invoke(agg_result, *(long*)(&int3), ((long*)(&int3))[1], 0L, 22);
			}
			else
			{
				num = (long)internal_first_non_whitespace_char_const_unsigned_long.Invoke(src, src_len) - (long)src;
				llvm_lifetime_start_p0.Invoke(1L, &b2);
				b2 = 43;
				if (((sbyte*)src)[num] == 43 || ((sbyte*)src)[num] == 45)
				{
					b2 = ((sbyte*)src)[num];
					num++;
				}
				if (num5 == 0)
				{
					num5 = internal_infer_base_char_const_unsigned_long.Invoke((byte*)src + num, src_len - num);
				}
				if (num5 == 16 && internal_is_hex_start_char_const_unsigned_long.Invoke((byte*)src + num, src_len - num))
				{
					num += 2L;
				}
				llvm_lifetime_start_p0.Invoke(1L, &b3);
				b3 = 1;
				llvm_lifetime_start_p0.Invoke(1L, &b4);
				b4 = ((b2 == 43) ? ((sbyte)1) : ((sbyte)0));
				llvm_lifetime_start_p0.Invoke(16L, &int4);
				int4 = -1L;
				llvm_lifetime_start_p0.Invoke(16L, &int5);
				bool condition = (b4 & 1) == 1;
				Struct_fiz2nb struct_fiz2nb = cpp_internal_integer_impl_unsigned_int128_unsigned_int128_0_unsigned_int128_340282366920938463463374607431768211455_max.Invoke();
				Int128* num6 = &trueValue;
				Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
				*(long*)num6 = struct_fiz2nb2.field_0;
				byte* num7 = (byte*)(&trueValue) + 8u;
				Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
				*(long*)num7 = struct_fiz2nb3.field_1;
				int5 = InstructionHelper.Select(condition, trueValue, -1L);
				llvm_lifetime_start_p0.Invoke(16L, &y);
				y = NumericHelper.DivideUnsigned(int5, num5);
				while ((ulong)num < (ulong)src_len && internal_isalnum_int.Invoke(((sbyte*)src)[num]))
				{
					llvm_lifetime_start_p0.Invoke(4L, &num3);
					num3 = internal_b36_char_to_int_int.Invoke(((sbyte*)src)[num]);
					int num8;
					if (num3 >= num5)
					{
						num8 = 3;
					}
					else
					{
						b = 1;
						num++;
						if (NumericHelper.IntCmpEq(@int, int5))
						{
							num2 = 34;
							num8 = 2;
						}
						else
						{
							if (NumericHelper.IntCmpUgt(@int, y))
							{
								@int = int5;
								num2 = 34;
							}
							else
							{
								@int = NumericHelper.Multiply(@int, num5);
							}
							if (NumericHelper.IntCmpUgt(@int, NumericHelper.Subtract(int5, num3)))
							{
								@int = int5;
								num2 = 34;
							}
							else
							{
								@int = NumericHelper.Add(@int, num3);
							}
							num8 = 0;
						}
					}
					llvm_lifetime_end_p0.Invoke(4L, &num3);
					switch (num8)
					{
					case 0:
					case 2:
						continue;
					case 3:
						break;
					default:
						throw new NotImplementedException("Reached LLVM unreachable instruction.");
					}
					break;
				}
				llvm_lifetime_start_p0.Invoke(8L, &num4);
				num4 = (((b & 1) != 1) ? 0L : num);
				if (num2 == 34)
				{
					if ((b4 & 1) == 1 || uint.MaxValue != 0)
					{
						Struct_fiz2nb struct_fiz2nb4 = cpp_internal_integer_impl_unsigned_int128_unsigned_int128_0_unsigned_int128_340282366920938463463374607431768211455_max.Invoke();
						Int128* num9 = &int6;
						Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
						*(long*)num9 = struct_fiz2nb5.field_0;
						byte* num10 = (byte*)(&int6) + 8u;
						Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
						*(long*)num10 = struct_fiz2nb6.field_1;
						Int128 int11 = int6;
						long error_hm8b8a = num4;
						int error_xz3rmz = num2;
						int7 = int11;
						StrToNumResult_unsigned_int128_StrToNumResult_unsigned_int128_long_int.Invoke(agg_result, *(long*)(&int7), ((long*)(&int7))[1], error_hm8b8a, error_xz3rmz);
					}
					else
					{
						cpp_internal_integer_impl_unsigned_int128_unsigned_int128_0_unsigned_int128_340282366920938463463374607431768211455_min.Invoke();
						Struct_fiz2nb struct_fiz2nb7;
						*(long*)(&int8) = struct_fiz2nb7.field_0;
						Struct_fiz2nb struct_fiz2nb8;
						((long*)(&int8))[1] = struct_fiz2nb8.field_1;
						int9 = int8;
						_ = *(long*)(&int9);
						_ = ((long*)(&int9))[1];
						long value;
						long parsed_len;
						long error_hm8b8a2;
						int error_xz3rmz2;
						StrToNumResult_unsigned_int128_StrToNumResult_unsigned_int128_long_int.Invoke(agg_result, value, parsed_len, error_hm8b8a2, error_xz3rmz2);
					}
				}
				else
				{
					Int128 obj = (((b4 & 1) != 1) ? NumericHelper.Subtract(y: @int, x: 0L) : @int);
					long error_hm8b8a3 = num4;
					int error_xz3rmz3 = num2;
					int10 = obj;
					StrToNumResult_unsigned_int128_StrToNumResult_unsigned_int128_long_int.Invoke(agg_result, *(long*)(&int10), ((long*)(&int10))[1], error_hm8b8a3, error_xz3rmz3);
				}
				llvm_lifetime_end_p0.Invoke(8L, &num4);
				llvm_lifetime_end_p0.Invoke(16L, &y);
				llvm_lifetime_end_p0.Invoke(16L, &int5);
				llvm_lifetime_end_p0.Invoke(16L, &int4);
				llvm_lifetime_end_p0.Invoke(1L, &b4);
				llvm_lifetime_end_p0.Invoke(1L, &b3);
				llvm_lifetime_end_p0.Invoke(1L, &b2);
			}
			llvm_lifetime_end_p0.Invoke(4L, &num2);
			llvm_lifetime_end_p0.Invoke(8L, &num);
			llvm_lifetime_end_p0.Invoke(1L, &b);
			llvm_lifetime_end_p0.Invoke(16L, &@int);
		}
	}
}
