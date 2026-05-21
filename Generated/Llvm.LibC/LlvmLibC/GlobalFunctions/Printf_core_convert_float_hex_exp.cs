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

internal static partial class Printf_core_convert_float_hex_exp
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core21convert_float_hex_expEPNS0_6WriterERKNS0_13FormatSectionE")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::convert_float_hex_exp(__llvm_libc_20_1_2_::printf_core::Writer*, __llvm_libc_20_1_2_::printf_core::FormatSection const&)")]
	public unsafe static int Invoke([MangledName("writer")][NativeType("__llvm_libc_20_1_2_::printf_core::Writer*")] Llvm_libc_20_1_2_printf_core_Writer* Writer, [MangledName("to_conv")][NativeType("__llvm_libc_20_1_2_::printf_core::FormatSection const&")] Llvm_libc_20_1_2_printf_core_FormatSection* To_conv)
	{
		int result = 0;
		sbyte b = 0;
		int num = 0;
		Int128 x = default(Int128);
		sbyte b2 = 0;
		int num2 = 0;
		Int128 @int = default(Int128);
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Int128 int2 = default(Int128);
		Int128 int3 = default(Int128);
		long x2 = 0L;
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
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
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view = default(Llvm_libc_20_1_2_cpp_string_view);
		sbyte b7 = 0;
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view2 = default(Llvm_libc_20_1_2_cpp_string_view);
		sbyte new_char = 0;
		int num16 = 0;
		int num17 = 0;
		int num18 = 0;
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view3 = default(Llvm_libc_20_1_2_cpp_string_view);
		int num19 = 0;
		int num20 = 0;
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view4 = default(Llvm_libc_20_1_2_cpp_string_view);
		int num21 = 0;
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view5 = default(Llvm_libc_20_1_2_cpp_string_view);
		int num22 = 0;
		int num23 = 0;
		int num24 = 0;
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view6 = default(Llvm_libc_20_1_2_cpp_string_view);
		int num25 = 0;
		int num26 = 0;
		int num27 = 0;
		int num28 = 0;
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view7 = default(Llvm_libc_20_1_2_cpp_string_view);
		int num29 = 0;
		int num30 = 0;
		int num31 = 0;
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view8 = default(Llvm_libc_20_1_2_cpp_string_view);
		int num32 = 0;
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view9 = default(Llvm_libc_20_1_2_cpp_string_view);
		int num33 = 0;
		int num34 = 0;
		int num35 = 0;
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view10 = default(Llvm_libc_20_1_2_cpp_string_view);
		Llvm_lifetime_start_p0.Invoke(1L, &b);
		b = -86;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = -1431655766;
		Llvm_lifetime_start_p0.Invoke(16L, &x);
		x = -6148914691236517206L;
		Llvm_lifetime_start_p0.Invoke(1L, &b2);
		b2 = -86;
		Llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = -1431655766;
		unchecked
		{
			if (To_conv->Length_modifier == LengthModifier_mnvaa2.L)
			{
				num2 = 63;
				Llvm_lifetime_start_p0.Invoke(16L, &@int);
				@int = To_conv->Conv_val_raw;
				Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi);
				*(Int128*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi) = -6148914691236517206L;
				int2 = @int;
				FPBits_long_double_FPBits_unsigned_int128.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi, *(long*)(&int2), ((long*)(&int2))[1]);
				b = (FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_is_neg.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi) ? ((sbyte)1) : ((sbyte)0));
				num = FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_explicit_exponent.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
				Struct_fiz2nb struct_fiz2nb = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_get_explicit_mantissa.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
				Int128* num36 = &int3;
				Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
				*(long*)num36 = struct_fiz2nb2.field_0;
				byte* num37 = (byte*)(&int3) + 8u;
				Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
				*(long*)num37 = struct_fiz2nb3.field_1;
				x = int3;
				b2 = (FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_is_inf_or_nan.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi) ? ((sbyte)1) : ((sbyte)0));
				Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi);
				Llvm_lifetime_end_p0.Invoke(16L, &@int);
			}
			else
			{
				num2 = 52;
				Llvm_lifetime_start_p0.Invoke(8L, &x2);
				x2 = (long)To_conv->Conv_val_raw;
				Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
				*(long*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm) = -6148914691236517206L;
				FPBits_double_FPBits_unsigned_long.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm, x2);
				b = (FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_neg.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm)) ? ((sbyte)1) : ((sbyte)0));
				num = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_explicit_exponent.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm));
				x = (Int128)(UInt128)(ulong)FPRepSem_fputil_FPType_2_fputil_FPBits_double_get_explicit_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm));
				b2 = (FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_inf_or_nan.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm)) ? ((sbyte)1) : ((sbyte)0));
				Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
				Llvm_lifetime_end_p0.Invoke(8L, &x2);
			}
			if ((b2 & 1) == 1)
			{
				result = Printf_core_convert_inf_nan.Invoke(Writer, To_conv);
				goto IL_15e1;
			}
			Llvm_lifetime_start_p0.Invoke(1L, &b3);
			b3 = 0;
			if ((b & 1) == 1)
			{
				b3 = 45;
			}
			else if (((byte)To_conv->Flags & 2) == 2)
			{
				b3 = 43;
			}
			else if (((byte)To_conv->Flags & 4) == 4)
			{
				b3 = 32;
			}
			Llvm_lifetime_start_p0.Invoke(8L, &num3);
			num3 = 4L;
			if ((ulong)(uint)num2 % 4uL != 0L && NumericHelper.IntCmpUgt(x, 0L))
			{
				num = (int)((long)num - (long)((ulong)(uint)num2 % 4uL));
			}
			Llvm_lifetime_start_p0.Invoke(8L, &num4);
			num4 = 16L;
			Llvm_lifetime_start_p0.Invoke(16L, &inlineArray16_SByte);
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
			Llvm_lifetime_start_p0.Invoke(8L, &num5);
			num5 = (long)((ulong)(uint)num2 / 4uL + 1L);
			if (checked(To_conv->Precision + 1) < (int)num5 && checked(To_conv->Precision + 1) > 0)
			{
				Llvm_lifetime_start_p0.Invoke(8L, &num6);
				num6 = checked(To_conv->Precision + 1);
				Llvm_lifetime_start_p0.Invoke(8L, &num7);
				num7 = (num5 - num6) * 4L;
				Llvm_lifetime_start_p0.Invoke(16L, &x3);
				x3 = NumericHelper.BitwiseAnd(x, NumericHelper.Subtract(NumericHelper.ShiftLeft(y: (Int128)(UInt128)(ulong)num7, x: 1L), 1L));
				Llvm_lifetime_start_p0.Invoke(16L, &y);
				y = NumericHelper.ShiftLeft(y: (Int128)(UInt128)(ulong)(num7 - 1L), x: 1L);
				x = NumericHelper.ShiftRightLogical(x, (Int128)(UInt128)(ulong)num7);
				switch (Fputil_quick_get_round.Invoke())
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
				Llvm_lifetime_end_p0.Invoke(16L, &y);
				Llvm_lifetime_end_p0.Invoke(16L, &x3);
				Llvm_lifetime_end_p0.Invoke(8L, &num7);
				Llvm_lifetime_end_p0.Invoke(8L, &num6);
			}
			Llvm_lifetime_start_p0.Invoke(8L, &num8);
			num8 = num5;
			Llvm_lifetime_start_p0.Invoke(8L, &num9);
			num9 = 1L;
			while ((ulong)num8 > 0uL)
			{
				Llvm_lifetime_start_p0.Invoke(1L, &b4);
				b4 = (sbyte)NumericHelper.RemainderUnsigned(x, 16L);
				Llvm_lifetime_start_p0.Invoke(1L, &b5);
				b5 = (sbyte)Internal_int_to_b36_char_zr4v3p.Invoke(b4);
				if (Internal_isupper_fe6jfj.Invoke(To_conv->Conv_name))
				{
					b5 = (sbyte)Internal_toupper_rp5zpj.Invoke(b5);
				}
				Unsafe.As<InlineArray16_SByte, sbyte>(ref Unsafe.AddByteOffset(ref inlineArray16_SByte, (nint)(num8 - 1L))) = b5;
				if (b5 != 48 && (ulong)num9 < (ulong)num8)
				{
					num9 = num8;
				}
				Llvm_lifetime_end_p0.Invoke(1L, &b5);
				Llvm_lifetime_end_p0.Invoke(1L, &b4);
				num8 += -1L;
				x = NumericHelper.ShiftRightLogical(x, 4L);
			}
			Llvm_lifetime_start_p0.Invoke(8L, &num10);
			num10 = num9;
			if (To_conv->Precision >= 0)
			{
				num10 = num5;
			}
			Llvm_lifetime_start_p0.Invoke(8L, &num11);
			num11 = 6L;
			Llvm_lifetime_start_p0.Invoke(6L, &inlineArray6_SByte);
			*(sbyte*)(&inlineArray6_SByte) = -86;
			((sbyte*)(&inlineArray6_SByte))[1] = -86;
			((sbyte*)(&inlineArray6_SByte))[2] = -86;
			((sbyte*)(&inlineArray6_SByte))[3] = -86;
			((sbyte*)(&inlineArray6_SByte))[4] = -86;
			((sbyte*)(&inlineArray6_SByte))[5] = -86;
			Llvm_lifetime_start_p0.Invoke(1L, &b6);
			b6 = 0;
			if (num < 0)
			{
				b6 = 1;
				num = checked(-num);
			}
			Llvm_lifetime_start_p0.Invoke(8L, &num12);
			num12 = 6L;
			while (num > 0)
			{
				sbyte b8 = (sbyte)Internal_int_to_b36_char_zr4v3p.Invoke(num % 10);
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
			Llvm_lifetime_start_p0.Invoke(8L, &num13);
			num13 = 0L;
			Llvm_lifetime_start_p0.Invoke(4L, &num14);
			num14 = -1431655766;
			Llvm_lifetime_start_p0.Invoke(8L, &num15);
			num15 = 2L;
			Llvm_lifetime_start_p0.Invoke(2L, &inlineArray2_SByte);
			*(sbyte*)(&inlineArray2_SByte) = -86;
			((sbyte*)(&inlineArray2_SByte))[1] = -86;
			*(sbyte*)(&inlineArray2_SByte) = 48;
			Unsafe.As<InlineArray2_SByte, sbyte>(ref Unsafe.AddByteOffset(ref inlineArray2_SByte, 1)) = InstructionHelper.Select(Internal_islower_qy8nhx.Invoke(To_conv->Conv_name), (sbyte)120, (sbyte)88);
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_string_view);
			*(IntPtr*)(&llvm_libc_20_1_2_cpp_string_view) = unchecked((nint)(-6148914691236517206L));
			((long*)(&llvm_libc_20_1_2_cpp_string_view))[1] = -6148914691236517206L;
			String_view_Constructor.Invoke(&llvm_libc_20_1_2_cpp_string_view, &inlineArray2_SByte, 2L);
			if (To_conv->Precision > (int)(num10 - 1L))
			{
				num13 = To_conv->Precision - (num10 - 1L);
			}
			Llvm_lifetime_start_p0.Invoke(1L, &b7);
			b7 = (sbyte)(byte)(((ulong)num10 <= 1uL) ? ((((byte)To_conv->Flags & 8) == 8) ? 1 : 0) : (-1));
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_string_view2);
			*(InlineArray2_SByte**)(&llvm_libc_20_1_2_cpp_string_view2) = Str_4_162.Pointer;
			((long*)(&llvm_libc_20_1_2_cpp_string_view2))[1] = 1L;
			Llvm_lifetime_start_p0.Invoke(1L, &new_char);
			new_char = InstructionHelper.Select(Internal_islower_qy8nhx.Invoke(To_conv->Conv_name), (sbyte)112, (sbyte)80);
			Llvm_lifetime_start_p0.Invoke(4L, &num16);
			num16 = 1;
			num14 = (int)(checked(To_conv->Min_width - InstructionHelper.Select(b3 > 0, 1, 0)) - 2L - num10 - num13 - (((b7 & 1) == 1) ? 1 : 0) - 1L - (6L - num12));
			if (num14 < 0)
			{
				num14 = 0;
			}
			if (((byte)To_conv->Flags & 1) == 1)
			{
				int num38;
				if (b3 > 0)
				{
					Llvm_lifetime_start_p0.Invoke(4L, &num17);
					num17 = Writer_write.Invoke(Writer, b3);
					if (num17 < 0)
					{
						result = num17;
						num38 = 1;
					}
					else
					{
						num38 = 0;
					}
					Llvm_lifetime_end_p0.Invoke(4L, &num17);
					switch (num38)
					{
					case 0:
						break;
					default:
						goto IL_148f;
					}
				}
				Llvm_lifetime_start_p0.Invoke(4L, &num18);
				Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_cpp_string_view3, &llvm_libc_20_1_2_cpp_string_view, 16L, isVolatile: false);
				num18 = Writer_write.Invoke(Writer, *(void**)(&llvm_libc_20_1_2_cpp_string_view3), ((long*)(&llvm_libc_20_1_2_cpp_string_view3))[1]);
				if (num18 < 0)
				{
					result = num18;
					num38 = 1;
				}
				else
				{
					num38 = 0;
				}
				Llvm_lifetime_end_p0.Invoke(4L, &num18);
				switch (num38)
				{
				case 0:
					break;
				default:
					goto IL_148f;
				}
				Llvm_lifetime_start_p0.Invoke(4L, &num19);
				num19 = Writer_write.Invoke(Writer, *(sbyte*)(&inlineArray16_SByte));
				if (num19 < 0)
				{
					result = num19;
					num38 = 1;
				}
				else
				{
					num38 = 0;
				}
				Llvm_lifetime_end_p0.Invoke(4L, &num19);
				switch (num38)
				{
				case 0:
					break;
				default:
					goto IL_148f;
				}
				if ((b7 & 1) == 1)
				{
					Llvm_lifetime_start_p0.Invoke(4L, &num20);
					Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_cpp_string_view4, &llvm_libc_20_1_2_cpp_string_view2, 16L, isVolatile: false);
					num20 = Writer_write.Invoke(Writer, *(void**)(&llvm_libc_20_1_2_cpp_string_view4), ((long*)(&llvm_libc_20_1_2_cpp_string_view4))[1]);
					if (num20 < 0)
					{
						result = num20;
						num38 = 1;
					}
					else
					{
						num38 = 0;
					}
					Llvm_lifetime_end_p0.Invoke(4L, &num20);
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
					Llvm_lifetime_start_p0.Invoke(4L, &num21);
					String_view_Constructor.Invoke(&llvm_libc_20_1_2_cpp_string_view5, Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray16_SByte, 1)), num10 - 1L);
					num21 = Writer_write.Invoke(Writer, *(void**)(&llvm_libc_20_1_2_cpp_string_view5), ((long*)(&llvm_libc_20_1_2_cpp_string_view5))[1]);
					if (num21 < 0)
					{
						result = num21;
						num38 = 1;
					}
					else
					{
						num38 = 0;
					}
					Llvm_lifetime_end_p0.Invoke(4L, &num21);
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
					Llvm_lifetime_start_p0.Invoke(4L, &num22);
					num22 = Writer_write.Invoke(Writer, 48, num13);
					if (num22 < 0)
					{
						result = num22;
						num38 = 1;
					}
					else
					{
						num38 = 0;
					}
					Llvm_lifetime_end_p0.Invoke(4L, &num22);
					switch (num38)
					{
					case 0:
						break;
					default:
						goto IL_148f;
					}
				}
				Llvm_lifetime_start_p0.Invoke(4L, &num23);
				num23 = Writer_write.Invoke(Writer, new_char);
				if (num23 < 0)
				{
					result = num23;
					num38 = 1;
				}
				else
				{
					num38 = 0;
				}
				Llvm_lifetime_end_p0.Invoke(4L, &num23);
				switch (num38)
				{
				case 0:
					break;
				default:
					goto IL_148f;
				}
				Llvm_lifetime_start_p0.Invoke(4L, &num24);
				String_view_Constructor.Invoke(&llvm_libc_20_1_2_cpp_string_view6, Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray6_SByte, (nint)num12)), 6L - num12);
				num24 = Writer_write.Invoke(Writer, *(void**)(&llvm_libc_20_1_2_cpp_string_view6), ((long*)(&llvm_libc_20_1_2_cpp_string_view6))[1]);
				if (num24 < 0)
				{
					result = num24;
					num38 = 1;
				}
				else
				{
					num38 = 0;
				}
				Llvm_lifetime_end_p0.Invoke(4L, &num24);
				switch (num38)
				{
				case 0:
					break;
				default:
					goto IL_148f;
				}
				if (num14 > 0)
				{
					Llvm_lifetime_start_p0.Invoke(4L, &num25);
					num25 = Writer_write.Invoke(Writer, 32, num14);
					if (num25 < 0)
					{
						result = num25;
						num38 = 1;
					}
					else
					{
						num38 = 0;
					}
					Llvm_lifetime_end_p0.Invoke(4L, &num25);
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
				if (num14 > 0 && ((byte)To_conv->Flags & 0x10) != 16)
				{
					Llvm_lifetime_start_p0.Invoke(4L, &num26);
					num26 = Writer_write.Invoke(Writer, 32, num14);
					if (num26 < 0)
					{
						result = num26;
						num38 = 1;
					}
					else
					{
						num38 = 0;
					}
					Llvm_lifetime_end_p0.Invoke(4L, &num26);
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
					Llvm_lifetime_start_p0.Invoke(4L, &num27);
					num27 = Writer_write.Invoke(Writer, b3);
					if (num27 < 0)
					{
						result = num27;
						num38 = 1;
					}
					else
					{
						num38 = 0;
					}
					Llvm_lifetime_end_p0.Invoke(4L, &num27);
					switch (num38)
					{
					case 0:
						break;
					default:
						goto IL_148f;
					}
				}
				Llvm_lifetime_start_p0.Invoke(4L, &num28);
				Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_cpp_string_view7, &llvm_libc_20_1_2_cpp_string_view, 16L, isVolatile: false);
				num28 = Writer_write.Invoke(Writer, *(void**)(&llvm_libc_20_1_2_cpp_string_view7), ((long*)(&llvm_libc_20_1_2_cpp_string_view7))[1]);
				if (num28 < 0)
				{
					result = num28;
					num38 = 1;
				}
				else
				{
					num38 = 0;
				}
				Llvm_lifetime_end_p0.Invoke(4L, &num28);
				switch (num38)
				{
				case 0:
					break;
				default:
					goto IL_148f;
				}
				if (num14 > 0 && ((byte)To_conv->Flags & 0x10) == 16)
				{
					Llvm_lifetime_start_p0.Invoke(4L, &num29);
					num29 = Writer_write.Invoke(Writer, 48, num14);
					if (num29 < 0)
					{
						result = num29;
						num38 = 1;
					}
					else
					{
						num38 = 0;
					}
					Llvm_lifetime_end_p0.Invoke(4L, &num29);
					switch (num38)
					{
					case 0:
						break;
					default:
						goto IL_148f;
					}
				}
				Llvm_lifetime_start_p0.Invoke(4L, &num30);
				num30 = Writer_write.Invoke(Writer, *(sbyte*)(&inlineArray16_SByte));
				if (num30 < 0)
				{
					result = num30;
					num38 = 1;
				}
				else
				{
					num38 = 0;
				}
				Llvm_lifetime_end_p0.Invoke(4L, &num30);
				switch (num38)
				{
				case 0:
					break;
				default:
					goto IL_148f;
				}
				if ((b7 & 1) == 1)
				{
					Llvm_lifetime_start_p0.Invoke(4L, &num31);
					Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_cpp_string_view8, &llvm_libc_20_1_2_cpp_string_view2, 16L, isVolatile: false);
					num31 = Writer_write.Invoke(Writer, *(void**)(&llvm_libc_20_1_2_cpp_string_view8), ((long*)(&llvm_libc_20_1_2_cpp_string_view8))[1]);
					if (num31 < 0)
					{
						result = num31;
						num38 = 1;
					}
					else
					{
						num38 = 0;
					}
					Llvm_lifetime_end_p0.Invoke(4L, &num31);
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
					Llvm_lifetime_start_p0.Invoke(4L, &num32);
					String_view_Constructor.Invoke(&llvm_libc_20_1_2_cpp_string_view9, Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray16_SByte, 1)), num10 - 1L);
					num32 = Writer_write.Invoke(Writer, *(void**)(&llvm_libc_20_1_2_cpp_string_view9), ((long*)(&llvm_libc_20_1_2_cpp_string_view9))[1]);
					if (num32 < 0)
					{
						result = num32;
						num38 = 1;
					}
					else
					{
						num38 = 0;
					}
					Llvm_lifetime_end_p0.Invoke(4L, &num32);
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
					Llvm_lifetime_start_p0.Invoke(4L, &num33);
					num33 = Writer_write.Invoke(Writer, 48, num13);
					if (num33 < 0)
					{
						result = num33;
						num38 = 1;
					}
					else
					{
						num38 = 0;
					}
					Llvm_lifetime_end_p0.Invoke(4L, &num33);
					switch (num38)
					{
					case 0:
						break;
					default:
						goto IL_148f;
					}
				}
				Llvm_lifetime_start_p0.Invoke(4L, &num34);
				num34 = Writer_write.Invoke(Writer, new_char);
				if (num34 < 0)
				{
					result = num34;
					num38 = 1;
				}
				else
				{
					num38 = 0;
				}
				Llvm_lifetime_end_p0.Invoke(4L, &num34);
				switch (num38)
				{
				case 0:
					break;
				default:
					goto IL_148f;
				}
				Llvm_lifetime_start_p0.Invoke(4L, &num35);
				String_view_Constructor.Invoke(&llvm_libc_20_1_2_cpp_string_view10, Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray6_SByte, (nint)num12)), 6L - num12);
				num35 = Writer_write.Invoke(Writer, *(void**)(&llvm_libc_20_1_2_cpp_string_view10), ((long*)(&llvm_libc_20_1_2_cpp_string_view10))[1]);
				if (num35 < 0)
				{
					result = num35;
					num38 = 1;
				}
				else
				{
					num38 = 0;
				}
				Llvm_lifetime_end_p0.Invoke(4L, &num35);
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
		Llvm_lifetime_end_p0.Invoke(4L, &num2);
		Llvm_lifetime_end_p0.Invoke(1L, &b2);
		Llvm_lifetime_end_p0.Invoke(16L, &x);
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		Llvm_lifetime_end_p0.Invoke(1L, &b);
		return result;
		IL_148f:
		Llvm_lifetime_end_p0.Invoke(4L, &num16);
		Llvm_lifetime_end_p0.Invoke(1L, &new_char);
		Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_string_view2);
		Llvm_lifetime_end_p0.Invoke(1L, &b7);
		Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_string_view);
		Llvm_lifetime_end_p0.Invoke(2L, &inlineArray2_SByte);
		Llvm_lifetime_end_p0.Invoke(8L, &num15);
		Llvm_lifetime_end_p0.Invoke(4L, &num14);
		Llvm_lifetime_end_p0.Invoke(8L, &num13);
		Llvm_lifetime_end_p0.Invoke(8L, &num12);
		Llvm_lifetime_end_p0.Invoke(1L, &b6);
		Llvm_lifetime_end_p0.Invoke(6L, &inlineArray6_SByte);
		Llvm_lifetime_end_p0.Invoke(8L, &num11);
		Llvm_lifetime_end_p0.Invoke(8L, &num10);
		Llvm_lifetime_end_p0.Invoke(8L, &num9);
		Llvm_lifetime_end_p0.Invoke(8L, &num8);
		Llvm_lifetime_end_p0.Invoke(8L, &num5);
		Llvm_lifetime_end_p0.Invoke(16L, &inlineArray16_SByte);
		Llvm_lifetime_end_p0.Invoke(8L, &num4);
		Llvm_lifetime_end_p0.Invoke(8L, &num3);
		Llvm_lifetime_end_p0.Invoke(1L, &b3);
		goto IL_15e1;
	}
}
