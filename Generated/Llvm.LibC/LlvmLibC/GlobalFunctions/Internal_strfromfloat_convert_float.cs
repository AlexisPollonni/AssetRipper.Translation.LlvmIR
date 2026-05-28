using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_strfromfloat_convert_float
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal20strfromfloat_convertIfEEiPNS_11printf_core6WriterERKNS2_13FormatSectionE")]
	[DemangledName("int __llvm_libc_20_1_2_::internal::strfromfloat_convert<float>(__llvm_libc_20_1_2_::printf_core::Writer*, __llvm_libc_20_1_2_::printf_core::FormatSection const&)")]
	[return: NativeType("int")]
	public unsafe static int Invoke([MangledName("writer")][NativeType("__llvm_libc_20_1_2_::printf_core::Writer*")] Printf_core_Writer* Writer, [MangledName("section")][NativeType("__llvm_libc_20_1_2_::printf_core::FormatSection const&")] Printf_core_FormatSection* Section)
	{
		Cpp_string_view cpp_string_view = default(Cpp_string_view);
		int x = 0;
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs = default(Fputil_FPBits_5nkvcs);
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(Fputil_FPBits_5nkvcs);
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(Fputil_FPBits_5nkvcs);
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs4 = default(Fputil_FPBits_5nkvcs);
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
				Llvm_lifetime_start_p0.Invoke(4L, &x);
				x = (int)Section->Conv_val_raw;
				Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs);
				*(int*)(&fputil_FPBits_5nkvcs) = -1431655766;
				FPBits_float_FPBits_unsigned_int.Invoke(&fputil_FPBits_5nkvcs, x);
				if (FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_inf_or_nan.Invoke((Fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs)))
				{
					result = Printf_core_convert_inf_nan.Invoke(Writer, Section);
				}
				else
				{
					switch (Section->Conv_name)
					{
					case 70:
					case 102:
						Llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_5nkvcs2, &fputil_FPBits_5nkvcs, 4L, isVolatile: false);
						result = Printf_core_convert_float_decimal_typed_float_0.Invoke(Writer, Section, fputil_FPBits_5nkvcs2.FPRepImpl.FPRepSem.field_0.field_0);
						break;
					case 69:
					case 101:
						Llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_5nkvcs3, &fputil_FPBits_5nkvcs, 4L, isVolatile: false);
						result = Printf_core_convert_float_dec_exp_typed_float_0.Invoke(Writer, Section, fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0);
						break;
					case 65:
					case 97:
						result = Printf_core_convert_float_hex_exp.Invoke(Writer, Section);
						break;
					case 71:
					case 103:
						Llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_5nkvcs4, &fputil_FPBits_5nkvcs, 4L, isVolatile: false);
						result = Printf_core_convert_float_dec_auto_typed_float_0.Invoke(Writer, Section, fputil_FPBits_5nkvcs4.FPRepImpl.FPRepSem.field_0.field_0);
						break;
					default:
						Llvm_memcpy_p0_p0_i64.Invoke(&cpp_string_view2, &Section->Raw_string, 16L, isVolatile: false);
						result = Writer_write.Invoke(Writer, *(void**)(&cpp_string_view2), ((long*)(&cpp_string_view2))[1]);
						break;
					}
				}
				Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs);
				Llvm_lifetime_end_p0.Invoke(4L, &x);
			}
			return result;
		}
	}
}
