using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_strfromfloat_convert_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal20strfromfloat_convertIdEEiPNS_11printf_core6WriterERKNS2_13FormatSectionE")]
	[DemangledName("int __llvm_libc_20_1_2_::internal::strfromfloat_convert<double>(__llvm_libc_20_1_2_::printf_core::Writer*, __llvm_libc_20_1_2_::printf_core::FormatSection const&)")]
	[return: NativeType("int")]
	public unsafe static int Invoke([MangledName("writer")][NativeType("__llvm_libc_20_1_2_::printf_core::Writer*")] Printf_core_Writer* Writer, [MangledName("section")][NativeType("__llvm_libc_20_1_2_::printf_core::FormatSection const&")] Printf_core_FormatSection* Section)
	{
		Cpp_string_view cpp_string_view = default(Cpp_string_view);
		long x = 0L;
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm = default(Fputil_FPBits_wjhbrm);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(Fputil_FPBits_wjhbrm);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(Fputil_FPBits_wjhbrm);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm4 = default(Fputil_FPBits_wjhbrm);
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
				Llvm_lifetime_start_p0.Invoke(8L, &x);
				x = (long)Section->Conv_val_raw;
				Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
				*(long*)(&fputil_FPBits_wjhbrm) = -6148914691236517206L;
				FPBits_double_FPBits_unsigned_long.Invoke(&fputil_FPBits_wjhbrm, x);
				if (FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_inf_or_nan.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm)))
				{
					result = Printf_core_convert_inf_nan.Invoke(Writer, Section);
				}
				else
				{
					switch (Section->Conv_name)
					{
					case 70:
					case 102:
						Llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_wjhbrm2, &fputil_FPBits_wjhbrm, 8L, isVolatile: false);
						result = Printf_core_convert_float_decimal_typed_double_0.Invoke(Writer, Section, fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.Val);
						break;
					case 69:
					case 101:
						Llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_wjhbrm3, &fputil_FPBits_wjhbrm, 8L, isVolatile: false);
						result = Printf_core_convert_float_dec_exp_typed_double_0.Invoke(Writer, Section, fputil_FPBits_wjhbrm3.FPRepImpl.FPRepSem.FPStorage.Val);
						break;
					case 65:
					case 97:
						result = Printf_core_convert_float_hex_exp.Invoke(Writer, Section);
						break;
					case 71:
					case 103:
						Llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_wjhbrm4, &fputil_FPBits_wjhbrm, 8L, isVolatile: false);
						result = Printf_core_convert_float_dec_auto_typed_double_0.Invoke(Writer, Section, fputil_FPBits_wjhbrm4.FPRepImpl.FPRepSem.FPStorage.Val);
						break;
					default:
						Llvm_memcpy_p0_p0_i64.Invoke(&cpp_string_view2, &Section->Raw_string, 16L, isVolatile: false);
						result = Writer_write.Invoke(Writer, *(void**)(&cpp_string_view2), ((long*)(&cpp_string_view2))[1]);
						break;
					}
				}
				Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
				Llvm_lifetime_end_p0.Invoke(8L, &x);
			}
			return result;
		}
	}
}
