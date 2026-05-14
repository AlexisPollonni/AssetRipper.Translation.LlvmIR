using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core15convert_inf_nanEPNS0_6WriterERKNS0_13FormatSectionE")]
[DemangledName("__llvm_libc_20_1_2_::printf_core::convert_inf_nan(__llvm_libc_20_1_2_::printf_core::Writer*, __llvm_libc_20_1_2_::printf_core::FormatSection const&)")]
internal static partial class printf_core_convert_inf_nan_printf_core_Writer_printf_core_FormatSection_const
{
	public unsafe static int Invoke(printf_core_Writer* writer, printf_core_FormatSection* to_conv)
	{
		int result = 0;
		sbyte b = 0;
		Int128 x = default(Int128);
		Int128 @int = default(Int128);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(fputil_FPBits_ubgsi2);
		Int128 int2 = default(Int128);
		Int128 int3 = default(Int128);
		long x2 = 0L;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		sbyte b2 = 0;
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		int num5 = 0;
		cpp_string_view cpp_string_view3 = default(cpp_string_view);
		int num6 = 0;
		llvm_lifetime_start_p0.Invoke(1L, &b);
		b = -86;
		llvm_lifetime_start_p0.Invoke(16L, &x);
		x = -6148914691236517206L;
		unchecked
		{
			if (to_conv->length_modifier == LengthModifier_mnvaa2.L)
			{
				llvm_lifetime_start_p0.Invoke(16L, &@int);
				@int = to_conv->conv_val_raw;
				llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
				*(Int128*)(&fputil_FPBits_ubgsi3) = -6148914691236517206L;
				int2 = @int;
				fputil_FPBits_long_double_FPBits_unsigned_int128_unsigned_int128.Invoke(&fputil_FPBits_ubgsi3, *(long*)(&int2), ((long*)(&int2))[1]);
				b = (fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_is_neg_const.Invoke(&fputil_FPBits_ubgsi3) ? ((sbyte)1) : ((sbyte)0));
				Struct_fiz2nb struct_fiz2nb = fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_mantissa_const.Invoke(&fputil_FPBits_ubgsi3);
				Int128* num7 = &int3;
				Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
				*(long*)num7 = struct_fiz2nb2.field_0;
				byte* num8 = (byte*)(&int3) + 8u;
				Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
				*(long*)num8 = struct_fiz2nb3.field_1;
				x = int3;
				llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
				llvm_lifetime_end_p0.Invoke(16L, &@int);
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(8L, &x2);
				x2 = (long)to_conv->conv_val_raw;
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
				*(long*)(&fputil_FPBits_wjhbrm2) = -6148914691236517206L;
				fputil_FPBits_double_FPBits_unsigned_long_unsigned_long.Invoke(&fputil_FPBits_wjhbrm2, x2);
				b = (fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_neg_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2)) ? ((sbyte)1) : ((sbyte)0));
				x = (Int128)(UInt128)(ulong)fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2));
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
				llvm_lifetime_end_p0.Invoke(8L, &x2);
			}
			llvm_lifetime_start_p0.Invoke(1L, &b2);
			b2 = 0;
			if ((b & 1) == 1)
			{
				b2 = 45;
			}
			else if (((byte)to_conv->flags & 2) == 2)
			{
				b2 = 43;
			}
			else if (((byte)to_conv->flags & 4) == 4)
			{
				b2 = 32;
			}
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = checked(to_conv->min_width - InstructionHelper.Select(b2 > 0, 1, 0) - 3);
			if (num > 0 && ((byte)to_conv->flags & 1) != 1)
			{
				llvm_lifetime_start_p0.Invoke(4L, &num2);
				num2 = printf_core_Writer_write_char_unsigned_long.Invoke(writer, 32, num);
				int num9;
				if (num2 < 0)
				{
					result = num2;
					num9 = 1;
				}
				else
				{
					num9 = 0;
				}
				llvm_lifetime_end_p0.Invoke(4L, &num2);
				switch (num9)
				{
				case 0:
					break;
				default:
					goto IL_04ff;
				}
			}
			if (b2 != 0)
			{
				llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = printf_core_Writer_write_char.Invoke(writer, b2);
				int num9;
				if (num3 < 0)
				{
					result = num3;
					num9 = 1;
				}
				else
				{
					num9 = 0;
				}
				llvm_lifetime_end_p0.Invoke(4L, &num3);
				switch (num9)
				{
				case 0:
					break;
				default:
					goto IL_04ff;
				}
			}
			if (NumericHelper.IntCmpEq(x, 0L))
			{
				llvm_lifetime_start_p0.Invoke(4L, &num4);
				void* ptr = writer;
				cpp_string_view_string_view_char_const.Invoke(&cpp_string_view2, (!internal_islower_int.Invoke(to_conv->conv_name)) ? str_1_166.Pointer : str_165.Pointer);
				num4 = printf_core_Writer_write_cpp_string_view.Invoke((printf_core_Writer*)ptr, *(void**)(&cpp_string_view2), ((long*)(&cpp_string_view2))[1]);
				int num9;
				if (num4 < 0)
				{
					result = num4;
					num9 = 1;
				}
				else
				{
					num9 = 0;
				}
				llvm_lifetime_end_p0.Invoke(4L, &num4);
				switch (num9)
				{
				case 0:
					break;
				default:
					goto IL_04ff;
				}
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(4L, &num5);
				void* ptr2 = writer;
				cpp_string_view_string_view_char_const.Invoke(&cpp_string_view3, (!internal_islower_int.Invoke(to_conv->conv_name)) ? str_3_168.Pointer : str_2_167.Pointer);
				num5 = printf_core_Writer_write_cpp_string_view.Invoke((printf_core_Writer*)ptr2, *(void**)(&cpp_string_view3), ((long*)(&cpp_string_view3))[1]);
				int num9;
				if (num5 < 0)
				{
					result = num5;
					num9 = 1;
				}
				else
				{
					num9 = 0;
				}
				llvm_lifetime_end_p0.Invoke(4L, &num5);
				switch (num9)
				{
				case 0:
					break;
				default:
					goto IL_04ff;
				}
			}
			if (num > 0 && ((byte)to_conv->flags & 1) == 1)
			{
				llvm_lifetime_start_p0.Invoke(4L, &num6);
				num6 = printf_core_Writer_write_char_unsigned_long.Invoke(writer, 32, num);
				int num9;
				if (num6 < 0)
				{
					result = num6;
					num9 = 1;
				}
				else
				{
					num9 = 0;
				}
				llvm_lifetime_end_p0.Invoke(4L, &num6);
				switch (num9)
				{
				case 0:
					break;
				default:
					goto IL_04ff;
				}
			}
			result = 0;
			goto IL_04ff;
		}
		IL_04ff:
		llvm_lifetime_end_p0.Invoke(4L, &num);
		llvm_lifetime_end_p0.Invoke(1L, &b2);
		llvm_lifetime_end_p0.Invoke(16L, &x);
		llvm_lifetime_end_p0.Invoke(1L, &b);
		return result;
	}
}
