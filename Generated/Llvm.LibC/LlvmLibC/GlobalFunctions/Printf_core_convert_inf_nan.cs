using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Printf_core_convert_inf_nan
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core15convert_inf_nanEPNS0_6WriterERKNS0_13FormatSectionE")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::convert_inf_nan(__llvm_libc_20_1_2_::printf_core::Writer*, __llvm_libc_20_1_2_::printf_core::FormatSection const&)")]
	public unsafe static int Invoke([MangledName("writer")][NativeType("__llvm_libc_20_1_2_::printf_core::Writer*")] Llvm_libc_20_1_2_printf_core_Writer* Writer, [MangledName("to_conv")][NativeType("__llvm_libc_20_1_2_::printf_core::FormatSection const&")] Llvm_libc_20_1_2_printf_core_FormatSection* To_conv)
	{
		int result = 0;
		sbyte b = 0;
		Int128 x = default(Int128);
		Int128 @int = default(Int128);
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Int128 int2 = default(Int128);
		Int128 int3 = default(Int128);
		long x2 = 0L;
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		sbyte b2 = 0;
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view = default(Llvm_libc_20_1_2_cpp_string_view);
		int num5 = 0;
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view2 = default(Llvm_libc_20_1_2_cpp_string_view);
		int num6 = 0;
		Llvm_lifetime_start_p0.Invoke(1L, &b);
		b = -86;
		Llvm_lifetime_start_p0.Invoke(16L, &x);
		x = -6148914691236517206L;
		unchecked
		{
			if (To_conv->Length_modifier == LengthModifier_mnvaa2.L)
			{
				Llvm_lifetime_start_p0.Invoke(16L, &@int);
				@int = To_conv->Conv_val_raw;
				Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi);
				*(Int128*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi) = -6148914691236517206L;
				int2 = @int;
				FPBits_long_double_FPBits_unsigned_int128.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi, *(long*)(&int2), ((long*)(&int2))[1]);
				b = (FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_is_neg.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi) ? ((sbyte)1) : ((sbyte)0));
				Struct_fiz2nb struct_fiz2nb = FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_mantissa.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
				Int128* num7 = &int3;
				Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
				*(long*)num7 = struct_fiz2nb2.field_0;
				byte* num8 = (byte*)(&int3) + 8u;
				Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
				*(long*)num8 = struct_fiz2nb3.field_1;
				x = int3;
				Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi);
				Llvm_lifetime_end_p0.Invoke(16L, &@int);
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(8L, &x2);
				x2 = (long)To_conv->Conv_val_raw;
				Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
				*(long*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm) = -6148914691236517206L;
				FPBits_double_FPBits_unsigned_long.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm, x2);
				b = (FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_neg.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm)) ? ((sbyte)1) : ((sbyte)0));
				x = (Int128)(UInt128)(ulong)FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm));
				Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
				Llvm_lifetime_end_p0.Invoke(8L, &x2);
			}
			Llvm_lifetime_start_p0.Invoke(1L, &b2);
			b2 = 0;
			if ((b & 1) == 1)
			{
				b2 = 45;
			}
			else if (((byte)To_conv->Flags & 2) == 2)
			{
				b2 = 43;
			}
			else if (((byte)To_conv->Flags & 4) == 4)
			{
				b2 = 32;
			}
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = checked(To_conv->Min_width - InstructionHelper.Select(b2 > 0, 1, 0) - 3);
			if (num > 0 && ((byte)To_conv->Flags & 1) != 1)
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num2);
				num2 = Writer_write.Invoke(Writer, 32, num);
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
				Llvm_lifetime_end_p0.Invoke(4L, &num2);
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
				Llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = Writer_write.Invoke(Writer, b2);
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
				Llvm_lifetime_end_p0.Invoke(4L, &num3);
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
				Llvm_lifetime_start_p0.Invoke(4L, &num4);
				void* ptr = Writer;
				String_view_Constructor.Invoke(&llvm_libc_20_1_2_cpp_string_view, (!Internal_islower_qy8nhx.Invoke(To_conv->Conv_name)) ? Str_1_166.Pointer : Str_165.Pointer);
				num4 = Writer_write.Invoke((Llvm_libc_20_1_2_printf_core_Writer*)ptr, *(void**)(&llvm_libc_20_1_2_cpp_string_view), ((long*)(&llvm_libc_20_1_2_cpp_string_view))[1]);
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
				Llvm_lifetime_end_p0.Invoke(4L, &num4);
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
				Llvm_lifetime_start_p0.Invoke(4L, &num5);
				void* ptr2 = Writer;
				String_view_Constructor.Invoke(&llvm_libc_20_1_2_cpp_string_view2, (!Internal_islower_qy8nhx.Invoke(To_conv->Conv_name)) ? Str_3_168.Pointer : Str_2_167.Pointer);
				num5 = Writer_write.Invoke((Llvm_libc_20_1_2_printf_core_Writer*)ptr2, *(void**)(&llvm_libc_20_1_2_cpp_string_view2), ((long*)(&llvm_libc_20_1_2_cpp_string_view2))[1]);
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
				Llvm_lifetime_end_p0.Invoke(4L, &num5);
				switch (num9)
				{
				case 0:
					break;
				default:
					goto IL_04ff;
				}
			}
			if (num > 0 && ((byte)To_conv->Flags & 1) == 1)
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num6);
				num6 = Writer_write.Invoke(Writer, 32, num);
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
				Llvm_lifetime_end_p0.Invoke(4L, &num6);
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
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		Llvm_lifetime_end_p0.Invoke(1L, &b2);
		Llvm_lifetime_end_p0.Invoke(16L, &x);
		Llvm_lifetime_end_p0.Invoke(1L, &b);
		return result;
	}
}
