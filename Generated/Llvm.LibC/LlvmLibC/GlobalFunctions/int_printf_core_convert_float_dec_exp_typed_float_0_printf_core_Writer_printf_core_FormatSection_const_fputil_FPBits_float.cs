using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core27convert_float_dec_exp_typedIfTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEEiPNS0_6WriterERKNS0_13FormatSectionENS_6fputil6FPBitsIS4_EE")]
[DemangledName("int __llvm_libc_20_1_2_::printf_core::convert_float_dec_exp_typed<float, 0>(__llvm_libc_20_1_2_::printf_core::Writer*, __llvm_libc_20_1_2_::printf_core::FormatSection const&, __llvm_libc_20_1_2_::fputil::FPBits<float>)")]
internal static partial class int_printf_core_convert_float_dec_exp_typed_float_0_printf_core_Writer_printf_core_FormatSection_const_fputil_FPBits_float
{
	public unsafe static int Invoke(printf_core_Writer* writer, printf_core_FormatSection* to_conv, [MangledName("float_bits.coerce")] int float_bits)
	{
		int result = 0;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		int num = 0;
		int num2 = 0;
		Int128 x = default(Int128);
		sbyte init_sign_char = 0;
		int num3 = 0;
		sbyte b = 0;
		printf_core_PaddingWriter printf_core_PaddingWriter2 = default(printf_core_PaddingWriter);
		printf_core_FloatWriter printf_core_FloatWriter2 = default(printf_core_FloatWriter);
		FloatToString_vnf553 floatToString_vnf = default(FloatToString_vnf553);
		long num4 = 0L;
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		long num8 = 0L;
		IntegerToString_uuwdyc integerToString_uuwdyc = default(IntegerToString_uuwdyc);
		int num9 = 0;
		long num10 = 0L;
		IntegerToString_uuwdyc integerToString_uuwdyc2 = default(IntegerToString_uuwdyc);
		int num11 = 0;
		long num12 = 0L;
		IntegerToString_uuwdyc integerToString_uuwdyc3 = default(IntegerToString_uuwdyc);
		sbyte b2 = 0;
		long num13 = 0L;
		int num14 = 0;
		int i = 0;
		int num15 = 0;
		int num16 = 0;
		int j = 0;
		int num17 = 0;
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		int num18 = 0;
		int num19 = 0;
		fputil_FPBits_5nkvcs2.FPRepImpl.FPRepSem.field_0.field_0 = float_bits;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 23;
		llvm_lifetime_start_p0.Invoke(4L, &num2);
		unchecked
		{
			num2 = fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_explicit_exponent_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2));
			llvm_lifetime_start_p0.Invoke(16L, &x);
			x = (Int128)(UInt128)(uint)fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_get_explicit_mantissa_const.Invoke(&fputil_FPBits_5nkvcs2);
			llvm_lifetime_start_p0.Invoke(1L, &init_sign_char);
			init_sign_char = 0;
			if (fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_neg_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2)))
			{
				init_sign_char = 45;
			}
			else if (((byte)to_conv->flags & 2) == 2)
			{
				init_sign_char = 43;
			}
			else if (((byte)to_conv->flags & 4) == 4)
			{
				init_sign_char = 32;
			}
			llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = ((to_conv->precision >= 0) ? to_conv->precision : 6);
			llvm_lifetime_start_p0.Invoke(1L, &b);
			b = (sbyte)(byte)((num3 == 0) ? ((((byte)to_conv->flags & 8) != 0) ? 1 : 0) : (-1));
			llvm_lifetime_start_p0.Invoke(16L, &printf_core_PaddingWriter2);
			*(sbyte*)(&printf_core_PaddingWriter2) = -86;
			((sbyte*)(&printf_core_PaddingWriter2))[1] = -86;
			((sbyte*)(&printf_core_PaddingWriter2))[2] = -86;
			sbyte* ptr = (sbyte*)(&printf_core_PaddingWriter2) + 3;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			ptr[3] = -86;
			ptr[4] = -86;
			((long*)(&printf_core_PaddingWriter2))[1] = -6148914691236517206L;
			printf_core_PaddingWriter_PaddingWriter_printf_core_FormatSection_const_char.Invoke(&printf_core_PaddingWriter2, to_conv, init_sign_char);
			llvm_lifetime_start_p0.Invoke(96L, &printf_core_FloatWriter2);
			llvm_memset_p0_i64.Invoke(&printf_core_FloatWriter2, -86, 96L, isVolatile: false);
			printf_core_FloatWriter_FloatWriter_printf_core_Writer_bool_printf_core_PaddingWriter_const.Invoke(&printf_core_FloatWriter2, writer, (b & 1) == 1, &printf_core_PaddingWriter2);
			llvm_lifetime_start_p0.Invoke(32L, &floatToString_vnf);
			*(int*)(&floatToString_vnf) = -1431655766;
			((int*)(&floatToString_vnf))[1] = -1431655766;
			sbyte* ptr2 = (sbyte*)(&floatToString_vnf) + 8;
			*ptr2 = -86;
			ptr2[1] = -86;
			ptr2[2] = -86;
			ptr2[3] = -86;
			ptr2[4] = -86;
			ptr2[5] = -86;
			ptr2[6] = -86;
			ptr2[7] = -86;
			*(Int128*)((byte*)(&floatToString_vnf) + 16) = -6148914691236517206L;
			FloatToString_float_0_FloatToString_float.Invoke(&floatToString_vnf, fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs2));
			llvm_lifetime_start_p0.Invoke(8L, &num4);
			num4 = 0L;
			llvm_lifetime_start_p0.Invoke(4L, &num5);
			num5 = 0;
			llvm_lifetime_start_p0.Invoke(4L, &num6);
			num6 = -1431655766;
			num6 = (int)((num2 >= 0) ? FloatToString_float_0_get_positive_blocks.Invoke(&floatToString_vnf) : checked(-unchecked((int)FloatToString_float_0_zero_blocks_after_point.Invoke(&floatToString_vnf))));
			llvm_lifetime_start_p0.Invoke(4L, &num7);
			num7 = 0;
			if (NumericHelper.IntCmpNe(x, 0L))
			{
				while (num7 == 0)
				{
					num6 = checked(num6 + -1);
					num7 = FloatToString_float_0_get_block_int.Invoke(&floatToString_vnf, num6);
				}
			}
			else
			{
				num6 = 0;
			}
			llvm_lifetime_start_p0.Invoke(8L, &num8);
			llvm_lifetime_start_p0.Invoke(32L, &integerToString_uuwdyc);
			IntegerToString_long_details_Fmt_unsigned_char_10_false_false_false_1ul_IntegerToString_long.Invoke(&integerToString_uuwdyc, (uint)num7);
			long num20 = IntegerToString_long_details_Fmt_unsigned_char_10_false_false_false_1ul_size_const.Invoke(&integerToString_uuwdyc);
			llvm_lifetime_end_p0.Invoke(32L, &integerToString_uuwdyc);
			num8 = num20;
		}
		num5 = unchecked((int)(num6 * 9L)) + unchecked((int)(num8 - 1L));
		llvm_lifetime_start_p0.Invoke(4L, &num9);
		num9 = ((num5 >= 0) ? num5 : (-num5));
		llvm_lifetime_start_p0.Invoke(8L, &num10);
		llvm_lifetime_start_p0.Invoke(32L, &integerToString_uuwdyc2);
		IntegerToString_long_details_Fmt_unsigned_char_10_false_false_false_1ul_IntegerToString_long.Invoke(&integerToString_uuwdyc2, num9);
		long num21 = IntegerToString_long_details_Fmt_unsigned_char_10_false_false_false_1ul_size_const.Invoke(&integerToString_uuwdyc2);
		llvm_lifetime_end_p0.Invoke(32L, &integerToString_uuwdyc2);
		num10 = num21;
		unchecked
		{
			printf_core_FloatWriter_init_unsigned_long_unsigned_long.Invoke(&printf_core_FloatWriter2, (uint)(checked(1 + InstructionHelper.Select((b & 1) == 1, 1, 0)) + num3 + 2) + (((ulong)num10 >= 2uL) ? num10 : 2L), 1L);
			if ((ulong)num8 <= (ulong)(uint)(num3 + 1))
			{
				printf_core_FloatWriter_write_first_block_unsigned_int_bool.Invoke(&printf_core_FloatWriter2, num7, exp_format: true);
				num4 += num8;
				num6 = checked(num6 + -1);
			}
			while (true)
			{
				int num22;
				if ((ulong)(num4 + 9L) < (ulong)(uint)(num3 + 1))
				{
					num7 = FloatToString_float_0_get_block_int.Invoke(&floatToString_vnf, num6);
					llvm_lifetime_start_p0.Invoke(4L, &num11);
					num11 = printf_core_FloatWriter_write_middle_block_unsigned_int.Invoke(&printf_core_FloatWriter2, num7);
					if (num11 < 0)
					{
						result = num11;
						num22 = 1;
					}
					else
					{
						num22 = 0;
					}
					llvm_lifetime_end_p0.Invoke(4L, &num11);
					switch (num22)
					{
					case 0:
						goto IL_05a4;
					}
					break;
				}
				num7 = FloatToString_float_0_get_block_int.Invoke(&floatToString_vnf, num6);
				llvm_lifetime_start_p0.Invoke(8L, &num12);
				num12 = 9L;
				if (num4 == 0L)
				{
					llvm_lifetime_start_p0.Invoke(32L, &integerToString_uuwdyc3);
					IntegerToString_long_details_Fmt_unsigned_char_10_false_false_false_1ul_IntegerToString_long.Invoke(&integerToString_uuwdyc3, (uint)num7);
					num12 = IntegerToString_long_details_Fmt_unsigned_char_10_false_false_false_1ul_size_const.Invoke(&integerToString_uuwdyc3);
					llvm_lifetime_end_p0.Invoke(32L, &integerToString_uuwdyc3);
				}
				llvm_lifetime_start_p0.Invoke(1L, &b2);
				b2 = 0;
				llvm_lifetime_start_p0.Invoke(8L, &num13);
				num13 = (uint)(num3 + 1) - num4;
				llvm_lifetime_start_p0.Invoke(4L, &num14);
				num14 = 0;
				llvm_lifetime_start_p0.Invoke(4L, &i);
				for (i = 0; (ulong)(uint)i < (ulong)(num12 - num13); i++)
				{
					if (num14 != 0)
					{
						b2 = 1;
					}
					num14 = (int)((uint)num7 % 10u);
					num7 = (int)((uint)num7 / 10u);
				}
				llvm_lifetime_end_p0.Invoke(4L, &i);
				if (num13 == num12)
				{
					num6 = checked(num6 + -1);
					llvm_lifetime_start_p0.Invoke(4L, &num15);
					num15 = FloatToString_float_0_get_block_int.Invoke(&floatToString_vnf, num6);
					num14 = (int)((uint)num15 / 100000000u);
					if ((uint)num15 % 100000000u != 0)
					{
						b2 = 1;
					}
					llvm_lifetime_end_p0.Invoke(4L, &num15);
				}
				llvm_lifetime_start_p0.Invoke(4L, &num16);
				num16 = -1431655766;
				if ((b2 & 1) != 1)
				{
					checked
					{
						if (num6 >= 0)
						{
							llvm_lifetime_start_p0.Invoke(4L, &j);
							for (j = num6 - 1; j >= 0; j += -1)
							{
								llvm_lifetime_start_p0.Invoke(4L, &num17);
								num17 = FloatToString_float_0_get_block_int.Invoke(&floatToString_vnf, j);
								if (num17 != 0)
								{
									b2 = 1;
									num22 = 10;
								}
								else
								{
									num22 = 0;
								}
								llvm_lifetime_end_p0.Invoke(4L, &num17);
								switch (num22)
								{
								case 0:
									continue;
								}
								break;
							}
							llvm_lifetime_end_p0.Invoke(4L, &j);
						}
					}
					if ((b2 & 1) != 1 && checked(num2 - 23) < 0)
					{
						b2 = (sbyte)(byte)((cpp_enable_if_cpp_is_integral_v_unsigned_int_is_big_int_v_unsigned_int_bool_type_printf_core_zero_after_digits_unsigned_int_int_int_unsigned_int_int.Invoke(checked(num2 - 23), num3 - num5, fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_get_explicit_mantissa_const.Invoke(&fputil_FPBits_5nkvcs2), 23) ? 1 : 0) ^ -1);
					}
				}
				int last_digit = num14;
				bool truncated = (b2 & 1) == 1;
				anon_izyfb8.val = fputil_internal_FPStorage_fputil_FPType_1_sign_const.Invoke(&fputil_FPBits_5nkvcs2);
				num16 = (int)printf_core_get_round_direction_int_bool_Sign.Invoke(last_digit, truncated, anon_izyfb8.val);
				llvm_lifetime_start_p0.Invoke(4L, &num18);
				num18 = printf_core_FloatWriter_write_last_block_unsigned_int_unsigned_long_printf_core_RoundDirection_int_char.Invoke(&printf_core_FloatWriter2, num7, num13, (RoundDirection_zvveyk)num16, num5, InstructionHelper.Select(internal_islower_int_170.Invoke(to_conv->conv_name), (sbyte)101, (sbyte)69));
				if (num18 < 0)
				{
					result = num18;
					num22 = 1;
				}
				else
				{
					num22 = 0;
				}
				llvm_lifetime_end_p0.Invoke(4L, &num18);
				switch (num22)
				{
				case 0:
					llvm_lifetime_start_p0.Invoke(4L, &num19);
					num19 = printf_core_FloatWriter_right_pad.Invoke(&printf_core_FloatWriter2);
					if (num19 < 0)
					{
						result = num19;
						num22 = 1;
					}
					else
					{
						num22 = 0;
					}
					llvm_lifetime_end_p0.Invoke(4L, &num19);
					switch (num22)
					{
					case 0:
						result = 0;
						break;
					}
					break;
				}
				llvm_lifetime_end_p0.Invoke(4L, &num16);
				llvm_lifetime_end_p0.Invoke(4L, &num14);
				llvm_lifetime_end_p0.Invoke(8L, &num13);
				llvm_lifetime_end_p0.Invoke(1L, &b2);
				llvm_lifetime_end_p0.Invoke(8L, &num12);
				break;
				IL_05a4:
				num4 += 9L;
				num6 = checked(num6 + -1);
			}
			llvm_lifetime_end_p0.Invoke(8L, &num10);
			llvm_lifetime_end_p0.Invoke(4L, &num9);
			llvm_lifetime_end_p0.Invoke(8L, &num8);
			llvm_lifetime_end_p0.Invoke(4L, &num7);
			llvm_lifetime_end_p0.Invoke(4L, &num6);
			llvm_lifetime_end_p0.Invoke(4L, &num5);
			llvm_lifetime_end_p0.Invoke(8L, &num4);
			llvm_lifetime_end_p0.Invoke(32L, &floatToString_vnf);
			llvm_lifetime_end_p0.Invoke(96L, &printf_core_FloatWriter2);
			llvm_lifetime_end_p0.Invoke(16L, &printf_core_PaddingWriter2);
			llvm_lifetime_end_p0.Invoke(1L, &b);
			llvm_lifetime_end_p0.Invoke(4L, &num3);
			llvm_lifetime_end_p0.Invoke(1L, &init_sign_char);
			llvm_lifetime_end_p0.Invoke(16L, &x);
			llvm_lifetime_end_p0.Invoke(4L, &num2);
			llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
