using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Printf_core_convert_float_dec_exp_typed_double_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core27convert_float_dec_exp_typedIdTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEEiPNS0_6WriterERKNS0_13FormatSectionENS_6fputil6FPBitsIS4_EE")]
	[DemangledName("int __llvm_libc_20_1_2_::printf_core::convert_float_dec_exp_typed<double, 0>(__llvm_libc_20_1_2_::printf_core::Writer*, __llvm_libc_20_1_2_::printf_core::FormatSection const&, __llvm_libc_20_1_2_::fputil::FPBits<double>)")]
	[return: NativeType("int")]
	public unsafe static int Invoke([MangledName("writer")][NativeType("__llvm_libc_20_1_2_::printf_core::Writer*")] Printf_core_Writer* Writer, [MangledName("to_conv")][NativeType("__llvm_libc_20_1_2_::printf_core::FormatSection const&")] Printf_core_FormatSection* To_conv, [MangledName("float_bits.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::FPBits<double>")] long Float_bits)
	{
		int result = 0;
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm = default(Fputil_FPBits_wjhbrm);
		int num = 0;
		int num2 = 0;
		Int128 x = default(Int128);
		sbyte init_sign_char = 0;
		int num3 = 0;
		sbyte b = 0;
		Printf_core_PaddingWriter printf_core_PaddingWriter = default(Printf_core_PaddingWriter);
		Printf_core_FloatWriter printf_core_FloatWriter = default(Printf_core_FloatWriter);
		FloatToString_rwjwy3 floatToString_rwjwy = default(FloatToString_rwjwy3);
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
		int round = 0;
		int j = 0;
		int num16 = 0;
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		int num17 = 0;
		int num18 = 0;
		fputil_FPBits_wjhbrm.FPRepImpl.FPRepSem.FPStorage.Val = Float_bits;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 52;
		Llvm_lifetime_start_p0.Invoke(4L, &num2);
		unchecked
		{
			num2 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_explicit_exponent.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm));
			Llvm_lifetime_start_p0.Invoke(16L, &x);
			x = (Int128)(UInt128)(ulong)FPRepSem_fputil_FPType_2_fputil_FPBits_double_get_explicit_mantissa.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm));
			Llvm_lifetime_start_p0.Invoke(1L, &init_sign_char);
			init_sign_char = 0;
			if (FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_neg.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm)))
			{
				init_sign_char = 45;
			}
			else if (((byte)To_conv->Flags & 2) == 2)
			{
				init_sign_char = 43;
			}
			else if (((byte)To_conv->Flags & 4) == 4)
			{
				init_sign_char = 32;
			}
			Llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = ((To_conv->Precision >= 0) ? To_conv->Precision : 6);
			Llvm_lifetime_start_p0.Invoke(1L, &b);
			b = ((num3 != 0 || ((byte)To_conv->Flags & 8) != 0) ? ((sbyte)1) : ((sbyte)0));
			Llvm_lifetime_start_p0.Invoke(16L, &printf_core_PaddingWriter);
			*(sbyte*)(&printf_core_PaddingWriter) = -86;
			((sbyte*)(&printf_core_PaddingWriter))[1] = -86;
			((sbyte*)(&printf_core_PaddingWriter))[2] = -86;
			sbyte* ptr = (sbyte*)(&printf_core_PaddingWriter) + 3;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			ptr[3] = -86;
			ptr[4] = -86;
			((long*)(&printf_core_PaddingWriter))[1] = -6148914691236517206L;
			PaddingWriter_Constructor.Invoke(&printf_core_PaddingWriter, To_conv, init_sign_char);
			Llvm_lifetime_start_p0.Invoke(96L, &printf_core_FloatWriter);
			Llvm_memset_p0_i64.Invoke(&printf_core_FloatWriter, -86, 96L, isVolatile: false);
			FloatWriter_Constructor.Invoke(&printf_core_FloatWriter, Writer, (b & 1) == 1, &printf_core_PaddingWriter);
			Llvm_lifetime_start_p0.Invoke(32L, &floatToString_rwjwy);
			*(long*)(&floatToString_rwjwy) = -6148914691236517206L;
			((int*)(&floatToString_rwjwy))[2] = -1431655766;
			sbyte* ptr2 = (sbyte*)(&floatToString_rwjwy) + 12;
			*ptr2 = -86;
			ptr2[1] = -86;
			ptr2[2] = -86;
			ptr2[3] = -86;
			*(Int128*)((byte*)(&floatToString_rwjwy) + 16) = -6148914691236517206L;
			FloatToString_double_0_Constructor.Invoke(&floatToString_rwjwy, FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm));
			Llvm_lifetime_start_p0.Invoke(8L, &num4);
			num4 = 0L;
			Llvm_lifetime_start_p0.Invoke(4L, &num5);
			num5 = 0;
			Llvm_lifetime_start_p0.Invoke(4L, &num6);
			num6 = -1431655766;
			num6 = (int)((num2 >= 0) ? FloatToString_double_0_get_positive_blocks.Invoke(&floatToString_rwjwy) : checked(-unchecked((int)FloatToString_double_0_zero_blocks_after_point.Invoke(&floatToString_rwjwy))));
			Llvm_lifetime_start_p0.Invoke(4L, &num7);
			num7 = 0;
			if (NumericHelper.IntCmpNe(x, 0L))
			{
				while (num7 == 0)
				{
					num6 = checked(num6 + -1);
					num7 = FloatToString_double_0_get_block.Invoke(&floatToString_rwjwy, num6);
				}
			}
			else
			{
				num6 = 0;
			}
			Llvm_lifetime_start_p0.Invoke(8L, &num8);
			Llvm_lifetime_start_p0.Invoke(32L, &integerToString_uuwdyc);
			IntegerToString_long_details_Fmt_unsigned_char_10_false_false_false_1ul_Constructor.Invoke(&integerToString_uuwdyc, (uint)num7);
			long num19 = IntegerToString_long_details_Fmt_unsigned_char_10_false_false_false_1ul_size.Invoke(&integerToString_uuwdyc);
			Llvm_lifetime_end_p0.Invoke(32L, &integerToString_uuwdyc);
			num8 = num19;
		}
		num5 = unchecked((int)(num6 * 9L)) + unchecked((int)(num8 - 1L));
		Llvm_lifetime_start_p0.Invoke(4L, &num9);
		num9 = ((num5 >= 0) ? num5 : (-num5));
		Llvm_lifetime_start_p0.Invoke(8L, &num10);
		Llvm_lifetime_start_p0.Invoke(32L, &integerToString_uuwdyc2);
		IntegerToString_long_details_Fmt_unsigned_char_10_false_false_false_1ul_Constructor.Invoke(&integerToString_uuwdyc2, num9);
		long num20 = IntegerToString_long_details_Fmt_unsigned_char_10_false_false_false_1ul_size.Invoke(&integerToString_uuwdyc2);
		Llvm_lifetime_end_p0.Invoke(32L, &integerToString_uuwdyc2);
		num10 = num20;
		unchecked
		{
			FloatWriter_init.Invoke(&printf_core_FloatWriter, (uint)(checked(1 + InstructionHelper.Select((b & 1) == 1, 1, 0)) + num3 + 2) + (((ulong)num10 >= 2uL) ? num10 : 2L), 1L);
			if ((ulong)num8 <= (ulong)(uint)(num3 + 1))
			{
				FloatWriter_write_first_block.Invoke(&printf_core_FloatWriter, num7, Exp_format: true);
				num4 += num8;
				num6 = checked(num6 + -1);
			}
			while (true)
			{
				int num21;
				if ((ulong)(num4 + 9L) < (ulong)(uint)(num3 + 1))
				{
					num7 = FloatToString_double_0_get_block.Invoke(&floatToString_rwjwy, num6);
					Llvm_lifetime_start_p0.Invoke(4L, &num11);
					num11 = FloatWriter_write_middle_block.Invoke(&printf_core_FloatWriter, num7);
					if (num11 < 0)
					{
						result = num11;
						num21 = 1;
					}
					else
					{
						num21 = 0;
					}
					Llvm_lifetime_end_p0.Invoke(4L, &num11);
					switch (num21)
					{
					case 0:
						goto IL_0589;
					}
					break;
				}
				num7 = FloatToString_double_0_get_block.Invoke(&floatToString_rwjwy, num6);
				Llvm_lifetime_start_p0.Invoke(8L, &num12);
				num12 = 9L;
				if (num4 == 0L)
				{
					Llvm_lifetime_start_p0.Invoke(32L, &integerToString_uuwdyc3);
					IntegerToString_long_details_Fmt_unsigned_char_10_false_false_false_1ul_Constructor.Invoke(&integerToString_uuwdyc3, (uint)num7);
					num12 = IntegerToString_long_details_Fmt_unsigned_char_10_false_false_false_1ul_size.Invoke(&integerToString_uuwdyc3);
					Llvm_lifetime_end_p0.Invoke(32L, &integerToString_uuwdyc3);
				}
				Llvm_lifetime_start_p0.Invoke(1L, &b2);
				b2 = 0;
				Llvm_lifetime_start_p0.Invoke(8L, &num13);
				num13 = (uint)(num3 + 1) - num4;
				Llvm_lifetime_start_p0.Invoke(4L, &num14);
				num14 = 0;
				Llvm_lifetime_start_p0.Invoke(4L, &i);
				for (i = 0; (ulong)(uint)i < (ulong)(num12 - num13); i++)
				{
					if (num14 != 0)
					{
						b2 = 1;
					}
					num14 = (int)((uint)num7 % 10u);
					num7 = (int)((uint)num7 / 10u);
				}
				Llvm_lifetime_end_p0.Invoke(4L, &i);
				if (num13 == num12)
				{
					num6 = checked(num6 + -1);
					Llvm_lifetime_start_p0.Invoke(4L, &num15);
					num15 = FloatToString_double_0_get_block.Invoke(&floatToString_rwjwy, num6);
					num14 = (int)((uint)num15 / 100000000u);
					if ((uint)num15 % 100000000u != 0)
					{
						b2 = 1;
					}
					Llvm_lifetime_end_p0.Invoke(4L, &num15);
				}
				Llvm_lifetime_start_p0.Invoke(4L, &round);
				round = -1431655766;
				int last_digit;
				bool truncated;
				checked
				{
					if ((b2 & 1) != 1)
					{
						if (num6 >= 0)
						{
							Llvm_lifetime_start_p0.Invoke(4L, &j);
							for (j = num6 - 1; j >= 0; j += -1)
							{
								Llvm_lifetime_start_p0.Invoke(4L, &num16);
								num16 = FloatToString_double_0_get_block.Invoke(&floatToString_rwjwy, j);
								if (num16 != 0)
								{
									b2 = 1;
									num21 = 10;
								}
								else
								{
									num21 = 0;
								}
								Llvm_lifetime_end_p0.Invoke(4L, &num16);
								switch (num21)
								{
								case 0:
									continue;
								}
								break;
							}
							Llvm_lifetime_end_p0.Invoke(4L, &j);
						}
						if ((b2 & 1) != 1 && num2 - 52 < 0)
						{
							b2 = (InstructionHelper.BooleanXor(Printf_core_zero_after_digits_unsigned_long.Invoke(num2 - 52, unchecked(num3 - num5), FPRepSem_fputil_FPType_2_fputil_FPBits_double_get_explicit_mantissa.Invoke(unchecked((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm))), 52), right: true) ? ((sbyte)1) : ((sbyte)0));
						}
					}
					last_digit = num14;
					truncated = (b2 & 1) == 1;
					anon_izyfb.Val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm);
				}
				round = (int)Printf_core_get_round_direction.Invoke(last_digit, truncated, anon_izyfb.Val);
				Llvm_lifetime_start_p0.Invoke(4L, &num17);
				num17 = FloatWriter_write_last_block.Invoke(&printf_core_FloatWriter, num7, num13, (RoundDirection_zvveyk)round, num5, InstructionHelper.Select(Internal_islower_p5hwic.Invoke(To_conv->Conv_name), (sbyte)101, (sbyte)69));
				if (num17 < 0)
				{
					result = num17;
					num21 = 1;
				}
				else
				{
					num21 = 0;
				}
				Llvm_lifetime_end_p0.Invoke(4L, &num17);
				switch (num21)
				{
				case 0:
					Llvm_lifetime_start_p0.Invoke(4L, &num18);
					num18 = FloatWriter_right_pad.Invoke(&printf_core_FloatWriter);
					if (num18 < 0)
					{
						result = num18;
						num21 = 1;
					}
					else
					{
						num21 = 0;
					}
					Llvm_lifetime_end_p0.Invoke(4L, &num18);
					switch (num21)
					{
					case 0:
						result = 0;
						break;
					}
					break;
				}
				Llvm_lifetime_end_p0.Invoke(4L, &round);
				Llvm_lifetime_end_p0.Invoke(4L, &num14);
				Llvm_lifetime_end_p0.Invoke(8L, &num13);
				Llvm_lifetime_end_p0.Invoke(1L, &b2);
				Llvm_lifetime_end_p0.Invoke(8L, &num12);
				break;
				IL_0589:
				num4 += 9L;
				num6 = checked(num6 + -1);
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num10);
			Llvm_lifetime_end_p0.Invoke(4L, &num9);
			Llvm_lifetime_end_p0.Invoke(8L, &num8);
			Llvm_lifetime_end_p0.Invoke(4L, &num7);
			Llvm_lifetime_end_p0.Invoke(4L, &num6);
			Llvm_lifetime_end_p0.Invoke(4L, &num5);
			Llvm_lifetime_end_p0.Invoke(8L, &num4);
			Llvm_lifetime_end_p0.Invoke(32L, &floatToString_rwjwy);
			Llvm_lifetime_end_p0.Invoke(96L, &printf_core_FloatWriter);
			Llvm_lifetime_end_p0.Invoke(16L, &printf_core_PaddingWriter);
			Llvm_lifetime_end_p0.Invoke(1L, &b);
			Llvm_lifetime_end_p0.Invoke(4L, &num3);
			Llvm_lifetime_end_p0.Invoke(1L, &init_sign_char);
			Llvm_lifetime_end_p0.Invoke(16L, &x);
			Llvm_lifetime_end_p0.Invoke(4L, &num2);
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
