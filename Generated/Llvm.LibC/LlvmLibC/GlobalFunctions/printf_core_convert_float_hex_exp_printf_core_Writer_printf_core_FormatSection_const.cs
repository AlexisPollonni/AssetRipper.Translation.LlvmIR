using System;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core21convert_float_hex_expEPNS0_6WriterERKNS0_13FormatSectionE")]
[DemangledName("__llvm_libc_20_1_2_::printf_core::convert_float_hex_exp(__llvm_libc_20_1_2_::printf_core::Writer*, __llvm_libc_20_1_2_::printf_core::FormatSection const&)")]
internal static partial class printf_core_convert_float_hex_exp_printf_core_Writer_printf_core_FormatSection_const
{
	public unsafe static int Invoke(printf_core_Writer* writer, printf_core_FormatSection* to_conv)
	{
		int result = 0;
		sbyte b = 0;
		int num = 0;
		Int128 x = default(Int128);
		sbyte b2 = 0;
		int num2 = 0;
		Int128 @int = default(Int128);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(fputil_FPBits_ubgsi2);
		Int128 int2 = default(Int128);
		Int128 int3 = default(Int128);
		long x2 = 0L;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		sbyte b3 = 0;
		long num3 = 0L;
		long num4 = 0L;
		InlineArray16_SByte inlineArray16_SByte = default(InlineArray16_SByte);
		long num5 = 0L;
		long num6 = 0L;
		long num7 = 0L;
		Int128 x3 = default(Int128);
		Int128 y = default(Int128);
		long num8 = 0L;
		long num9 = 0L;
		sbyte b4 = 0;
		sbyte b5 = 0;
		long num10 = 0L;
		long num11 = 0L;
		InlineArray6_SByte inlineArray6_SByte = default(InlineArray6_SByte);
		sbyte b6 = 0;
		long num12 = 0L;
		long num13 = 0L;
		int num14 = 0;
		long num15 = 0L;
		InlineArray2_SByte inlineArray2_SByte = default(InlineArray2_SByte);
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		sbyte b7 = 0;
		cpp_string_view cpp_string_view3 = default(cpp_string_view);
		sbyte new_char = 0;
		int num16 = 0;
		int num17 = 0;
		int num18 = 0;
		cpp_string_view cpp_string_view4 = default(cpp_string_view);
		int num19 = 0;
		int num20 = 0;
		cpp_string_view cpp_string_view5 = default(cpp_string_view);
		int num21 = 0;
		cpp_string_view cpp_string_view6 = default(cpp_string_view);
		int num22 = 0;
		int num23 = 0;
		int num24 = 0;
		cpp_string_view cpp_string_view7 = default(cpp_string_view);
		int num25 = 0;
		int num26 = 0;
		int num27 = 0;
		int num28 = 0;
		cpp_string_view cpp_string_view8 = default(cpp_string_view);
		int num29 = 0;
		int num30 = 0;
		int num31 = 0;
		cpp_string_view cpp_string_view9 = default(cpp_string_view);
		int num32 = 0;
		cpp_string_view cpp_string_view10 = default(cpp_string_view);
		int num33 = 0;
		int num34 = 0;
		int num35 = 0;
		cpp_string_view cpp_string_view11 = default(cpp_string_view);
		llvm_lifetime_start_p0.Invoke(1L, &b);
		b = -86;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = -1431655766;
		llvm_lifetime_start_p0.Invoke(16L, &x);
		x = -6148914691236517206L;
		llvm_lifetime_start_p0.Invoke(1L, &b2);
		b2 = -86;
		llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = -1431655766;
		unchecked
		{
			if (to_conv->length_modifier == LengthModifier_mnvaa2.L)
			{
				num2 = 63;
				llvm_lifetime_start_p0.Invoke(16L, &@int);
				@int = to_conv->conv_val_raw;
				llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
				*(Int128*)(&fputil_FPBits_ubgsi3) = -6148914691236517206L;
				int2 = @int;
				fputil_FPBits_long_double_FPBits_unsigned_int128_unsigned_int128.Invoke(&fputil_FPBits_ubgsi3, *(long*)(&int2), ((long*)(&int2))[1]);
				b = (fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_is_neg_const.Invoke(&fputil_FPBits_ubgsi3) ? ((sbyte)1) : ((sbyte)0));
				num = fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_explicit_exponent_const.Invoke(&fputil_FPBits_ubgsi3);
				Struct_fiz2nb struct_fiz2nb = fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_get_explicit_mantissa_const.Invoke(&fputil_FPBits_ubgsi3);
				Int128* num36 = &int3;
				Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
				*(long*)num36 = struct_fiz2nb2.field_0;
				byte* num37 = (byte*)(&int3) + 8u;
				Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
				*(long*)num37 = struct_fiz2nb3.field_1;
				x = int3;
				b2 = (fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_is_inf_or_nan_const.Invoke(&fputil_FPBits_ubgsi3) ? ((sbyte)1) : ((sbyte)0));
				llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
				llvm_lifetime_end_p0.Invoke(16L, &@int);
			}
			else
			{
				num2 = 52;
				llvm_lifetime_start_p0.Invoke(8L, &x2);
				x2 = (long)to_conv->conv_val_raw;
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
				*(long*)(&fputil_FPBits_wjhbrm2) = -6148914691236517206L;
				fputil_FPBits_double_FPBits_unsigned_long_unsigned_long.Invoke(&fputil_FPBits_wjhbrm2, x2);
				b = (fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_neg_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2)) ? ((sbyte)1) : ((sbyte)0));
				num = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_explicit_exponent_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2));
				x = (Int128)(UInt128)(ulong)fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_get_explicit_mantissa_const.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2));
				b2 = (fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_inf_or_nan_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2)) ? ((sbyte)1) : ((sbyte)0));
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
				llvm_lifetime_end_p0.Invoke(8L, &x2);
			}
			if ((b2 & 1) == 1)
			{
				result = printf_core_convert_inf_nan_printf_core_Writer_printf_core_FormatSection_const.Invoke(writer, to_conv);
				goto IL_15e1;
			}
			llvm_lifetime_start_p0.Invoke(1L, &b3);
			b3 = 0;
			if ((b & 1) == 1)
			{
				b3 = 45;
			}
			else if (((byte)to_conv->flags & 2) == 2)
			{
				b3 = 43;
			}
			else if (((byte)to_conv->flags & 4) == 4)
			{
				b3 = 32;
			}
			llvm_lifetime_start_p0.Invoke(8L, &num3);
			num3 = 4L;
			if ((ulong)(uint)num2 % 4uL != 0L && NumericHelper.IntCmpUgt(x, 0L))
			{
				num = (int)((long)num - (long)((ulong)(uint)num2 % 4uL));
			}
			llvm_lifetime_start_p0.Invoke(8L, &num4);
			num4 = 16L;
			llvm_lifetime_start_p0.Invoke(16L, &inlineArray16_SByte);
			*(sbyte*)(&inlineArray16_SByte) = -86;
			((sbyte*)(&inlineArray16_SByte))[1] = -86;
			((sbyte*)(&inlineArray16_SByte))[2] = -86;
			((sbyte*)(&inlineArray16_SByte))[3] = -86;
			((sbyte*)(&inlineArray16_SByte))[4] = -86;
			((sbyte*)(&inlineArray16_SByte))[5] = -86;
			((sbyte*)(&inlineArray16_SByte))[6] = -86;
			((sbyte*)(&inlineArray16_SByte))[7] = -86;
			((sbyte*)(&inlineArray16_SByte))[8] = -86;
			((sbyte*)(&inlineArray16_SByte))[9] = -86;
			((sbyte*)(&inlineArray16_SByte))[10] = -86;
			((sbyte*)(&inlineArray16_SByte))[11] = -86;
			((sbyte*)(&inlineArray16_SByte))[12] = -86;
			((sbyte*)(&inlineArray16_SByte))[13] = -86;
			((sbyte*)(&inlineArray16_SByte))[14] = -86;
			((sbyte*)(&inlineArray16_SByte))[15] = -86;
			llvm_lifetime_start_p0.Invoke(8L, &num5);
			num5 = (long)((ulong)(uint)num2 / 4uL + 1L);
			if (checked(to_conv->precision + 1) < (int)num5 && checked(to_conv->precision + 1) > 0)
			{
				llvm_lifetime_start_p0.Invoke(8L, &num6);
				num6 = checked(to_conv->precision + 1);
				llvm_lifetime_start_p0.Invoke(8L, &num7);
				num7 = (num5 - num6) * 4L;
				llvm_lifetime_start_p0.Invoke(16L, &x3);
				x3 = NumericHelper.BitwiseAnd(x, NumericHelper.Subtract(NumericHelper.ShiftLeft(y: (Int128)(UInt128)(ulong)num7, x: 1L), 1L));
				llvm_lifetime_start_p0.Invoke(16L, &y);
				y = NumericHelper.ShiftLeft(y: (Int128)(UInt128)(ulong)(num7 - 1L), x: 1L);
				x = NumericHelper.ShiftRightLogical(x, (Int128)(UInt128)(ulong)num7);
				switch (fputil_quick_get_round.Invoke())
				{
				case 0:
					if (NumericHelper.IntCmpUgt(x3, y))
					{
						x = NumericHelper.Add(x, 1L);
					}
					else if (NumericHelper.IntCmpEq(x3, y))
					{
						x = NumericHelper.Add(x, NumericHelper.BitwiseAnd(x, 1L));
					}
					break;
				case 1024:
					if (NumericHelper.IntCmpUgt(x3, 0L) && (b & 1) == 1)
					{
						x = NumericHelper.Add(x, 1L);
					}
					break;
				case 2048:
					if (NumericHelper.IntCmpUgt(x3, 0L) && (b & 1) != 1)
					{
						x = NumericHelper.Add(x, 1L);
					}
					break;
				}
				if (NumericHelper.IntCmpUge(x, NumericHelper.ShiftLeft(y: (Int128)(UInt128)(ulong)(num6 * 4L), x: 1L)))
				{
					x = NumericHelper.ShiftRightLogical(x, 4L);
					num = (int)(num + 4L);
				}
				num5 = num6;
				llvm_lifetime_end_p0.Invoke(16L, &y);
				llvm_lifetime_end_p0.Invoke(16L, &x3);
				llvm_lifetime_end_p0.Invoke(8L, &num7);
				llvm_lifetime_end_p0.Invoke(8L, &num6);
			}
			llvm_lifetime_start_p0.Invoke(8L, &num8);
			num8 = num5;
			llvm_lifetime_start_p0.Invoke(8L, &num9);
			num9 = 1L;
			while ((ulong)num8 > 0uL)
			{
				llvm_lifetime_start_p0.Invoke(1L, &b4);
				b4 = (sbyte)NumericHelper.RemainderUnsigned(x, 16L);
				llvm_lifetime_start_p0.Invoke(1L, &b5);
				b5 = (sbyte)internal_int_to_b36_char_int.Invoke(b4);
				if (internal_isupper_int.Invoke(to_conv->conv_name))
				{
					b5 = (sbyte)internal_toupper_int.Invoke(b5);
				}
				Unsafe.As<InlineArray16_SByte, sbyte>(ref Unsafe.AddByteOffset(ref inlineArray16_SByte, (nint)(num8 - 1L))) = b5;
				if (b5 != 48 && (ulong)num9 < (ulong)num8)
				{
					num9 = num8;
				}
				llvm_lifetime_end_p0.Invoke(1L, &b5);
				llvm_lifetime_end_p0.Invoke(1L, &b4);
				num8 += -1L;
				x = NumericHelper.ShiftRightLogical(x, 4L);
			}
			llvm_lifetime_start_p0.Invoke(8L, &num10);
			num10 = num9;
			if (to_conv->precision >= 0)
			{
				num10 = num5;
			}
			llvm_lifetime_start_p0.Invoke(8L, &num11);
			num11 = 6L;
			llvm_lifetime_start_p0.Invoke(6L, &inlineArray6_SByte);
			*(sbyte*)(&inlineArray6_SByte) = -86;
			((sbyte*)(&inlineArray6_SByte))[1] = -86;
			((sbyte*)(&inlineArray6_SByte))[2] = -86;
			((sbyte*)(&inlineArray6_SByte))[3] = -86;
			((sbyte*)(&inlineArray6_SByte))[4] = -86;
			((sbyte*)(&inlineArray6_SByte))[5] = -86;
			llvm_lifetime_start_p0.Invoke(1L, &b6);
			b6 = 0;
			if (num < 0)
			{
				b6 = 1;
				num = checked(-num);
			}
			llvm_lifetime_start_p0.Invoke(8L, &num12);
			num12 = 6L;
			while (num > 0)
			{
				sbyte b8 = (sbyte)internal_int_to_b36_char_int.Invoke(num % 10);
				Unsafe.As<InlineArray6_SByte, sbyte>(ref Unsafe.AddByteOffset(ref inlineArray6_SByte, (nint)(num12 - 1L))) = b8;
				num12 += -1L;
				num /= 10;
			}
			if (num12 == 6L)
			{
				Unsafe.As<InlineArray6_SByte, sbyte>(ref Unsafe.AddByteOffset(ref inlineArray6_SByte, 5)) = 48;
				num12 = 5L;
			}
			sbyte b9 = InstructionHelper.Select((b6 & 1) == 1, (sbyte)45, (sbyte)43);
			Unsafe.As<InlineArray6_SByte, sbyte>(ref Unsafe.AddByteOffset(ref inlineArray6_SByte, (nint)(num12 - 1L))) = b9;
			num12 += -1L;
			llvm_lifetime_start_p0.Invoke(8L, &num13);
			num13 = 0L;
			llvm_lifetime_start_p0.Invoke(4L, &num14);
			num14 = -1431655766;
			llvm_lifetime_start_p0.Invoke(8L, &num15);
			num15 = 2L;
			llvm_lifetime_start_p0.Invoke(2L, &inlineArray2_SByte);
			*(sbyte*)(&inlineArray2_SByte) = -86;
			((sbyte*)(&inlineArray2_SByte))[1] = -86;
			*(sbyte*)(&inlineArray2_SByte) = 48;
			Unsafe.As<InlineArray2_SByte, sbyte>(ref Unsafe.AddByteOffset(ref inlineArray2_SByte, 1)) = InstructionHelper.Select(internal_islower_int.Invoke(to_conv->conv_name), (sbyte)120, (sbyte)88);
			llvm_lifetime_start_p0.Invoke(16L, &cpp_string_view2);
			*(IntPtr*)(&cpp_string_view2) = unchecked((nint)(-6148914691236517206L));
			((long*)(&cpp_string_view2))[1] = -6148914691236517206L;
			cpp_string_view_string_view_char_const_unsigned_long.Invoke(&cpp_string_view2, &inlineArray2_SByte, 2L);
			if (to_conv->precision > (int)(num10 - 1L))
			{
				num13 = to_conv->precision - (num10 - 1L);
			}
			llvm_lifetime_start_p0.Invoke(1L, &b7);
			b7 = (sbyte)(byte)(((ulong)num10 <= 1uL) ? ((((byte)to_conv->flags & 8) == 8) ? 1 : 0) : (-1));
			llvm_lifetime_start_p0.Invoke(16L, &cpp_string_view3);
			*(InlineArray2_SByte**)(&cpp_string_view3) = str_4_160.Pointer;
			((long*)(&cpp_string_view3))[1] = 1L;
			llvm_lifetime_start_p0.Invoke(1L, &new_char);
			new_char = InstructionHelper.Select(internal_islower_int.Invoke(to_conv->conv_name), (sbyte)112, (sbyte)80);
			llvm_lifetime_start_p0.Invoke(4L, &num16);
			num16 = 1;
			num14 = (int)(checked(to_conv->min_width - InstructionHelper.Select(b3 > 0, 1, 0)) - 2L - num10 - num13 - (((b7 & 1) == 1) ? 1 : 0) - 1L - (6L - num12));
			if (num14 < 0)
			{
				num14 = 0;
			}
			if (((byte)to_conv->flags & 1) == 1)
			{
				int num38;
				if (b3 > 0)
				{
					llvm_lifetime_start_p0.Invoke(4L, &num17);
					num17 = printf_core_Writer_write_char.Invoke(writer, b3);
					if (num17 < 0)
					{
						result = num17;
						num38 = 1;
					}
					else
					{
						num38 = 0;
					}
					llvm_lifetime_end_p0.Invoke(4L, &num17);
					switch (num38)
					{
					case 0:
						break;
					default:
						goto IL_148f;
					}
				}
				llvm_lifetime_start_p0.Invoke(4L, &num18);
				llvm_memcpy_p0_p0_i64.Invoke(&cpp_string_view4, &cpp_string_view2, 16L, isVolatile: false);
				num18 = printf_core_Writer_write_cpp_string_view.Invoke(writer, *(void**)(&cpp_string_view4), ((long*)(&cpp_string_view4))[1]);
				if (num18 < 0)
				{
					result = num18;
					num38 = 1;
				}
				else
				{
					num38 = 0;
				}
				llvm_lifetime_end_p0.Invoke(4L, &num18);
				switch (num38)
				{
				case 0:
					break;
				default:
					goto IL_148f;
				}
				llvm_lifetime_start_p0.Invoke(4L, &num19);
				num19 = printf_core_Writer_write_char.Invoke(writer, *(sbyte*)(&inlineArray16_SByte));
				if (num19 < 0)
				{
					result = num19;
					num38 = 1;
				}
				else
				{
					num38 = 0;
				}
				llvm_lifetime_end_p0.Invoke(4L, &num19);
				switch (num38)
				{
				case 0:
					break;
				default:
					goto IL_148f;
				}
				if ((b7 & 1) == 1)
				{
					llvm_lifetime_start_p0.Invoke(4L, &num20);
					llvm_memcpy_p0_p0_i64.Invoke(&cpp_string_view5, &cpp_string_view3, 16L, isVolatile: false);
					num20 = printf_core_Writer_write_cpp_string_view.Invoke(writer, *(void**)(&cpp_string_view5), ((long*)(&cpp_string_view5))[1]);
					if (num20 < 0)
					{
						result = num20;
						num38 = 1;
					}
					else
					{
						num38 = 0;
					}
					llvm_lifetime_end_p0.Invoke(4L, &num20);
					switch (num38)
					{
					case 0:
						break;
					default:
						goto IL_148f;
					}
				}
				if ((ulong)num10 > 1uL)
				{
					llvm_lifetime_start_p0.Invoke(4L, &num21);
					cpp_string_view_string_view_char_const_unsigned_long.Invoke(&cpp_string_view6, Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray16_SByte, 1)), num10 - 1L);
					num21 = printf_core_Writer_write_cpp_string_view.Invoke(writer, *(void**)(&cpp_string_view6), ((long*)(&cpp_string_view6))[1]);
					if (num21 < 0)
					{
						result = num21;
						num38 = 1;
					}
					else
					{
						num38 = 0;
					}
					llvm_lifetime_end_p0.Invoke(4L, &num21);
					switch (num38)
					{
					case 0:
						break;
					default:
						goto IL_148f;
					}
				}
				if ((ulong)num13 > 0uL)
				{
					llvm_lifetime_start_p0.Invoke(4L, &num22);
					num22 = printf_core_Writer_write_char_unsigned_long.Invoke(writer, 48, num13);
					if (num22 < 0)
					{
						result = num22;
						num38 = 1;
					}
					else
					{
						num38 = 0;
					}
					llvm_lifetime_end_p0.Invoke(4L, &num22);
					switch (num38)
					{
					case 0:
						break;
					default:
						goto IL_148f;
					}
				}
				llvm_lifetime_start_p0.Invoke(4L, &num23);
				num23 = printf_core_Writer_write_char.Invoke(writer, new_char);
				if (num23 < 0)
				{
					result = num23;
					num38 = 1;
				}
				else
				{
					num38 = 0;
				}
				llvm_lifetime_end_p0.Invoke(4L, &num23);
				switch (num38)
				{
				case 0:
					break;
				default:
					goto IL_148f;
				}
				llvm_lifetime_start_p0.Invoke(4L, &num24);
				cpp_string_view_string_view_char_const_unsigned_long.Invoke(&cpp_string_view7, Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray6_SByte, (nint)num12)), 6L - num12);
				num24 = printf_core_Writer_write_cpp_string_view.Invoke(writer, *(void**)(&cpp_string_view7), ((long*)(&cpp_string_view7))[1]);
				if (num24 < 0)
				{
					result = num24;
					num38 = 1;
				}
				else
				{
					num38 = 0;
				}
				llvm_lifetime_end_p0.Invoke(4L, &num24);
				switch (num38)
				{
				case 0:
					break;
				default:
					goto IL_148f;
				}
				if (num14 > 0)
				{
					llvm_lifetime_start_p0.Invoke(4L, &num25);
					num25 = printf_core_Writer_write_char_unsigned_long.Invoke(writer, 32, num14);
					if (num25 < 0)
					{
						result = num25;
						num38 = 1;
					}
					else
					{
						num38 = 0;
					}
					llvm_lifetime_end_p0.Invoke(4L, &num25);
					switch (num38)
					{
					case 0:
						break;
					default:
						goto IL_148f;
					}
				}
			}
			else
			{
				int num38;
				if (num14 > 0 && ((byte)to_conv->flags & 0x10) != 16)
				{
					llvm_lifetime_start_p0.Invoke(4L, &num26);
					num26 = printf_core_Writer_write_char_unsigned_long.Invoke(writer, 32, num14);
					if (num26 < 0)
					{
						result = num26;
						num38 = 1;
					}
					else
					{
						num38 = 0;
					}
					llvm_lifetime_end_p0.Invoke(4L, &num26);
					switch (num38)
					{
					case 0:
						break;
					default:
						goto IL_148f;
					}
				}
				if (b3 > 0)
				{
					llvm_lifetime_start_p0.Invoke(4L, &num27);
					num27 = printf_core_Writer_write_char.Invoke(writer, b3);
					if (num27 < 0)
					{
						result = num27;
						num38 = 1;
					}
					else
					{
						num38 = 0;
					}
					llvm_lifetime_end_p0.Invoke(4L, &num27);
					switch (num38)
					{
					case 0:
						break;
					default:
						goto IL_148f;
					}
				}
				llvm_lifetime_start_p0.Invoke(4L, &num28);
				llvm_memcpy_p0_p0_i64.Invoke(&cpp_string_view8, &cpp_string_view2, 16L, isVolatile: false);
				num28 = printf_core_Writer_write_cpp_string_view.Invoke(writer, *(void**)(&cpp_string_view8), ((long*)(&cpp_string_view8))[1]);
				if (num28 < 0)
				{
					result = num28;
					num38 = 1;
				}
				else
				{
					num38 = 0;
				}
				llvm_lifetime_end_p0.Invoke(4L, &num28);
				switch (num38)
				{
				case 0:
					break;
				default:
					goto IL_148f;
				}
				if (num14 > 0 && ((byte)to_conv->flags & 0x10) == 16)
				{
					llvm_lifetime_start_p0.Invoke(4L, &num29);
					num29 = printf_core_Writer_write_char_unsigned_long.Invoke(writer, 48, num14);
					if (num29 < 0)
					{
						result = num29;
						num38 = 1;
					}
					else
					{
						num38 = 0;
					}
					llvm_lifetime_end_p0.Invoke(4L, &num29);
					switch (num38)
					{
					case 0:
						break;
					default:
						goto IL_148f;
					}
				}
				llvm_lifetime_start_p0.Invoke(4L, &num30);
				num30 = printf_core_Writer_write_char.Invoke(writer, *(sbyte*)(&inlineArray16_SByte));
				if (num30 < 0)
				{
					result = num30;
					num38 = 1;
				}
				else
				{
					num38 = 0;
				}
				llvm_lifetime_end_p0.Invoke(4L, &num30);
				switch (num38)
				{
				case 0:
					break;
				default:
					goto IL_148f;
				}
				if ((b7 & 1) == 1)
				{
					llvm_lifetime_start_p0.Invoke(4L, &num31);
					llvm_memcpy_p0_p0_i64.Invoke(&cpp_string_view9, &cpp_string_view3, 16L, isVolatile: false);
					num31 = printf_core_Writer_write_cpp_string_view.Invoke(writer, *(void**)(&cpp_string_view9), ((long*)(&cpp_string_view9))[1]);
					if (num31 < 0)
					{
						result = num31;
						num38 = 1;
					}
					else
					{
						num38 = 0;
					}
					llvm_lifetime_end_p0.Invoke(4L, &num31);
					switch (num38)
					{
					case 0:
						break;
					default:
						goto IL_148f;
					}
				}
				if ((ulong)num10 > 1uL)
				{
					llvm_lifetime_start_p0.Invoke(4L, &num32);
					cpp_string_view_string_view_char_const_unsigned_long.Invoke(&cpp_string_view10, Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray16_SByte, 1)), num10 - 1L);
					num32 = printf_core_Writer_write_cpp_string_view.Invoke(writer, *(void**)(&cpp_string_view10), ((long*)(&cpp_string_view10))[1]);
					if (num32 < 0)
					{
						result = num32;
						num38 = 1;
					}
					else
					{
						num38 = 0;
					}
					llvm_lifetime_end_p0.Invoke(4L, &num32);
					switch (num38)
					{
					case 0:
						break;
					default:
						goto IL_148f;
					}
				}
				if ((ulong)num13 > 0uL)
				{
					llvm_lifetime_start_p0.Invoke(4L, &num33);
					num33 = printf_core_Writer_write_char_unsigned_long.Invoke(writer, 48, num13);
					if (num33 < 0)
					{
						result = num33;
						num38 = 1;
					}
					else
					{
						num38 = 0;
					}
					llvm_lifetime_end_p0.Invoke(4L, &num33);
					switch (num38)
					{
					case 0:
						break;
					default:
						goto IL_148f;
					}
				}
				llvm_lifetime_start_p0.Invoke(4L, &num34);
				num34 = printf_core_Writer_write_char.Invoke(writer, new_char);
				if (num34 < 0)
				{
					result = num34;
					num38 = 1;
				}
				else
				{
					num38 = 0;
				}
				llvm_lifetime_end_p0.Invoke(4L, &num34);
				switch (num38)
				{
				case 0:
					break;
				default:
					goto IL_148f;
				}
				llvm_lifetime_start_p0.Invoke(4L, &num35);
				cpp_string_view_string_view_char_const_unsigned_long.Invoke(&cpp_string_view11, Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray6_SByte, (nint)num12)), 6L - num12);
				num35 = printf_core_Writer_write_cpp_string_view.Invoke(writer, *(void**)(&cpp_string_view11), ((long*)(&cpp_string_view11))[1]);
				if (num35 < 0)
				{
					result = num35;
					num38 = 1;
				}
				else
				{
					num38 = 0;
				}
				llvm_lifetime_end_p0.Invoke(4L, &num35);
				switch (num38)
				{
				case 0:
					break;
				default:
					goto IL_148f;
				}
			}
			result = 0;
			goto IL_148f;
		}
		IL_15e1:
		llvm_lifetime_end_p0.Invoke(4L, &num2);
		llvm_lifetime_end_p0.Invoke(1L, &b2);
		llvm_lifetime_end_p0.Invoke(16L, &x);
		llvm_lifetime_end_p0.Invoke(4L, &num);
		llvm_lifetime_end_p0.Invoke(1L, &b);
		return result;
		IL_148f:
		llvm_lifetime_end_p0.Invoke(4L, &num16);
		llvm_lifetime_end_p0.Invoke(1L, &new_char);
		llvm_lifetime_end_p0.Invoke(16L, &cpp_string_view3);
		llvm_lifetime_end_p0.Invoke(1L, &b7);
		llvm_lifetime_end_p0.Invoke(16L, &cpp_string_view2);
		llvm_lifetime_end_p0.Invoke(2L, &inlineArray2_SByte);
		llvm_lifetime_end_p0.Invoke(8L, &num15);
		llvm_lifetime_end_p0.Invoke(4L, &num14);
		llvm_lifetime_end_p0.Invoke(8L, &num13);
		llvm_lifetime_end_p0.Invoke(8L, &num12);
		llvm_lifetime_end_p0.Invoke(1L, &b6);
		llvm_lifetime_end_p0.Invoke(6L, &inlineArray6_SByte);
		llvm_lifetime_end_p0.Invoke(8L, &num11);
		llvm_lifetime_end_p0.Invoke(8L, &num10);
		llvm_lifetime_end_p0.Invoke(8L, &num9);
		llvm_lifetime_end_p0.Invoke(8L, &num8);
		llvm_lifetime_end_p0.Invoke(8L, &num5);
		llvm_lifetime_end_p0.Invoke(16L, &inlineArray16_SByte);
		llvm_lifetime_end_p0.Invoke(8L, &num4);
		llvm_lifetime_end_p0.Invoke(8L, &num3);
		llvm_lifetime_end_p0.Invoke(1L, &b3);
		goto IL_15e1;
	}
}
