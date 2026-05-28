using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_strfromfloat_convert_long_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal20strfromfloat_convertIeEEiPNS_11printf_core6WriterERKNS2_13FormatSectionE")]
	[DemangledName("int __llvm_libc_20_1_2_::internal::strfromfloat_convert<long double>(__llvm_libc_20_1_2_::printf_core::Writer*, __llvm_libc_20_1_2_::printf_core::FormatSection const&)")]
	[return: NativeType("int")]
	public unsafe static int Invoke([MangledName("writer")][NativeType("__llvm_libc_20_1_2_::printf_core::Writer*")] Printf_core_Writer* Writer, [MangledName("section")][NativeType("__llvm_libc_20_1_2_::printf_core::FormatSection const&")] Printf_core_FormatSection* Section)
	{
		Cpp_string_view cpp_string_view = default(Cpp_string_view);
		Int128 @int = default(Int128);
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi = default(Fputil_FPBits_ubgsi2);
		Int128 int2 = default(Int128);
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi2 = default(Fputil_FPBits_ubgsi2);
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(Fputil_FPBits_ubgsi2);
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi4 = default(Fputil_FPBits_ubgsi2);
		Cpp_string_view cpp_string_view2 = default(Cpp_string_view);
		unchecked
		{
			int result;
			if ((Section->Has_conv & 1) != 1)
			{
				Llvm_memcpy_p0_p0_i64.Invoke(&cpp_string_view, &Section->Raw_string, 16L, isVolatile: false);
				result = Writer_write.Invoke(Writer, *(void**)(&cpp_string_view), ((long*)(&cpp_string_view))[1]);
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(16L, &@int);
				@int = Section->Conv_val_raw;
				Llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi);
				*(Int128*)(&fputil_FPBits_ubgsi) = -6148914691236517206L;
				int2 = @int;
				FPBits_long_double_FPBits_unsigned_int128.Invoke(&fputil_FPBits_ubgsi, *(long*)(&int2), ((long*)(&int2))[1]);
				if (FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_is_inf_or_nan.Invoke(&fputil_FPBits_ubgsi))
				{
					result = Printf_core_convert_inf_nan.Invoke(Writer, Section);
				}
				else
				{
					switch (Section->Conv_name)
					{
					case 70:
					case 102:
						Llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi2, &fputil_FPBits_ubgsi, 16L, isVolatile: false);
						result = Printf_core_convert_float_decimal_typed_long_double_0.Invoke(Writer, Section, *(long*)(&fputil_FPBits_ubgsi2), ((long*)(&fputil_FPBits_ubgsi2))[1]);
						break;
					case 69:
					case 101:
						Llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi3, &fputil_FPBits_ubgsi, 16L, isVolatile: false);
						result = Printf_core_convert_float_dec_exp_typed_long_double_0.Invoke(Writer, Section, *(long*)(&fputil_FPBits_ubgsi3), ((long*)(&fputil_FPBits_ubgsi3))[1]);
						break;
					case 65:
					case 97:
						result = Printf_core_convert_float_hex_exp.Invoke(Writer, Section);
						break;
					case 71:
					case 103:
						Llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi4, &fputil_FPBits_ubgsi, 16L, isVolatile: false);
						result = Printf_core_convert_float_dec_auto_typed_long_double_0.Invoke(Writer, Section, *(long*)(&fputil_FPBits_ubgsi4), ((long*)(&fputil_FPBits_ubgsi4))[1]);
						break;
					default:
						Llvm_memcpy_p0_p0_i64.Invoke(&cpp_string_view2, &Section->Raw_string, 16L, isVolatile: false);
						result = Writer_write.Invoke(Writer, *(void**)(&cpp_string_view2), ((long*)(&cpp_string_view2))[1]);
						break;
					}
				}
				Llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi);
				Llvm_lifetime_end_p0.Invoke(16L, &@int);
			}
			return result;
		}
	}
}
